# UIExt.Markup.WPF
Draft WPF extensions library to define UI from code instead of XAML usage.
Inspired by VincentH-Net/CSharpForMarkup for Xamarin Forms.

## Example
```csharp
public void Build() =>
            this.Content(
                Grid()
                    .RowDefs(RowDef.Height(72), RowDef.Height(385), RowDef.Height(80))
                    .Childs(
                        TextBlock()
                            .Foreground(SolidBrush("#ff000000"))
                            .Font(family: "SegoeUI", size: 20, style: FontStyles.Normal, weight: FontWeights.SemiBold)
                            .Text("SAMPLE DIALOG FOR UIExt.Markup.WPF")
                            .HAlignCenter()
                            .LineHeight(24)
                            .Row(0)
                            .Margin(24),
                        TextBox()
                            .FocusStyleNone()
                            .Margin(24, 0, 24, 0)
                            .Border(1)
                            .BorderBrush(Black)
                            .Wrap()
                            .Row(1)
                            .Font("SegoeUI")
                            .FontSize(14)
                            .ReadOnly()
                            .Text("SOme text")
                            .VScrollAuto()
                            .HScrollAuto(),
                        Grid()
                            .Row(2)
                            .ColDefs(ColDef, ColDef)
                            .Childs(
                                Button()
                                    .Content("ACTION")
                                    .Name("ActionButton")
                                    .Style(AccentDialogButtonStyle)
                                    .Height(32)
                                    .Width(145)
                                    .HAlignRight()
                                    .Column(0)
                                    .Margin(24, 24, 3, 24)
                                    .Command(ViewModel.ActionCommand),
                                Button()
                                    .Content("EXIT")
                                    .Name("ExitButton")
                                    .Style(DialogButtonStyle)
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
	new Style()
            new Style()
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
