using System.Windows;
using System.Windows.Media;

namespace FlexMVVM.WPF.Markup
{
    public class FlexCheckBoxModel
    {
        public double SizeValue { get; set; }
        public Thickness ThicknessValue { get; set; }
        public Thickness PaddingValue { get; set; }
        public CornerRadius CornerRadiusValue { get; set; }
        public Brush BackColorValue { get; set; }
        public Brush CheckColorValue { get; set; }
        public Brush BorderBrushValue { get; set; }
        public Brush HoverBorderBrushValue { get; set; }
        public FlexCheckBoxModel Thickness(double value)
        {
            this.ThicknessValue = new Thickness (value, value, value, value);
            return this;
        }
        public FlexCheckBoxModel Thickness(double leftright = 0, double topbottom = 0)
        {
            this.ThicknessValue = new Thickness (leftright, topbottom, leftright, topbottom);
            return this;
        }
        public FlexCheckBoxModel Thickness(double left = 0, double top = 0, double right = 0, double bottom = 0)
        {
            this.ThicknessValue = new Thickness (left, top, right, bottom);

            return this;
        }

        public FlexCheckBoxModel Size(double value)
        {
            this.SizeValue = value;
            return this;
        }
        public FlexCheckBoxModel BackColor(string color)
        {
            this.BackColorValue = BrushTool.Get (color);
            return this;
        }
        public FlexCheckBoxModel BackColor(Color color)
        {
            this.BackColorValue = new SolidColorBrush (color);
            return this;
        }
        public FlexCheckBoxModel CheckColor(string color)
        {
            this.CheckColorValue = BrushTool.Get (color);
            return this;
        }
        public FlexCheckBoxModel CheckColor(Color color)
        {
            this.CheckColorValue = new SolidColorBrush (color);
            return this;
        }
        public FlexCheckBoxModel Padding(double marginAll = 0)
        {
            PaddingValue = new Thickness (marginAll, marginAll, marginAll, marginAll);
            return this;
        }
        public FlexCheckBoxModel Padding(double leftright = 0, double topbottom = 0)
        {
            PaddingValue = new Thickness (leftright, topbottom, leftright, topbottom);
            return this;
        }
        public FlexCheckBoxModel Padding(double left = 0, double top = 0, double right = 0, double bottom = 0)
        {
            PaddingValue = new Thickness (left, top, right, bottom);
            return this;
        }
        public FlexCheckBoxModel CornerRadius(double marginAll = 0)
        {
            this.CornerRadiusValue = new CornerRadius (marginAll, marginAll, marginAll, marginAll);
            return this;
        }
        public FlexCheckBoxModel CornerRadius(double leftright = 0, double topbottom = 0)
        {
            this.CornerRadiusValue = new CornerRadius (leftright, topbottom, leftright, topbottom);
            return this;
        }
        public FlexCheckBoxModel CornerRadius(double left = 0, double top = 0, double right = 0, double bottom = 0)
        {
            this.CornerRadiusValue = new CornerRadius (left, top, right, bottom);
            return this;
        }
        public FlexCheckBoxModel BorderBrush(string color)
        {
            this.BorderBrushValue = BrushTool.Get (color);
            return this;
        }
        public FlexCheckBoxModel BorderBrush(Color color)
        {
            this.BorderBrushValue = new SolidColorBrush (color);
            return this;
        }
        public FlexCheckBoxModel HoverBorderBrush(Color color)
        {
            this.HoverBorderBrushValue = new SolidColorBrush (color);
            return this;
        }
        public FlexCheckBoxModel HoverBorderBrush(string color)
        {
            this.HoverBorderBrushValue = BrushTool.Get (color);
            return this;
        }

        public FlexCheckBoxModel BorderBrush(string color, string hoverColor)
        {
            this.BorderBrush (color);
            this.HoverBorderBrush(hoverColor);
            return this;
        }
        public FlexCheckBoxModel BorderBrush(Color color, string hoverColor)
        {
            this.BorderBrush (color);
            this.HoverBorderBrush (hoverColor);
            return this;
        }
        public FlexCheckBoxModel BorderBrush(string color, Color hoverColor)
        {
            this.BorderBrush (color);
            this.HoverBorderBrush (hoverColor);
            return this;
        }
        public FlexCheckBoxModel BorderBrush(Color color, Color hoverColor)
        {
            this.BorderBrush (color);
            this.HoverBorderBrush (hoverColor);
            return this;
        }
    }
}
