using System;
using System.Windows;
using System.Windows.Controls;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestCalendarExtensions
    {
        [TestMethod]
        public void TestDisplayDateStart()
        {
            var calendar = Calendar();
            var now = DateTime.Now;

            calendar.DisplayDateStart(now).DisplayDateStart.Should().Be(now);
        }

        [TestMethod]
        public void TestItemStyle()
        {
            var calendar = Calendar();
            var style = Style();

            calendar.ItemStyle(style).CalendarItemStyle.Should().Be(style);
        }

        [TestMethod]
        public void TestDayButtonStyle()
        {
            var calendar = Calendar();
            var style = Style();

            calendar.DayButtonStyle(style).CalendarDayButtonStyle.Should().Be(style);
        }

        [TestMethod]
        public void TestButtonStyle()
        {
            var calendar = Calendar();
            var style = Style();

            calendar.ButtonStyle(style).CalendarButtonStyle.Should().Be(style);
        }

        [TestMethod]
        public void TestDisplayMode()
        {
            var calendar = Calendar();

            calendar.DisplayMode(CalendarMode.Year).DisplayMode.Should().Be(CalendarMode.Year);
        }

        [TestMethod]
        public void TestDisplayDateEnd()
        {
            var calendar = Calendar();
            var now = DateTime.Now;

            calendar.DisplayDateEnd(now).DisplayDateEnd.Should().Be(now);
        }

        [TestMethod]
        public void TestIsTodayHighlighted()
        {
            var calendar = Calendar();

            calendar.IsTodayHighlighted(false).IsTodayHighlighted.Should().Be(false);
        }

        [TestMethod]
        public void TestSelectedDate()
        {
            var calendar = Calendar();
            var date = DateTime.Now.AddDays(-10);

            calendar.SelectedDate(date).SelectedDate.Should().Be(date);
        }

        [TestMethod]
        public void TestSelectionMode()
        {
            var calendar = Calendar();

            calendar.SelectionMode(CalendarSelectionMode.MultipleRange).SelectionMode.Should().Be(CalendarSelectionMode.MultipleRange);
        }

        [TestMethod]
        public void TestDisplayDate()
        {
            var calendar = Calendar();
            var now = DateTime.Now.AddDays(10);

            calendar.DisplayDate(now).DisplayDate.Should().Be(now);
        }

        [TestMethod]
        public void TestFirstDayOfWeek()
        {
            var calendar = Calendar();

            calendar.FirstDayOfWeek(DayOfWeek.Friday).FirstDayOfWeek.Should().Be(DayOfWeek.Friday);
        }

    }
}
