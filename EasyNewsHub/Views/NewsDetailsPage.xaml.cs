using System;

using EasyNewsHub.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace EasyNewsHub.Views
{
    public sealed partial class NewsDetailsPage : Page
    {
        public NewsDetailsViewModel ViewModel { get; } = new NewsDetailsViewModel();

        public NewsDetailsPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var item = e.Parameter as NewsViewModel;
            if (item != null)
            {
                ViewModel.Load(item);
            }
        }
    }
}
