using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Interactivity;
using Avalonia.Media;
using Avalonia.VisualTree;
using ColoredRectangle.Views;
using Xunit;

namespace TestColoredRectangle
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonKhaki");
            var rectangle = mainWindow.GetVisualDescendants().OfType<Rectangle>().First();
            Color c = Colors.Khaki;

            mainWindow.Click_Button(button, null);

            await Task.Delay(50);

            var rectColor = (rectangle.Fill as SolidColorBrush).Color;
            Assert.True(rectColor.Equals(c));
        }

        [Fact]
        public async void Test2()
        {
            var app = AvaloniaApp.GetApp();
            var mainWindow = AvaloniaApp.GetMainWindow();

            await Task.Delay(100);

            var button = mainWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonRed");
            var rectangle = mainWindow.GetVisualDescendants().OfType<Rectangle>().First();
            Color c = Colors.Red;

            mainWindow.Click_Button(button, null);

            await Task.Delay(50);

            var rectColor = (rectangle.Fill as SolidColorBrush).Color;
            Assert.True(rectColor.Equals(c));
        }
    }
}