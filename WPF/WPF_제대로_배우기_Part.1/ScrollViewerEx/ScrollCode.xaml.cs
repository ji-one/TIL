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

namespace ScrollViewerEx
{
    /// <summary>
    /// ScrollCode.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class ScrollCode : Window
    {
        public ScrollCode()
        {
            InitializeComponent();
        }
        private void LineUp(object sender, RoutedEventArgs e)
        {
            sv.LineUp();
        }

        private void LineDown(object sender, RoutedEventArgs e)
        {
            sv.LineDown();
        }

        private void LineLeft(object sender, RoutedEventArgs e)
        {
            sv.LineLeft();
        }

        private void LineRight(object sender, RoutedEventArgs e)
        {
            sv.LineRight();
        }

        private void PageUp(object sender, RoutedEventArgs e)
        {
            sv.PageUp();
        }

        private void PageDown(object sender, RoutedEventArgs e)
        {
            sv.PageDown();
        }

        private void PageLeft(object sender, RoutedEventArgs e)
        {
            sv.PageLeft();
        }

        private void PageRight(object sender, RoutedEventArgs e)
        {
            sv.PageRight();
        }
    }
}
