using System;

using EasyNewsHub.Helpers;

namespace EasyNewsHub.ViewModels
{
    public class AddFeedViewModel : ViewModelBase
    {
        private bool _canSave = false;

        private RelayCommand _saveCommand;
        public RelayCommand SaveCommand => _saveCommand ?? (_saveCommand = new RelayCommand(OnSave, () => _canSave));


        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                Set(ref _name, value);
                UpdateCanSave();
            }
        }
        private string _url;

        public string Url
        {
            get { return _url; }
            set
            {
                Set(ref _url, value);
                UpdateCanSave();
            }
        }


        public AddFeedViewModel()
        {
        }

        private async void OnSave()
        {
            await FeedListViewModel.Current.AddFeedAsync(new FeedViewModel()
            {
                Name = Name,
                Url = Url
            });
        }

        private void UpdateCanSave()
        {
            _canSave = !string.IsNullOrEmpty(Name) &&
                       !string.IsNullOrEmpty(Url);
            SaveCommand.OnCanExecuteChanged();
        }
    }
}
