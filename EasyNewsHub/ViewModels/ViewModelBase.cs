using EasyNewsHub.Helpers;
using EasyNewsHub.Services;
using Windows.UI.Xaml.Media;

namespace EasyNewsHub.ViewModels
{
    public abstract class ViewModelBase : Observable
    {
        private bool _isBusy;
        public bool IsBusy { get => _isBusy; set => Set(ref _isBusy, value); }

        public Brush PageBackgroundColor => Singleton<StylesServices>.Instance.PageBackgroundColor;
    }
}
