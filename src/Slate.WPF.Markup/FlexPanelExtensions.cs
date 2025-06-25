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
        public static T Justify<T>(this T fp, JustifyContent justify) where T : FlexPanel
        {
            fp.SetValue(FlexPanel.JustifyContentProperty, justify);
            return fp;
        }

        public static T AlignContent<T>(this T fp, AlignContent alignContent) where T : FlexPanel
        {
            fp.SetValue (FlexPanel.AlignContentProperty, alignContent);
            return fp;
        }

        public static T Orientation<T>(this T fp, Orientation orientation) where T : FlexPanel
        {
            fp.SetValue (FlexPanel.OrientationProperty, orientation);
            return fp;
        }

        public static T AlignItems<T>(this T fp, AlignItems alignItems) where T : FlexPanel
        {
            fp.SetValue (FlexPanel.AlignItemsProperty, alignItems);
            return fp;
        }
    }
}
