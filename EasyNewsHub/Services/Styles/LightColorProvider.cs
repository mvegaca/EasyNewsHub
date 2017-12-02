using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Media;

namespace EasyNewsHub.Services
{
    public class LightColorProvider : IColorProvider
    {
        private static Color Color_DDDDDD = new Color() { A = 255, R = 221, G = 221, B = 221 };
        private static Color Color_333333 = new Color() { A = 255, R = 51, G = 51, B = 51 };
        private static Color Color_666666 = new Color() { A = 255, R = 102, G = 102, B = 102 };

        public Brush ArticleTextColor => new SolidColorBrush(Color_333333);
        public Brush ListItemTitleColor => new SolidColorBrush(Color_333333);
        public Brush ListItemSubTitleColor => new SolidColorBrush(Color_333333);
        public Brush ListItemAuthorColor => new SolidColorBrush(Color_666666);
        public Brush ListItemPublishDateColor => new SolidColorBrush(Color_666666);

        public Brush PageBackgroundColor => new SolidColorBrush(Color_DDDDDD);
    }
}
