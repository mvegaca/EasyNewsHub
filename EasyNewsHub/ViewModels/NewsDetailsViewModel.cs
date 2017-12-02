using System;

using EasyNewsHub.Helpers;

namespace EasyNewsHub.ViewModels
{
    public class NewsDetailsViewModel : ViewModelBase
    {
        private NewsViewModel _item;

        public NewsViewModel Item
        {
            get => _item;
            set => Set(ref _item, value);
        }

        public NewsDetailsViewModel()
        {
        }

        internal void Load(NewsViewModel item)
        {
            Item = item;
        }
    }
}
