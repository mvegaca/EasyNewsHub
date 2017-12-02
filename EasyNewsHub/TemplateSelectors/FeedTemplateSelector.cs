using EasyNewsHub.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace EasyNewsHub.TemplateSelectors
{
    public class FeedTemplateSelector : DataTemplateSelector
    {
        public DataTemplate FeedTemplate { get; set; }

        public DataTemplate AddFeedTemplate { get; set; }

        protected override DataTemplate SelectTemplateCore(object item, DependencyObject container)
        {
            if (item is FeedViewModel)
            {
                return FeedTemplate;
            }
            else
            {
                return AddFeedTemplate;
            }
        }
    }
}
