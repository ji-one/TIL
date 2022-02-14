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

// StackPanel : 자식 요소들을 행이나 열로 간단하게 나열할 수 있는 패널이다.
// 가로 방향, 세로 방향으로 자식요소들을 나열할 수 있는데, 기본 설정값은 수직방향이다.
namespace PanelEx1
{
    /// <summary>
    /// Stackpanel.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Stackpanel : Window
    {
        public Stackpanel()
        {
            InitializeComponent();
        }
    }
}
