using System.Windows;
using System.Windows.Controls;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestGridExtensions
    {
        [TestMethod]
        public void TestGridRowHeight()
        {
            var row = RowDef;

            row.Height(100).Height.Should().BeEquivalentTo(new GridLength(100));
            row.StarHeight(5).Height.Should().BeEquivalentTo(new GridLength(5, GridUnitType.Star));
            row.HeightAll().Height.Should().BeEquivalentTo(new GridLength(1, GridUnitType.Star));
            row.HeightAuto().Height.Should().BeEquivalentTo(new GridLength(0, GridUnitType.Auto));
        }

        [TestMethod]
        public void TestGridColWidth()
        {
            var col = ColDef;

            col.Width(100).Width.Should().BeEquivalentTo(new GridLength(100));
            col.StarWidth(5).Width.Should().BeEquivalentTo(new GridLength(5, GridUnitType.Star));
            col.WidthAll().Width.Should().BeEquivalentTo(new GridLength(1, GridUnitType.Star));
            col.WidthAuto().Width.Should().BeEquivalentTo(new GridLength(0, GridUnitType.Auto));
        }

        [TestMethod]
        public void TestRowDefs()
        {
            var grid = Grid();

            grid.RowDefs(RowDef, RowDef).RowDefinitions.Count.Should().Be(2);
        }

        [TestMethod]
        public void TestColDefs()
        {
            var grid = Grid();

            grid.ColDefs(ColDef, ColDef).ColumnDefinitions.Count.Should().Be(2);
        }
    }
}
