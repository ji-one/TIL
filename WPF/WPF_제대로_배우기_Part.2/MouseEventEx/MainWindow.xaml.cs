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
using System.Diagnostics;

namespace MouseEventEx
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SP_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Mouse Down");
        }

        private void SP_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Mouse up");
        }

        private void SP_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Left Button Down");
        }

        public void SP_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Left BUtton Up");
        }

        private void SP_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Right Button Down");
        }

        private void SP_MouseRightButtonUp(object sender, MouseButtonEventArgs e)
        {
            Debug.WriteLine("Right Button Up");
        }
        
        private void SP_MouseEnter(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Enter");
        }

        private void SP_MouseLeave(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Leave");
        }

        private void SP_MouseMove(object sender, MouseEventArgs e)
        {
            Debug.WriteLine("Move");
        }

        private void SP_MouseWheel(object sender, MouseWheelEventArgs e)
        {
            Debug.WriteLine("Wheel");
        }
    }
}
