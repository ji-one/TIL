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

/* 
    WPF는 일반적인 이벤트보다 더욱 견고한 Routed Event를 사용한다.
    
    이벤트의 라우팅은 버블링(bubbling), 터널링(tunneling) 2가지로 분류된다.

    이벤트가 엘리먼트 트리를 따라서 위나 아래로 이동할 때 이를 라우팅이라 한다.
    
    터널링 : Root에서 부터 시작해서 이벤트를 발생시킨 대상 요소를 찾아 내려가는 방식
    버블링 : 이벤트를 발생시킨 대상 요소에 붙은 이벤트 핸들러를 찾는 방식. 즉, 그 요소 트리의 루트에 도달할 때까지 부모 요소들을 
             차례로 찾아나가는 방식

    직접전달(Direct) : 이벤트를 발생시킨 요소에 등록된 이벤트 핸들러에만 이벤트가 통지되며 어떤 라우팅도 발생하지 않는다.
    
    ** WPF는 직접 전달 이벤트를 제외한 대부분의 라우팅된 이벤트를 버블링과 터널링의 쌍으로 구성한다.
    
    터널링 이벤트의 경우 이름이 항상 Preview로 시작하며 우선적으로 발생한다.

    대부분은 버블링 이벤트만을 처리하게 되며, Preview 이벤트의 경우 이벤트 발생을 막거나 일반적인 이벤트 처리 전에 부모의 
    요소에 처리해야할 코드가 있는 경우에만 사용한다.
    

    [ WPF 이벤트 구조 ]
        Object
            ㄴ EventArgs
                ㄴ RoutedEventArgs
                    ㄴ InputEventArgs
                        ㄴ KeyboardEventArgs
                            ㄴ KeyboardFocusChangedEventArgs
                            ㄴ KeyEventArgs
                        ㄴ MouseEventArgs
                            ㄴ MouseButonEventArgs
                            ㄴ MouseWheelEventArgs
                            ㄴ QueryCursorEventArgs
                        ㄴ StylusEventArgs
                            ㄴ StylusButtonEventArgs
                            ㄴ StylusDownEventArgs
                            ㄴ StylusSystemGestureEventArgs
                        ㄴ TextCompositionEventArgs

*/
namespace RoutedEventEx
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        string Msg = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void myBtn_Click(object sender, RoutedEventArgs e)
        {
            Msg += "버튼 클릭\n";
            MessageBox.Show(Msg);
            Msg = string.Empty;
        }

        private void myCanv_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Msg += "Canvas 다운\n";
        }

        private void myEllipse_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Msg += "Ellipse 다운\n";
        }

        private void myEllipse_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            Msg += "Ellipse Preview Mouse Down\n";
        }
    }
}
