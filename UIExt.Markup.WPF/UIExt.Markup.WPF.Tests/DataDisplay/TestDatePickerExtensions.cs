using System;
using System.Windows;
using System.Windows.Controls;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestDatePickerExtensions
    {
        [TestMethod]
        public void TestDisplayDateStart()
        {
            var datePicker = DatePicker();
            var now = DateTime.Now;

            datePicker.DisplayDateStart(now).DisplayDateStart.Should().Be(now);
        }

        [TestMethod]
        public void TestSelectedDateFormat()
        {
            var datePicker = DatePicker();

            datePicker.SelectedDateFormat(DatePickerFormat.Long).SelectedDateFormat.Should().Be(DatePickerFormat.Long);
        }

        [TestMethod]
        public void TestCalendarStyle()
        {
            var datePicker = DatePicker();
            var style = Style();

            datePicker.CalendarStyle(style).CalendarStyle.Should().Be(style);
        }

        [TestMethod]
        public void TestText()
        {
            var datePicker = DatePicker();

            datePicker.Text("Some text").Text.Should().Be("Some text");
        }

        [TestMethod]
        public void TestDisplayDateEnd()
        {
            var datePicker = DatePicker();
            var now = DateTime.Now;

            datePicker.DisplayDateEnd(now).DisplayDateEnd.Should().Be(now);
        }

        [TestMethod]
        public void TestIsTodayHighlighted()
        {
            var datePicker = DatePicker();

            datePicker.IsTodayHighlighted(false).IsTodayHighlighted.Should().Be(false);
        }

        [TestMethod]
        public void TestSelectedDate()
        {
            var datePicker = DatePicker();
            var date = DateTime.Now.AddDays(-10).Date;

            datePicker.SelectedDate(date).SelectedDate.Should().Be(date);
        }

        [TestMethod]
        public void TestIsDropDownOpen()
        {
            var datePicker = DatePicker();

            datePicker.IsDropDownOpen(true).IsDropDownOpen.Should().Be(true);
        }

        [TestMethod]
        public void TestDisplayDate()
        {
            var datePicker = DatePicker();
            var now = DateTime.Now.AddDays(10);

            datePicker.DisplayDate(now).DisplayDate.Should().Be(now);
        }

        [TestMethod]
        public void TestFirstDayOfWeek()
        {
            var datePicker = DatePicker();

            datePicker.FirstDayOfWeek(DayOfWeek.Friday).FirstDayOfWeek.Should().Be(DayOfWeek.Friday);
        }

    }
}
