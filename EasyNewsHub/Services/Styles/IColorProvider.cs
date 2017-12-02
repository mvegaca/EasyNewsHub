using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;

namespace EasyNewsHub.Services
{
    public interface IColorProvider
    {
        Brush PageBackgroundColor { get; }

        Brush ArticleTextColor { get; }

        Brush ListItemTitleColor { get; }
        Brush ListItemSubTitleColor { get; }
        Brush ListItemAuthorColor { get; }
        Brush ListItemPublishDateColor { get; }
    }
}
