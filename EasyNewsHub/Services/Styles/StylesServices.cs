using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace EasyNewsHub.Services
{
    public class StylesServices : DependencyObject
    {
        public Brush PageBackgroundColor { get; private set; }

        public Brush ArticleTextColor { get; private set; }

        public Brush ListItemTitleColor { get; private set; }
        public Brush ListItemSubTitleColor { get; private set; }
        public Brush ListItemAuthorColor { get; private set; }
        public Brush ListItemPublishDateColor { get; private set; }

        public StylesServices()
        {
        }

        public void LoadData()
        {
            var provider = GetColorProvider();

            PageBackgroundColor = provider.PageBackgroundColor;

            ArticleTextColor = provider.ArticleTextColor;

            ListItemTitleColor = provider.ListItemTitleColor;
            ListItemSubTitleColor = provider.ListItemSubTitleColor;
            ListItemAuthorColor = provider.ListItemAuthorColor;
            ListItemPublishDateColor = provider.ListItemPublishDateColor;
        }

        private IColorProvider GetColorProvider()
        {
            return new LightColorProvider();
        }
    }
}
