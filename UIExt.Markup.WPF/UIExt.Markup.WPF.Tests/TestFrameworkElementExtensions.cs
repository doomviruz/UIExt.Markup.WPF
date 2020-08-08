using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestFrameworkElementExtensions
    {
        [TestMethod]
        public void TestName()
        {
            var element = Button();

            element.Name("Button1").Name.Should().Be("Button1");
        }

        [TestMethod]
        public void TestTag()
        {
            var element = Button();

            element.Tag(42).Tag.Should().Be(42);
        }

        [TestMethod]
        public void TestDataContext()
        {
            var element = Button();
            var context = new { SomeProperty = "abc" };

            element.DataContext(context).DataContext.Should().Be(context);
        }

        [TestMethod]
        public void TestStyle()
        {
            var element = Button();
            var style = Style<Button>();

            element.Style(style).Style.Should().Be(style);
        }

        [TestMethod]
        public void TestFocusStyle()
        {
            var element = Button();
            var style = Style();

            element.FocusStyle(style).FocusVisualStyle.Should().Be(style);
        }

        [TestMethod]
        public void TestFocusStyleNone()
        {
            var element = Button();

            element.FocusStyleNone().FocusVisualStyle.Should().BeNull();
        }

        [TestMethod]
        public void TestContextMenu()
        {
            var element = Button();
            var menu = ContextMenu();

            element.ContextMenu(menu).ContextMenu.Should().Be(menu);
        }

        [TestMethod]
        public void TestToolTip()
        {
            var element = Button();

            element.ToolTip("tooltip").ToolTip.Should().Be("tooltip");
        }

        [TestMethod]
        public void TestHAlign()
        {
            var element = Button();

            element.HAlign(HorizontalAlignment.Right).HorizontalAlignment.Should().Be(HorizontalAlignment.Right);
            element.HAlignLeft().HorizontalAlignment.Should().Be(HorizontalAlignment.Left);
            element.HAlignCenter().HorizontalAlignment.Should().Be(HorizontalAlignment.Center);
            element.HAlignRight().HorizontalAlignment.Should().Be(HorizontalAlignment.Right);
            element.HAlignStretch().HorizontalAlignment.Should().Be(HorizontalAlignment.Stretch);
        }

        [TestMethod]
        public void TestVAlign()
        {
            var element = Button();

            element.VAlign(VerticalAlignment.Bottom).VerticalAlignment.Should().Be(VerticalAlignment.Bottom);
            element.VAlignTop().VerticalAlignment.Should().Be(VerticalAlignment.Top);
            element.VAlignCenter().VerticalAlignment.Should().Be(VerticalAlignment.Center);
            element.VAlignBottom().VerticalAlignment.Should().Be(VerticalAlignment.Bottom);
            element.VAlignStretch().VerticalAlignment.Should().Be(VerticalAlignment.Stretch);
        }

        [TestMethod]
        public void TestHeight()
        {
            var element = Button();

            element.Height(100).Height.Should().Be(100);
            element.HeightAuto().Height.Should().Be(double.NaN);
        }

        [TestMethod]
        public void TestMinHeight()
        {
            var element = Button();

            element.MinHeight(80).MinHeight.Should().Be(80);
        }

        [TestMethod]
        public void TestMaxHeight()
        {
            var element = Button();

            element.MaxHeight(150).MaxHeight.Should().Be(150);
        }

        [TestMethod]
        public void TestWidth()
        {
            var element = Button();

            element.Width(100).Width.Should().Be(100);
            element.WidthAuto().Width.Should().Be(double.NaN);
        }

        [TestMethod]
        public void TestMinWidth()
        {
            var element = Button();

            element.MinWidth(80).MinWidth.Should().Be(80);
        }

        [TestMethod]
        public void TestMaxWidth()
        {
            var element = Button();

            element.MaxWidth(150).MaxWidth.Should().Be(150);
        }

        [TestMethod]
        public void TestMargin()
        {
            var element = Button();
            var margin = new Thickness(1);

            element.Margin(margin).Margin.Should().Be(margin);
            element.Margin(5).Margin.Should().BeEquivalentTo(new Thickness(5));
            element.Margin(5, 0, 5, 0).Margin.Should().BeEquivalentTo(new Thickness(5, 0, 5, 0));
        }

        [TestMethod]
        public void TestOverridesDefaultStyle()
        {
            var element = Button();

            element.OverridesDefaultStyle(true).OverridesDefaultStyle.Should().BeTrue();
        }

        [TestMethod]
        public void TestUseLayoutRounding()
        {
            var element = Button();

            element.UseLayoutRounding(true).UseLayoutRounding.Should().BeTrue();
        }

        [TestMethod]
        public void TestResources()
        {
            var element = Button();
            var dictionary = new ResourceDictionary();

            element.Resources(dictionary).Resources.Should().BeSameAs(dictionary);
        }

        [TestMethod]
        public void TestBindingGroup()
        {
            var element = Button();
            var group = new BindingGroup();

            element.BindingGroup(group).BindingGroup.Should().Be(group);
        }

        [TestMethod]
        public void TestLanguage()
        {
            var element = Button();

            element.Language(XmlLanguage.Empty).Language.Should().Be(XmlLanguage.Empty);
        }

        [TestMethod]
        public void TestInputScope()
        {
            var element = Button();
            var scope = new InputScope();

            element.InputScope(scope).InputScope.Should().Be(scope);
        }

        [TestMethod]
        public void TestLayoutTransform()
        {
            var element = Button();
            var transform = new RotateTransform();

            element.LayoutTransform(transform).LayoutTransform.Should().Be(transform);
        }

        [TestMethod]
        public void TestFlowDirection()
        {
            var element = Button();

            element.FlowDirection(FlowDirection.RightToLeft).FlowDirection.Should().Be(FlowDirection.RightToLeft);
        }

        [TestMethod]
        public void TestCursor()
        {
            var element = Button();

            element.Cursor(Cursors.Wait).Cursor.Should().Be(Cursors.Wait);
        }

        [TestMethod]
        public void TestForceCursor()
        {
            var element = Button();

            element.ForceCursor(true).ForceCursor.Should().BeTrue();
        }

        [TestMethod]
        public void TestBind()
        {
            var binding = Binding("SomeProperty");
            var element = Button().Bind(Control.BackgroundProperty, binding);

            BindingOperations.GetBinding(element, Control.BackgroundProperty).Should().Be(binding);
        }
    }
}
