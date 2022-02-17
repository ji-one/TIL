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
using System.Windows.Shapes;

namespace MouseEventEx
{
    /// <summary>
    /// Tunneling.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Tunneling : Window
    {
        public Tunneling()
        {
            InitializeComponent();
        }

        private void Window_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Window_PreviewMouseDown");
        }

        private void Grid_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Grid_PreviewMouseDown");
        }

        private void Btn_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Btn_previewMouseDown");
        }

        private void Canv_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Canv_previewMouseDown");
        }

        private void Ellipse_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Console.WriteLine("Ellipse_PreviewMouseDown");
            Console.WriteLine(string.Empty);
        }
    }

}
