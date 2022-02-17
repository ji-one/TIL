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

namespace BorderEx
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

        private void Border_Loaded(object sender, RoutedEventArgs e)
        {
            ShowBorderSize();
        }

        private void ShowBorderSize()
        {
            double w = BorderEx.ActualWidth;
            double h = BorderEx.ActualHeight;

            lb.Content = string.Format($"너비: {w}, 높이: {h}");
        }

        private void Border_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            ShowBorderSize();
        }
    }
}
