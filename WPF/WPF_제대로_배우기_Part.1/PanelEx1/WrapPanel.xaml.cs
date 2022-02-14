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

// WrapPanel : WrapPanel 자신의 영역보다 작은 자식요소들인 경우에는 StackPanel과 같은 기능이고,
// 반대로 자식요소들의 사이즈가 더 큰 경우에는 다음 줄에 배치된다.

namespace PanelEx1
{
    /// <summary>
    /// WrapPanel.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class WrapPanel : Window
    {
        public WrapPanel()
        {
            InitializeComponent();
        }
    }
}
