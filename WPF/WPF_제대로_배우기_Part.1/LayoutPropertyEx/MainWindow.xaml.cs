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
기본 레이아웃 속성
    - 기본 레이아웃 속성들은 FrameworkElement로부터 상속된다.
    
    ActualHeight : 렌더링된 개체의 높이 값
    ActualWidth : 렌더링된 개체의 너비 값
    FlowDirection : 컨텐츠의 흐름 방향을 지정
                    LeftToRight : 왼쪽에서 오른쪽으로
                    RightToLeft : 오른쪽에서 왼쪽으로 흐름을 나타냄
    Height, Width
    MaxHeight   MaxHeight : 최대 크기 범위를 지정해줌, Height보다 유연성이 있음
    MinWidth   MinWidth : 최소 크기의 범위를 지정해줌, Width보다 유연성이 있음

    HorizontalAlignment, VerticalAlginment
    Margin, Padding


    LayoutTransform,
    RenderTransform
        - MatrixTransform
        - RotateTransform
        - ScaleTransform
        - SkewTransform
        - TranslateTransform

    ZIndex
    -------------------------------------

    Visibility : 화면에 보이도록 할 지, 숨길지를 결정하는 속성
                 Collapse(Width=0, Height=0), Hidden, Visible
    isEnabled : true(활성화), false(비활성화)
*/
namespace LayoutPropertyEx
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            lb1.Content = string.Format($"ActualWidth: {comboBox1.ActualWidth}, Width: {comboBox1.Width}");
            lb2.Content = string.Format($"ActualHeight: {comboBox1.ActualHeight}, width: {comboBox1.Height}");
        }
    }
}
