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

namespace ProgressBarEx
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

        private void Minus_Click(object sender, RoutedEventArgs e)
        {
            // if(PB.Value > 0)
            if(PB.Value > PB.Minimum)
            {
                PB.Value--;
            }
            SetProgressValue();
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            // if(PB.Value < 100)
            if(PB.Value < PB.Maximum)
            {
                PB.Value++;
            }
            SetProgressValue();
        }

        // ProgresssBar는 IsIndeterminate 속성
        // ProgressBar에 Indeterminate 속성을 true로 설정하면 사용자에게 프로그램이 중단되지 않았다는 것을 알려줄 수 있다.
        private void Indeterminate_Click(object sender, RoutedEventArgs e)
        {
            PB.IsIndeterminate = !PB.IsIndeterminate;
            if (PB.IsIndeterminate)
                ProgressValue.Content = "";
            else
                SetProgressValue();
        }

        private void SetProgressValue()
        {
            ProgressValue.Content = PB.Value;
            PB.IsIndeterminate = false;
        }
    }
}
