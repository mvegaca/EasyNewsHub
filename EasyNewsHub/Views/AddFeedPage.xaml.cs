using System;

using EasyNewsHub.ViewModels;

using Windows.UI.Xaml.Controls;

namespace EasyNewsHub.Views
{
    public sealed partial class AddFeedPage : Page
    {
        public AddFeedViewModel ViewModel { get; } = new AddFeedViewModel();

        public AddFeedPage()
        {
            InitializeComponent();
        }
    }
}
