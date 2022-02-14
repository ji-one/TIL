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

namespace WpfApp2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    /// 

/* 
 * WPF (Windows Presentation Foundation)은 개체 형태의  트리 구조를 갖고 있다.)
 * 이러한 트리 구조는 UI 요소 간의 관계를 쉽게 만들고 식별할 수 있다.
 * 개체 형태의 트리 구조를 개념화하기 위한 두 가지 방법
 *  - 논리 트리구조 (UI 요소 구조)
 *  - 시각화(Visual) 트리구조
 */
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
