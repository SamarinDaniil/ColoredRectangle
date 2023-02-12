using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Media;
using ColoredRectangle.ViewModels;
using System;

namespace ColoredRectangle.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
        public void Click_Button(object sender, RoutedEventArgs routEventArgs)
        {
        Color[] color_button = new Color[10] { Colors.Khaki, Colors.Red, Colors.MediumVioletRed, Colors.Bisque, Colors.LemonChiffon,
        Colors.PowderBlue, Colors.MintCream, Colors.Maroon, Colors.RosyBrown, Colors.LightPink};
        var button = (sender as Button)!;
            switch (button.Name) 
            {
                case "buttonKhaki":
                    RC.Fill = new SolidColorBrush(color_button[0]);
                    break;
                case "buttonRed":
                    RC.Fill = new SolidColorBrush(color_button[1]);
                    break;
                case "buttonMediumVioletRed":
                    RC.Fill = new SolidColorBrush(color_button[2]);
                    break;
                case "buttonBisque":
                    RC.Fill = new SolidColorBrush(color_button[3]);
                    break;
                case "buttonLemonChiffon":
                    RC.Fill = new SolidColorBrush(color_button[4]);
                    break;
                case "buttonPowderBlue":
                    RC.Fill = new SolidColorBrush(color_button[5]);
                    break;
                case "buttonMintCream":
                    RC.Fill = new SolidColorBrush(color_button[6]);
                    break;
                case "buttonMaroon":
                    RC.Fill = new SolidColorBrush(color_button[7]);
                    break;
                case "buttonRosyBrown":
                    RC.Fill = new SolidColorBrush(color_button[8]);
                    break;
                case "buttonLightPink":
                    RC.Fill = new SolidColorBrush(color_button[9]);
                    break;
            }
        }
    }
}
