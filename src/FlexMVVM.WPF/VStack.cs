using System.Windows;
using System.Windows.Controls;

namespace FlexMVVM.WPF
{
    public class VStack : FlexStack
    {
        public VStack()
        {
            this.Orientation = Orientation.Vertical;
            
        }
        protected override Size ArrangeOverride(Size finalSize)
        {
            double offset = 0;
            foreach (UIElement child in InternalChildren)
            {
                if (child == null)
                    continue;

                Size childSize = child.DesiredSize;

                child.Arrange (new Rect (0, offset, finalSize.Width, childSize.Height));
                offset += childSize.Height + Spacing;
            }

            if (InternalChildren.Count > 0)
                offset -= Spacing;

            return Orientation == Orientation.Vertical
                ? new Size (finalSize.Width, offset)
                : new Size (offset, finalSize.Height);
        }
    }
}
