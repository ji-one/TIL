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

namespace ObjectLifetimeEx
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    
    /*
        Object 수명 주기
        - Initialize : 컨트롤의 생성자가 실행될 때

        - Loaded : 해당 컨트롤이 화면에 랜더링 되기 전에 발생하는 이벤트

        - Unloaded : 객체 수명 주기의 마지막 단계 이벤트이며 논리 트리에서 제거되면 발생하는 이벤트
     
     */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Initialized(object sender, EventArgs e)
        {
            MessageBox.Show("Initialized");
        }
        private void Grid_Loaded(object sender, EventArgs e)
        {
            MessageBox.Show("Loaded");
        }
        private void Grid_Unloaded(object sender, EventArgs e)
        {
            MessageBox.Show("Unloaded");
        }
    }
}
