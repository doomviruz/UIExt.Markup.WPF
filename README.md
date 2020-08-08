# UIExt.Markup.WPF
Draft WPF extensions library to define UI from code instead of XAML usage.
Inspired by VincentH-Net/CSharpForMarkup for Xamarin Forms.

## Example
```csharp
public void Build() =>
            this.Content(
                Grid()
                    .RowDefs(RowDef.Height(72), RowDef.Height(30), RowDef.Height(385), RowDef.Height(80))
                    .Childs(
                        TextBlock()
                            .Foreground(SolidBrush("#ff000000"))
                            .Font(family: "SegoeUI", size: 20, style: FontStyles.Normal, weight: FontWeights.SemiBold)
                            .Text("SAMPLE DIALOG FOR UIExt.Markup.WPF")
                            .HAlignCenter()
                            .LineHeight(24)
                            .Row(0)
                            .Margin(24),
                        Grid()
                            .ColDefs(ColDef, ColDef)
                            .Row(1)
                            .Childs(
                                ToggleButton()
                                    .Content("Toggle text visibility")
                                    .Command(ViewModel.ToggleTextVisibilityCommand)
                                    .Column(0),
                                TextBlock()
                                    .Column(1)
                                    .Foreground(Brushes.Red)
                                    .VAlignCenter()
                                    .HAlignCenter()
                                    .Text("Some additional text")
                                    .Bind(
                                        VisibilityProperty, 
                                        Binding(nameof(ViewModel.AdditionalTextVisible), Converters.BoolToVisibilityConverter))),
                        TextBox()
                            .FocusStyleNone()
                            .Margin(24, 0, 24, 0)
                            .Border(1)
                            .BorderBrush(Black)
                            .Wrap()
                            .Row(2)
                            .Font("SegoeUI")
                            .FontSize(14)
                            .ReadOnly()
                            .Text("SOme text")
                            .VScrollAuto()
                            .HScrollAuto(),
                        Grid()
                            .Row(3)
                            .ColDefs(ColDef, ColDef)
                            .Childs(
                                Button()
                                    .Content("ACTION")
                                    .Name("ActionButton")
                                    .Style(_accentDialogButtonStyle)
                                    .Height(32)
                                    .Width(145)
                                    .HAlignRight()
                                    .Column(0)
                                    .Margin(24, 24, 3, 24)
                                    .Command(ViewModel.ActionCommand),
                                Button()
                                    .Content("EXIT")
                                    .Name("ExitButton")
                                    .Style(_dialogButtonStyle)
                                    .Height(32)
                                    .Width(145)
                                    .HAlignLeft()
                                    .Column(1)
                                    .Margin(3, 24, 24, 24)
                                    .Command(ViewModel.ExitCommand))));
```

---

## Control template definition example
```csharp
	ControlTemplate DialogButtonTemplate = new ControlTemplate
        {
            TargetType = typeof(Button),
            VisualTree =
                BorderElement()
                    .Background(new TemplateBindingExtension(BackgroundProperty))
                    .BorderThickness(new TemplateBindingExtension(BorderThicknessProperty))
                    .BorderBrush(new TemplateBindingExtension(BorderBrushProperty))
                    .Childs(
                        BorderElement()
                            .Childs(
                                ContentPresenter()
                                    .SetPropValue(HorizontalAlignmentProperty, HorizontalAlignment.Center)
                                    .SetPropValue(VerticalAlignmentProperty, VerticalAlignment.Center)))
                    .Factory
        };
```
---

## Style definition example
```csharp
Style DialogButtonStyle = 
            Style()
                .Setters(
                    SnapsToPixels(true),
                    FontSize(14),
                    FontFamily("SegoeUI"),
                    FontWeight(FontWeights.Normal),
                    FontStyle(FontStyles.Normal),
                    Foreground(_buttonForegroundBrush),
                    BorderThickness(2),
                    BorderBrush(_buttonBorderBrush),
                    Background(_buttonBorderBrush),
                    Template(DialogButtonTemplate))
                .Triggers(_mouseOverTrigger, _pressedTrigger);
```
---

## Simple converter example
```csharp
    public class BoolToVisibilityConverter : ConverterBase<bool, Visibility>
    {
        public override Visibility Convert(bool value, CultureInfo culture) => value ? Visibility.Visible : Visibility.Hidden;

        public override bool ConvertBack(Visibility value, CultureInfo culture) => value == Visibility.Visible;
    }
```
---
