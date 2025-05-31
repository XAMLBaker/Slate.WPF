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
        protected override void Arrange(Size finalSize)
        {
            if (InternalChildren.Count == 0)
                return;

            if (InternalChildren.Count == 1)
                return;
            double offset = 0.0;

            for (int i = 0; i < InternalChildren.Count; i++)
            {
                FrameworkElement child = (FrameworkElement)this.Children[i];

                Rect childRect = new Rect (0, offset, child.DesiredSize.Width, finalSize.Height);

                child.Arrange (childRect);

                offset += child.DesiredSize.Height + Spacing;
            }
        }
    }
}
