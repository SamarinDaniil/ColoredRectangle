using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Interactivity;
using Avalonia.Media;
using Avalonia.VisualTree;
using ColoredRectangle.Views;

namespace TestColoredRectangle
{
    public class UnitTest1
    {
        [Fact]
        public async void Test1()
        {
            var app = AvaloniaApp.GetApp();
            var mainnWindow = AvaloniaApp.GetMainWindow();
            
            await Task.Delay(100);

            var button = mainnWindow.GetVisualDescendants().OfType<Button>().First(b => b.Name == "buttonKhaki");
            var rectangle = mainnWindow.GetVisualDescendants().OfType<Rectangle>().First();
            Color c = Colors.Khaki;


            
            await Task.Delay(50);

            var rectColor = (rectangle.Fill as SolidColorBrush).Color;
            Assert.True(rectColor.Equals(c));
        }
    }
}