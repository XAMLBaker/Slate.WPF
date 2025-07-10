using System.Windows.Input;

namespace MarkupChain.WinUI3.Controls.Primitives;

public static class ButtonBaseExtensions
{
    public static T ClickMode<T>(this T buttonBase, ClickMode clickMode) where T : ButtonBase
    {
        buttonBase.SetValue(ButtonBase.ClickModeProperty, clickMode);
        return buttonBase;
    }
    
    public static T Command<T>(this T buttonBase, ICommand command) where T : ButtonBase
    {
        buttonBase.SetValue(ButtonBase.CommandProperty, command);
        return buttonBase;
    }
    
    public static T CommandParameter<T>(this T buttonBase, object commandParameter) where T : ButtonBase
    {
        buttonBase.SetValue(ButtonBase.CommandParameterProperty, commandParameter);
        return buttonBase;
    }
    
    public static T IsPointerOver<T>(this T buttonBase, bool isPointerOver) where T : ButtonBase
    {
        buttonBase.SetValue(ButtonBase.IsPointerOverProperty, isPointerOver);
        return buttonBase;
    }
    
    public static T IsPressed<T>(this T buttonBase, bool isPressed) where T : ButtonBase
    {
        buttonBase.SetValue(ButtonBase.IsPressedProperty, isPressed);
        return buttonBase;
    }
}
