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

/* 
 * 레이아웃 컨트롤을 통칭해서 패널(Panel) 또는 컨테이너(Container)라고 한다.
 * - Canvas : Canvas 영역에 좌표를 사용해서 자식 요소들을 배치한다.
 *              Canvas는 가장 단순한 패널에 해당된다. Canvas 크기가 변해도 자식요소들의 크기는 변하지 않는다.
 *              
 * - DockPanel : 자식 요소를 기준으로 가로 또는 세로로 정렬할 수 있는 영역을 정의한다.
 */
namespace PanelEx1
{
    /// <summary>
    /// Canvas.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Canvas : Window
    {
        public Canvas()
        {
            InitializeComponent();
        }
    }
}
