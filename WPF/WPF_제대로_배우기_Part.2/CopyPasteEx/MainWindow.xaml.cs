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

namespace CopyPasteEx
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

        private void Cut_Click(object sender, RoutedEventArgs e)
        {
            MyTextBox.Cut(); // 선택한 텍스트가 클립 보드로 이동하고 텍스트 상자에서 제거된다. 
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            MyTextBox.Copy(); // 선택한 텍스트가 클립 보드에 복사된다. 선택한 텍스트는 해당 컨트롤에 남아 있는다. 
        }

        private void Paste_Click(object sender, RoutedEventArgs e)
        {
            MyTextBox.Paste(); // 이미 클립보드에 있는 텍스트를 텍스트 상자에 복사한다. 
        }
    }
}
