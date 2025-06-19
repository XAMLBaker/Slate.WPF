namespace Slate.WPF.Markup
{
    public static class FlexPanelExtensions
    {
        /// <summary>
        /// height가 설정되었거나 되지 않아도 height값을 추가적으로 더할 수 있습니다.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fp"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T AddHeight<T>(this T fp, double value) where T : FlexPanel
        {
            fp.AddHeight = value;
            return fp;
        }
        public static T Justify<T>(this T fp, JustifyContent justify) where T : FlexPanel
        {
            fp.Justify = justify;
            return fp;
        }

        public static T Align<T>(this T fp, AlignContent align) where T : FlexPanel
        {
            fp.Align = align;
            return fp;
        }

        public static T Orientation<T>(this T fp, Orientation orientation) where T : FlexPanel
        {
            fp.Orientation = orientation;
            return fp;
        }
    }
}
