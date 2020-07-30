using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using UIExt.Markup.WPF;
using static System.Windows.Media.Brushes;
using static UIExt.Markup.WPF.UIExt;

namespace WPF.Sample
{
    public class SampleDialog : Window
    {
        private static readonly Brush _black40percent = SolidBrush("#999999");

        private static Element<ContentPresenter> _dialogButtonContentPresenter =
            ContentPresenter()
                .SetPropValue(HorizontalAlignmentProperty, HorizontalAlignment.Center)
                .SetPropValue(VerticalAlignmentProperty, VerticalAlignment.Center);

        private static Trigger _mouseOverTrigger = IsMouseOverTrigger(BorderBrush(_black40percent));

        private static Trigger _pressedTrigger =
            IsPressedTrigger(BorderBrush(_black40percent), Background(_black40percent));

        private static ControlTemplate DialogButtonTemplate = new ControlTemplate
        {
            TargetType = typeof(Button),
            VisualTree =
                BorderElement()
                    .Background(new TemplateBindingExtension(BackgroundProperty))
                    .BorderThickness(new TemplateBindingExtension(BorderThicknessProperty))
                    .BorderBrush(new TemplateBindingExtension(BorderBrushProperty))
                    .Childs(
                        BorderElement().Childs(_dialogButtonContentPresenter))
                    .Factory
        };

        private static Style DialogButtonStyle = new Style()
        {
            Setters =
            {
                SnapsToPixels(true),
                FontSize(14),
                FontFamily("SegoeUI"),
                FontWeight(FontWeights.Normal),
                FontStyle(FontStyles.Normal),
                Setter(ForegroundProperty,          SolidBrush("#FF000000")),
                BorderThickness(2),
                BorderBrush(SolidBrush("#cccccc")),
                Setter(BackgroundProperty,          SolidBrush("#cccccc")),
                Setter(TemplateProperty,            DialogButtonTemplate),
            },
        }
        .Triggers(_mouseOverTrigger, _pressedTrigger);

        private Style AccentDialogButtonStyle = new Style()
        {
            Setters =
        {
            SnapsToPixels(true),
            FontSize(14),
            FontFamily("SegoeUI"),
            FontWeight(FontWeights.Normal),
            FontStyle(FontStyles.Normal),
            Setter(ForegroundProperty,          White),
            Setter(BorderThicknessProperty,     Thickness(2)),
            Setter(BorderBrushProperty,         SolidBrush("#1565c0")),
            Setter(BackgroundProperty,          SolidBrush("#1565c0")),
            Setter(TemplateProperty,            DialogButtonTemplate),
        }
        }
        .Triggers(_mouseOverTrigger, _pressedTrigger);

        public SampleDialog()
        {
            Build();
        }

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
    }
}
