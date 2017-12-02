using System;

using EasyNewsHub.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace EasyNewsHub.Views
{
    public sealed partial class FeedListPage : Page
    {
        public FeedListViewModel ViewModel => FeedListViewModel.Current;

        public FeedListPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            await ViewModel.LoadAsync();
        }
    }
}
