using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using UIExt.Markup.WPF;
using UIExt.Markup.WPF.Sample;
using static System.Windows.Media.Brushes;
using static UIExt.Markup.WPF.UIExt;
using static UIExt.Markup.WPF.Setters;
using System.Windows.Data;

namespace WPF.Sample
{
    public class SampleDialog : Window
    {
        private static readonly Brush _black40percent = SolidBrush("#999999");

        private static readonly Brush _buttonBorderBrush = SolidBrush("#cccccc");

        private static readonly Brush _buttonForegroundBrush = SolidBrush("#FF000000");

        private static Trigger _mouseOverTrigger = TriggerDefs.IsMouseOver(BorderBrush(_black40percent));

        private static Trigger _pressedTrigger =
            TriggerDefs.IsPressed(BorderBrush(_black40percent), Background(_black40percent));

        private static ControlTemplate _dialogButtonTemplate = new ControlTemplate
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

        private static Style _dialogButtonStyle = 
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
                    Template(_dialogButtonTemplate))
                .Triggers(_mouseOverTrigger, _pressedTrigger);

        private static Style _accentDialogButtonStyle = new Style()
        {
            Setters =
        {
            SnapsToPixels(true),
            FontSize(14),
            FontFamily("SegoeUI"),
            FontWeight(FontWeights.Normal),
            FontStyle(FontStyles.Normal),
            Setter(ForegroundProperty,          White),
            Setter(BorderThicknessProperty,     new Thickness(2)),
            Setter(BorderBrushProperty,         SolidBrush("#1565c0")),
            Setter(BackgroundProperty,          SolidBrush("#1565c0")),
            Setter(TemplateProperty,            _dialogButtonTemplate),
        }
        }
        .Triggers(_mouseOverTrigger, _pressedTrigger);

        public SampleDialog(SampleDialogViewModel viewModel)
        {
            DataContext = ViewModel = viewModel;
            Build();
        }

        public SampleDialogViewModel ViewModel { get; }

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
    }
}
