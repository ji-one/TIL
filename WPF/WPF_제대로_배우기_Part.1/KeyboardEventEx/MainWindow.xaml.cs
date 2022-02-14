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

namespace KeyboardEventEx
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
        private void Win_KeyDown(object sender, KeyEventArgs e)
        {
            //if (Background == Brushes.Yellow)
            //    Background = Brushes.White;
            //else
            //    Background = Brushes.Yellow;

            switch (e.Key)
            {
                case Key.R:
                    Background = Brushes.Red;
                    break;
                case Key.G:
                    Background = Brushes.Green;
                    break;
                case Key.Y:
                    Background = Brushes.Yellow;
                    break;
                case Key.B:
                    Background = Brushes.Blue;
                    break;
            }

        }

        // KeyUp : 눌려진 키를 놓을 때 발생하는 이벤트
        private void Win_KeyUp(object sender, KeyEventArgs e)
        {
            Background = Brushes.White;

        }

        // KeyDown : 키가 눌려질 때 발생하는 이벤트
        private void Name_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.R: name.Background = Brushes.Tomato; break;
                case Key.G: name.Background = Brushes.LightGreen; break;
                case Key.Y: name.Background = Brushes.LightYellow; break;
                case Key.B: name.Background = Brushes.LightBlue; break;
            }

            e.Handled = true; // 버블링을 중지한다.
        }

    }
 }