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
        public void OnClickCommand(object sender, RoutedEventArgs routEventArgs)
        {
            Color c = Colors.Khaki;
            Color r = Colors.Red;
            Button? b = sender as Button;
            if (b != null)
            {
                if (b.Name == "buttonKhaki")
                {
                    RC.Fill = new SolidColorBrush(c);
                } else if (b.Name == "buttonRed")
                {
                    RC.Fill = new SolidColorBrush(r);
                }
                else
                {
                    b.Content = "NO Sorry";
                }
            }
        }
    }
}
