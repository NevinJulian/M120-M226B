using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Projekt
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Canvas_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DisplayWindow displayWindow = new DisplayWindow();
            displayWindow.ShowDialog();
        }

        private void Canvas_MouseEnter(object sender, MouseEventArgs e)
        {
            /*SolidColorBrush brush = new SolidColorBrush(Colors.LightGray);
            brush.Opacity = 0.5;
            Canvas canvas = (Canvas)sender;
            canvas.Background = brush;*/
            Mouse.OverrideCursor = Cursors.Hand;
        }



        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.ShowDialog();
        }

        private void Canvas_MouseLeave(object sender, MouseEventArgs e)
        {
            Mouse.OverrideCursor = Cursors.Arrow;
        }
    }
}
