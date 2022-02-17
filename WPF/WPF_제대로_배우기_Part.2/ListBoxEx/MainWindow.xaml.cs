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

namespace ListBoxEx
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

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            //var selected = (ListBoxItem)MyList.SelectedItem;
            //string value = selected == null ? "요일 선택하세용" : selected.Content.ToString() + "을 선택하셨습니다용";
            //MessageBox.Show(value);

            if(MyList.SelectedItems.Count == 0)
            {
                MessageBox.Show("선택된 요일이 없슴다");
            }
            else
            {
                foreach(ListBoxItem selected in MyList.SelectedItems)
                {
                    MessageBox.Show(selected.Content.ToString());
                }
            }
        }
    }
}
