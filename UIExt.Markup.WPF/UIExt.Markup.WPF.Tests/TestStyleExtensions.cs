using System;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestStyleExtensions
    {
        [TestMethod]
        public void TestSetterProperty()
        {
            var setter = Setter().Prop(UIElement.VisibilityProperty);

            setter.Property.Should().Be(UIElement.VisibilityProperty);
        }

        [TestMethod]
        public void TestSetterValue()
        {
            var setter = Setter().Value(42);

            setter.Value.Should().Be(42);
        }

        [TestMethod]
        public void TestTargetName()
        {
            var setter = Setter().Target("SomeControl");

            setter.TargetName.Should().Be("SomeControl");
        }

        private bool TryGetGetPropertyValue(object propertyValue, DependencyProperty dependencyProperty, out object result)
        {
            result = null;
            var propertyField = propertyValue.GetType().GetField("Property", BindingFlags.NonPublic | BindingFlags.Instance);
            var property = propertyField.GetValue(propertyValue) as DependencyProperty;
            if (property == dependencyProperty)
            {
                var valueProperty = propertyValue.GetType().GetProperty("Value", BindingFlags.NonPublic | BindingFlags.Instance);
                result = valueProperty.GetValue(propertyValue);
                return true;
            }

            return false;
        }

        private object GetFactoryPropValue(FrameworkElementFactory factory, DependencyProperty property)
        {
            var propValuesField = typeof(FrameworkElementFactory).GetField("PropertyValues", BindingFlags.NonPublic | BindingFlags.Instance);
            var propValuesList = propValuesField.GetValue(factory);
            var propValuesArray = (Array)propValuesList.GetType().GetMethod("ToArray").Invoke(propValuesList, new object[] { });
            for(var i = 0; i < propValuesArray.Length; i++)
            {
                if (TryGetGetPropertyValue(propValuesArray.GetValue(i), property, out var value))
                {
                    return value;
                }
            }

            return null;
        }

        [TestMethod]
        public void TestSetPropValue()
        {
            var element = BorderElement();

            element.SetPropValue(System.Windows.Controls.Border.BorderThicknessProperty, new Thickness(1));

            GetFactoryPropValue(element.Factory, System.Windows.Controls.Border.BorderThicknessProperty).Should().BeEquivalentTo(new Thickness(1));
        }

        [TestMethod]
        public void TestChilds()
        {
            var child = ContentPresenter();
            var element = BorderElement().Childs(child);

            element.Factory.FirstChild.Should().Be(child.Factory);
        }

        [TestMethod]
        public void TestTriggers()
        {
            var style = Style().Triggers(new Trigger(), new Trigger());

            style.Triggers.Count.Should().Be(2);
        }

        [TestMethod]
        public void TestSetters()
        {
            var style = Style().Setters(new Setter(), new Setter());

            style.Setters.Count.Should().Be(2);
        }

        [TestMethod]
        public void TestBorderBackground()
        {
            var element = BorderElement();

            element.Background(Brushes.Red);

            GetFactoryPropValue(element.Factory, Control.BackgroundProperty).Should().Be(Brushes.Red);

            var binding = new TemplateBindingExtension(Control.BackgroundProperty);
            element.Background(binding);

            GetFactoryPropValue(element.Factory, Control.BackgroundProperty).Should().Be(binding);
        }

        [TestMethod]
        public void TestControlBackground()
        {
            var element = CheckBoxElement();

            element.Background(Brushes.Red);

            GetFactoryPropValue(element.Factory, Control.BackgroundProperty).Should().Be(Brushes.Red);

            var binding = new TemplateBindingExtension(Control.BackgroundProperty);
            element.Background(binding);

            GetFactoryPropValue(element.Factory, Control.BackgroundProperty).Should().Be(binding);
        }

        [TestMethod]
        public void TestBorderBrush()
        {
            var element = BorderElement();

            element.BorderBrush(Brushes.Red);

            GetFactoryPropValue(element.Factory, Control.BorderBrushProperty).Should().Be(Brushes.Red);

            var binding = new TemplateBindingExtension(Control.BorderBrushProperty);
            element.BorderBrush(binding);

            GetFactoryPropValue(element.Factory, Control.BorderBrushProperty).Should().Be(binding);
        }

        [TestMethod]
        public void TestBorderThickness()
        {
            var element = BorderElement();

            element.BorderThickness(1);

            GetFactoryPropValue(element.Factory, Control.BorderThicknessProperty).Should().BeEquivalentTo(new Thickness(1));

            var binding = new TemplateBindingExtension(Control.BorderThicknessProperty);
            element.BorderThickness(binding);

            GetFactoryPropValue(element.Factory, Control.BorderThicknessProperty).Should().Be(binding);
        }
    }
}
