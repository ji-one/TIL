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
using System.Windows.Controls.Primitives;

namespace DragEx
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

        // DragStarted 이벤트 인수는 DragStartedEventArgs

        private void GS_DragStarted(object sender, DragStartedEventArgs e)
        {
            LeftText.Text = "드래그 시작!";
            GS.Background = Brushes.Red;
        }
        private void GS_DragCompleted(object sender, DragCompletedEventArgs e)
        {
            LeftText.Text = string.Format($"드래그 {e.HorizontalChange} 이동");
            GS.Background = Brushes.Gray;
        }

        private void GS_DragDelta(object sender, DragDeltaEventArgs e)
        {
            if(e.HorizontalChange == 0)
            {
                RightText.Text = "움직임 없음";
            }
            else if(e.HorizontalChange > 0)
            {
                RightText.Text = "오른쪽으로 움직임";
            }
            else
            {
                RightText.Text = "왼쪽으로 움직임";
            }

            if(LeftText.ActualWidth > 200 && RightText.Text == "오른쪽으로 움직임")
            {
                GS.CancelDrag();
            }
        }
    }
}
