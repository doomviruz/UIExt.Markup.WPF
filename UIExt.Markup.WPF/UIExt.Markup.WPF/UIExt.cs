using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using UIExt.Markup.WPF;

namespace UIExt.Markup.WPF
{
    public static class UIExt
    {
        public static SolidColorBrush SolidBrush(string colorCode) => new SolidColorBrush((Color)ColorConverter.ConvertFromString(colorCode));

        public static SolidColorBrush SolidBrush(byte a, byte r, byte g, byte b) => new SolidColorBrush(Color.FromArgb(a, r, g, b));

        public static Window Window() => new Window();

        public static Page Page() => new Page();

        public static Frame Frame() => new Frame();

        public static Hyperlink Hyperlink() => new Hyperlink();

        public static Grid Grid() => new Grid();

        public static GridSplitter GridSplitter() => new GridSplitter();

        public static ResizeGrip ResizeGrip() => new ResizeGrip();

        public static Separator Separator() => new Separator();

        public static ScrollViewer ScrollViewer() => new ScrollViewer();

        public static ScrollBar ScrollBar() => new ScrollBar();

        public static GroupBox GroupBox() => new GroupBox();

        public static DockPanel DockPanel() => new DockPanel();

        public static StackPanel StackPanel() => new StackPanel();

        public static VirtualizingStackPanel VirtStackPanel() => new VirtualizingStackPanel();

        public static WrapPanel WrapPanel() => new WrapPanel();

        public static BulletDecorator BulletDecorator() => new BulletDecorator();

        public static Button Button() => new Button();

        public static RepeatButton RepeatButton() => new RepeatButton();

        public static Calendar Calendar() => new Calendar();

        public static DatePicker DatePicker() => new DatePicker();

        public static ToggleButton ToggleButton() => new ToggleButton();

        public static RadioButton RadioButton() => new RadioButton();

        public static CheckBox CheckBox() => new CheckBox();

        public static ComboBox ComboBox() => new ComboBox();

        public static Slider Slider() => new Slider();

        public static ListBox ListBox() => new ListBox();

        public static TextBlock TextBlock() => new TextBlock();

        public static TextBox TextBox() => new TextBox();

        public static Canvas Canvas() => new Canvas();

        public static Expander Expander() => new Expander();

        public static Thumb Thumb() => new Thumb();

        public static Viewbox Viewbox() => new Viewbox();

        public static ContextMenu ContextMenu() => new ContextMenu();

        public static Menu Menu() => new Menu();

        public static ToolBar ToolBar() => new ToolBar();

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

        public static Binding Binding(string path) => new Binding(path);

        public static Binding Binding(string path, IValueConverter converter) => new Binding(path) { Converter = converter };
    }
}
