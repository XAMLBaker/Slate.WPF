namespace Slate.WPF.Markup
{
    public static class SlateCheckBoxExtensions
    {
        public static T CheckBoxColor<T>(this T fcb, Color color) where T : SlateCheckBox
        {
            return fcb.CheckBoxColor (BrushTool.Get (color));
        }
        public static T CheckBoxColor<T>(this T fcb, string color) where T : SlateCheckBox
        {
            return fcb.CheckBoxColor(BrushTool.Get (color));
        }
        public static T CheckBoxColor<T>(this T fcb, Brush color) where T : SlateCheckBox
        {
            if (color == null)
                return fcb;
            fcb.Color = color;
            return fcb;
        }
        public static T CheckColor<T>(this T fcb, Color color) where T : SlateCheckBox
        {
            return fcb.CheckColor (BrushTool.Get (color));
        }
        public static T CheckColor<T>(this T fcb, string color) where T : SlateCheckBox
        {
            return fcb.CheckColor (BrushTool.Get (color));
        }
        public static T CheckColor<T>(this T fcb, Brush color) where T : SlateCheckBox
        {
            if (color == null)
                return fcb;
            fcb.ForeColor = color;
            return fcb;
        }

        public static T CheckBoxSize<T>(this T fcb, double value) where T : SlateCheckBox
        {
            fcb.CheckBoxSize = value;
            return fcb;
        }

        public static T CornerRadius<T>(this T fcb, double marginAll = 0) where T : SlateCheckBox
        {
            return fcb.CornerRadius (new CornerRadius (marginAll, marginAll, marginAll, marginAll));
        }

        public static T CornerRadius<T>(this T fcb, double leftright = 0, double topbottom = 0) where T : SlateCheckBox
        {
            return fcb.CornerRadius (new CornerRadius (leftright, topbottom, leftright, topbottom));
        }

        public static T CornerRadius<T>(this T fcb, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : SlateCheckBox
        {
            return fcb.CornerRadius(new CornerRadius (left, top, right, bottom));
        }

        public static T CornerRadius<T>(this T fcb, CornerRadius radius) where T : SlateCheckBox
        {
            fcb.SetValue(SlateCheckBox.CornerRadiusProperty, radius);
            return fcb;
        }
        public static T HoverBrush<T>(this T fcb, string color) where T : SlateCheckBox
        {
            fcb.HoverBrush = BrushTool.Get (color);

            return fcb;
        }

        public static T HoverBrush<T>(this T fcb, Color color) where T : SlateCheckBox
        {
            fcb.HoverBrush = new SolidColorBrush (color);

            return fcb;
        }
        public static T BorderBrush<T>(this T fcb, string baseColor, string hoverColor) where T : SlateCheckBox
        {
            fcb.BorderBrush (baseColor);
            fcb.HoverBrush (hoverColor);

            return fcb;
        }
        public static T BorderBrush<T>(this T fcb, string baseColor, Color hoverColor) where T : SlateCheckBox
        {
            fcb.BorderBrush (baseColor);
            fcb.HoverBrush (hoverColor);

            return fcb;
        }
        public static T BorderBrush<T>(this T fcb, Color baseColor, string hoverColor) where T : SlateCheckBox
        {
            fcb.BorderBrush (baseColor);
            fcb.HoverBrush (hoverColor);

            return fcb;
        }
        public static T BorderBrush<T>(this T fcb, Color baseColor, Color hoverColor) where T : SlateCheckBox
        {
            fcb.BorderBrush (baseColor);
            fcb.HoverBrush (hoverColor);

            return fcb;
        }
        public static T BorderBrush<T>(this T fcb, Brush baseColor, Brush hoverColor) where T : SlateCheckBox
        {
            fcb.BorderBrush = baseColor;
            fcb.HoverBrush = hoverColor;

            return fcb;
        }
        public static T BoxStyle<T>(this T fcb, Func<SlateCheckBoxModel> action) where T : SlateCheckBox
        {
            var model = action ();
            fcb.Padding (model.PaddingValue);
            fcb.CheckBoxColor (model.BackColorValue);
            fcb.CheckColor (model.CheckColorValue);
            fcb.BorderThickness (model.ThicknessValue);
            fcb.CheckBoxSize (model.SizeValue);
            fcb.CornerRadius (model.CornerRadiusValue);
            fcb.BorderBrush (model.BorderBrushValue, model.HoverBorderBrushValue);
            return fcb;
        }
    }
}
