using System;

using EasyNewsHub.Helpers;
using System.Threading.Tasks;
using Windows.Storage;
using System.Collections.ObjectModel;
using System.Linq;
using EasyNewsHub.Services;
using System.Windows.Input;
using System.Collections;
using System.Collections.Generic;
using EasyNewsHub.Models;
using Windows.UI.Xaml.Controls;

namespace EasyNewsHub.ViewModels
{
    public class FeedListViewModel : ViewModelBase
    {
        private static FeedListViewModel _current;
        public static FeedListViewModel Current => _current ?? (_current = new FeedListViewModel());

        private ICommand _itemClickCommand;
        public ICommand ItemClickCommand => _itemClickCommand ?? (_itemClickCommand = new RelayCommand<ItemClickEventArgs>(OnItemClick));

        public ObservableCollection<object> Feeds { get; } = new ObservableCollection<object>();

        public FeedListViewModel()
        {
        }

        public async Task LoadAsync()
        {
            if (!Feeds.Any())
            {
                var cacheData = await ApplicationData.Current.LocalFolder.ReadAsync<IEnumerable<FeedModel>>(Constants.SettingsKey_NewsFeeds);
                if (cacheData != null)
                {
                    cacheData.ToList().ForEach(f => Feeds.Add(new FeedViewModel(f)));
                }
                else
                {
                    SampleDataService.SampleFeeds.ToList().ForEach(f => Feeds.Add(f));
                    await SaveAsync();
                }
                Feeds.Add(new object());
            }
        }

        public async Task AddFeedAsync(FeedViewModel feed)
        {
            Feeds.Insert(0, feed);
            await SaveAsync();
        }

        private void OnItemClick(ItemClickEventArgs args)
        {
            var feed = args.ClickedItem as FeedViewModel;
            if (feed != null)
            {
                NavigationService.Navigate<Views.NewsListPage>(feed.Id);
            }
            else
            {
                NavigationService.Navigate<Views.AddFeedPage>();
            }
        }

        private async Task SaveAsync()
        {
            IEnumerable<FeedModel> feedModels = Feeds.Where(f => f is FeedViewModel).Select(f => ((FeedViewModel)f).GetModel());
            await ApplicationData.Current.LocalFolder.SaveAsync(Constants.SettingsKey_NewsFeeds, feedModels);
        }
    }
}
