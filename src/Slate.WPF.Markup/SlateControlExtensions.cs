namespace Slate.WPF.Markup
{
    public static class SlateControlExtensions
    {
        public static T WaterMarkText<T>(this T ftb, string text) where T : SlateTextBox
        {
            ftb.WaterMarkText = text;
            return ftb;
        }

        public static T WaterMarkTextColor<T>(this T ftb, string colorString) where T : SlateTextBox
        {
            ftb.WaterMarkTextColor = BrushTool.Get (colorString);

            return ftb;
        }

        public static T WaterMarkTextColor<T>(this T ftb, Color color) where T : SlateTextBox
        {
            ftb.WaterMarkTextColor = new SolidColorBrush (color);

            return ftb;
        }

        public static T CornerRadius<T>(this T fc, double marginAll = 0) where T : ISlateControl
        {
            fc.CornerRadius = new CornerRadius (marginAll, marginAll, marginAll, marginAll);
            return fc;
        }
        public static T CornerRadius<T>(this T fc, double leftright = 0, double topbottom = 0) where T : ISlateControl
        {
            fc.CornerRadius = new CornerRadius (leftright, topbottom, leftright, topbottom);
            return fc;
        }

        public static T CornerRadius<T>(this T fc, double left = 0, double top = 0, double right = 0, double bottom = 0) where T : ISlateControl
        {
            fc.CornerRadius = new CornerRadius (left, top, right, bottom);

            return fc;
        }

        public static T Orientation<T>(this T fd, Orientation orientation) where T : SlateDivider
        {
            fd.Orientation = orientation;
            return fd;
        }

        public static T StartIndent<T>(this T fd, double value) where T : SlateDivider
        {
            fd.StartIndent = value;
            return fd;
        }

        public static T EndIndent<T>(this T fd, double value) where T : SlateDivider
        {
            fd.EndIndent = value;
            return fd;
        }

        public static T Thickness<T>(this T fd, double value) where T : SlateDivider
        {
            fd.Thickness = value;
            return fd;
        }
    }
}
