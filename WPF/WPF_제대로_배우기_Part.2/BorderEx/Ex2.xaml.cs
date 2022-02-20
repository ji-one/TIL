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

namespace BorderEx
{
    /// <summary>
    /// Ex2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex2 : Window
    {
        public Ex2()
        {
            InitializeComponent();
        }

        private void Top_Click(object sender, RoutedEventArgs e)
        {
            Top.BringIntoView();
        }

        private void Middle_Click(object sender, RoutedEventArgs e)
        {
            //Middle.BringIntoView(new Rect(0,0, 50, 50));
            Middle.BringIntoView();
        }
        private void Bottom_Click(object sender, RoutedEventArgs e)
        {
            //Bottom.BringIntoView(new Rect(0, 0, 50, 50)); // 절반 크기
            Bottom.BringIntoView();
        }
        private void Border_RequestBringIntoView(object sender, RequestBringIntoViewEventArgs e)
        {
            setBackGroundChange(Top, (Border)sender);
            setBackGroundChange(Middle, (Border)sender);
            setBackGroundChange(Bottom, (Border)sender);
        }

        private void setBackGroundChange(Border target, Border sender)
        {
            target.Background = target == sender ? Brushes.Yellow : Brushes.White;
        }
    }
}
