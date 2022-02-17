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

namespace CalendarEx
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

        private void Cal_DisplayDateChanged(object sender, CalendarDateChangedEventArgs e)
        {
            if (TB != null)
                TB.Text = Cal.DisplayDate.ToString("yyyy-MM-dd");

        }

        private void Cal_DisplayModeChanged(object sender, CalendarModeChangedEventArgs e)
        {
            if (TB != null)
            {
                var info = Cal.DisplayDate.ToString("yyy-MM-dd") + " - " + Cal.DisplayMode.ToString();

                TB.Text = info;
            }

        }

        private void Cal_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            var info = Cal.SelectedDate == null
                ? "날짜 선택 안됨" : Cal.SelectedDate.Value.ToString("yyyy-MM-dd") + "선택됨";

            TB.Text = info;
        }

        private void Cal_DisplayDateChanged_1(object sender, CalendarDateChangedEventArgs e)
        {

        }
    }
}
