using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MarkupChain.WPF
{
    public static partial class GridSplitterExtensions
    {
        public static T ResizeBehavior<T>(this T grdSplitter, GridResizeBehavior resizeBehavior) where T : GridSplitter
        {
            grdSplitter.SetValue (GridSplitter.ResizeBehaviorProperty, resizeBehavior);
            return grdSplitter;
        }

        public static T PreviewStyle<T>(this T grdSplitter, Style previewStyle) where T : GridSplitter
        {
            grdSplitter.SetValue (GridSplitter.PreviewStyleProperty, previewStyle);
            return grdSplitter;
        }

        public static T KeyboardIncrement<T>(this T grdSplitter, double keyboardIncrement) where T : GridSplitter
        {
            grdSplitter.SetValue (GridSplitter.KeyboardIncrementProperty, keyboardIncrement);
            return grdSplitter;
        }

        public static T DragIncrement<T>(this T grdSplitter, bool dragIncrement) where T : GridSplitter
        {
            grdSplitter.SetValue (GridSplitter.DragIncrementProperty, dragIncrement);
            return grdSplitter;
        }

        public static T ResizeDirection<T>(this T grdSplitter, GridResizeDirection resizeDirection) where T : GridSplitter
        {
            grdSplitter.SetValue (GridSplitter.ResizeDirectionProperty, resizeDirection);
            return grdSplitter;
        }

        public static T ShowsPreview<T>(this T grdSplitter, bool showsPreview) where T : GridSplitter
        {
            grdSplitter.SetValue (GridSplitter.ShowsPreviewProperty, showsPreview);
            return grdSplitter;
        }
    }
}
