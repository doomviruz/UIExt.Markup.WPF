using System.Windows;
using System.Windows.Media;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static UIExt.Markup.WPF.UIExt;

namespace UIExt.Markup.WPF.Tests
{
    [TestClass]
    public class TestBulletDecoratorExtensions
    {
        [TestMethod]
        public void TestBackground()
        {
            var cb = BulletDecorator();

            cb.Background(Brushes.Red).Background.Should().Be(Brushes.Red);
        }

        [TestMethod]
        public void TestBullet()
        {
            var cb = BulletDecorator();
            var bullet = Button();

            cb.Bullet(bullet).Bullet.Should().Be(bullet);
        }
    }
}
