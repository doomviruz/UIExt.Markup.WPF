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
                            .FontStyleNormal()
                            .FontWeightSemiBold()
                            .Text("SAMPLE DIALOG FOR UIExt.Markup.WPF")
                            .HAlignCenter()
                            .Font("SegoeUI")
                            .FontSize(20)
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
                                    .OnClick((sender, e) => MessageBox.Show("Action invoked")),
                                Button()
                                    .Content("EXIT")
                                    .Name("ExitButton")
                                    .Style(DialogButtonStyle)
                                    .Height(32)
                                    .Width(145)
                                    .HAlignLeft()
                                    .Column(1)
                                    .Margin(3, 24, 24, 24)
                                    .OnClick((sender, e) => DialogResult = false))));
```

---