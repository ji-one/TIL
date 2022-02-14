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
    /// RepeatButton.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class RepeatButton : Window
    {
        private int tbNameSize = 20;
        public RepeatButton()
        {
            InitializeComponent();
        }

        private void btnDown_Click(object sender, RoutedEventArgs e)
        {
            tbNameSize = Math.Max(10, --tbNameSize);
            tbName.FontSize = tbNameSize;
        }

        private void btnUp_Click(object sender, RoutedEventArgs e)
        {
            tbNameSize = Math.Min(30, ++tbNameSize);
            tbName.FontSize = tbNameSize;
        }
    }
}
