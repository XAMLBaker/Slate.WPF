using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace FlexMVVM.WPF.Markup
{
    public static class ButtonComponentExtention
    {
        public static T Background<T>(this T component, string backHexString, string hoverBackHexString) where T : ButtonComponent
        {
            component.Background = BrushTool.Get (backHexString);
            component.OnHoverBackgroundColor(hoverBackHexString);

            return component;
        }
        public static T Background<T>(this T component, string backHexString, Color hoverBackColor) where T : ButtonComponent
        {
            component.Background = BrushTool.Get (backHexString);
            component.OnHoverBackgroundColor(hoverBackColor);

            return component;
        }
        public static T Background<T>(this T component, Color backColor, string hoverBackHexString) where T : ButtonComponent
        {
            component.Background = BrushTool.Get (backColor);
            component.OnHoverBackgroundColor(hoverBackHexString);

            return component;
        }
        public static T Background<T>(this T component, Color backColor, Color hoverBackColor) where T : ButtonComponent
        {
            component.Background = BrushTool.Get (backColor);
            component.OnHoverBackgroundColor(hoverBackColor);

            return component;
        }

        public static T Foreground<T>(this T component, string forgroundHexString, string hoverForegroundHexString) where T : ButtonComponent
        {
            component.Foreground = BrushTool.Get (forgroundHexString);
            component.OnHoverForeground(hoverForegroundHexString);

            return component;
        }

        public static T Foreground<T>(this T component, string forgroundHexString, Color hoverForegroundColor) where T : ButtonComponent
        {
            component.Foreground = BrushTool.Get (forgroundHexString);
            component.OnHoverForeground(hoverForegroundColor);

            return component;
        }
        public static T Foreground<T>(this T component, Color forgroundColor, string hoverForegroundHexString) where T : ButtonComponent
        {
            component.Foreground = BrushTool.Get (forgroundColor);
            component.OnHoverForeground(hoverForegroundHexString);

            return component;
        }
        public static T Foreground<T>(this T component, Color forgroundColor, Color hoverForegroundColor) where T : ButtonComponent
        {
            component.Foreground = BrushTool.Get (forgroundColor);
            component.OnHoverForeground(hoverForegroundColor);

            return component;
        }
    }
    public abstract class ButtonComponent : BaseComponent
    {
        public ButtonComponent()
        {
            this.OnHover (() =>
            {
                if (_hoverBackgroundBrush != null)
                    Background = _hoverBackgroundBrush;
                if (_hoverForegroundBrush != null)
                    Foreground = _hoverForegroundBrush;
            })
            .OnRelease (() =>
            {
                Background = _oldhoverBackgroundBrush;
                Foreground = _oldhoverForegroundBrush;
            });
        }
  
        public override void Render()
        {
            this._oldhoverBackgroundBrush = this.Background;
            this._oldhoverForegroundBrush = this.Foreground;
            this.Content = this.Build ();

            this.OnRender (this);
        }
        protected abstract Visual Build();
        protected virtual void OnRender(object sender)
        {

        }

        private Brush _oldhoverBackgroundBrush;
        private Brush _oldhoverForegroundBrush;
        private Brush _hoverBackgroundBrush;
        private Brush _hoverForegroundBrush;
        public ButtonComponent OnHoverBackgroundColor(string hexString)
        {
            _hoverBackgroundBrush = BrushTool.Get (hexString);
            return this;
        }
        public ButtonComponent OnHoverBackgroundColor(Color color)
        {
            _hoverBackgroundBrush = BrushTool.Get (color);
            return this;
        }
        public ButtonComponent OnHoverForeground(string hexString)
        {
            _hoverForegroundBrush = BrushTool.Get (hexString);
            return this;
        }
        public ButtonComponent OnHoverForeground(Color color)
        {
            _hoverForegroundBrush = BrushTool.Get (color);
            return this;
        }
    }
}
