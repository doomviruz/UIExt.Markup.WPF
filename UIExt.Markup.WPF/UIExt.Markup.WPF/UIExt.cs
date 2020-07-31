using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using UIExt.Markup.WPF;

namespace UIExt.Markup.WPF
{
    public static class UIExt
    {
        public static Brush SolidBrush(string colorCode) => new SolidColorBrush((Color)ColorConverter.ConvertFromString(colorCode));

        public static Brush SolidBrush(byte a, byte r, byte g, byte b) => new SolidColorBrush(Color.FromArgb(a, r, g, b));

        public static Window Window() => new Window();

        public static Page Page() => new Page();

        public static Grid Grid() => new Grid();

        public static StackPanel StackPanel() => new StackPanel();

        public static VirtualizingStackPanel VirtStackPanel() => new VirtualizingStackPanel();

        public static WrapPanel WrapPanel() => new WrapPanel();

        public static Button Button() => new Button();

        public static ToggleButton ToggleButton() => new ToggleButton();

        public static RadioButton RadioButton() => new RadioButton();

        public static CheckBox CheckBox() => new CheckBox();

        public static ComboBox ComboBox() => new ComboBox();

        public static TextBlock TextBlock() => new TextBlock();

        public static TextBox TextBox() => new TextBox();

        public static ContextMenu ContextMenu() => new ContextMenu();

        public static RowDefinition RowDef => new RowDefinition();

        public static ColumnDefinition ColDef => new ColumnDefinition();

        public static Style Style() => new Style();

        public static Style Style<T>() where T : UIElement => new Style(typeof(T));

        public static Setter Setter() => new Setter();

        public static Setter Setter(DependencyProperty property, object value) => new Setter(property, value);

        public static Element<Border> BorderElement() => new Element<Border>();

        public static Element<CheckBox> CheckBoxElement() => new Element<CheckBox>();

        public static Element<ContentPresenter> ContentPresenter() => new Element<ContentPresenter>();

        public static Trigger Trigger(DependencyProperty property, object value, params Setter[] setters)
        {
            var trigger = new Trigger()
            {
                Property = property,
                Value = value
            };

            foreach (var setter in setters)
            {
                trigger.Setters.Add(setter);
            }

            return trigger;
        }

        public static Trigger Trigger(DependencyProperty property, object value, DependencyProperty setterProperty, object setterValue) =>
            Trigger(property, value, Setter(setterProperty, setterValue));
    }
}
