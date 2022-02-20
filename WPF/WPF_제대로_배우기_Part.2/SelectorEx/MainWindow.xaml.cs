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

namespace SelectorEx
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
            // SelTabLabel.Content = TC.SelectedIndex;
            // TC.SelectedIndex = 2; // 탭 설정
            // TC.SelectedIndex = -1; // 어떠한 탭도 선택되지 않는다.
            // TC.SelectedIndex += 1;
            // SelTabLabel.Content = TC.SelectedIndex;

            // SelectedItem 속성 : SelectedIndex 속성과 비슷한 기능을 수행 한다.
            // 단지, 차이점은 리턴값이 인덱스가 아닌 값을 리턴한다.

            //var tab = tc.selecteditem as tabitem;
            //seltablabel.content = tab.header;
            //seltablabel.background = tab.background;

            // SelectedValue, SelectedValuePath 속성
            // 위 두 속성은 함께 동작한다.
            // SelectedValue : 현재 선택된 항목을 기반으로 하는 값 또는 선택할 수 있는 여러 항목 중에 첫번째 항목을 반환한다.
            //                  이때 반환되는 값은 SelectedValuePath의 내용이다.

            // SelTabLabel.Content = TC.SelectedValue;
            // SelectionChanged : 선택 사항이 변경될 때마다 발생하는 이벤트

        }

        private void TC_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // SelectionChanged : 선택 사항이 변경될 때 마다 발생하는 이벤트
            //var tab = TC.SelectedItem as TabItem;

            //SelTabLabel.Content = tab.Header;
            //SelTabLabel.Background = tab.Background;
            
            // IsSelected : 항목 선택 여부 빠르게 확인할 수 있는 속성
            //              TabItem 클래스에는 자체적으로 IsSelected 속성을 포함하고 있다.
       

            foreach (TabItem tab in TC.Items)
            {
                if((bool)tab.GetValue(TabControl.IsSelectedProperty))
                {
                    SelTabLabel.Content = tab.Header;
                    SelTabLabel.Background = tab.Background;
                }
            }
        }

        private void TI_Selected(object sender, RoutedEventArgs e)
        {
            var tab = sender as TabItem;
            string header = tab.Header.ToString();
            tab.Header = header + "*";

        }

        private void TI_Unselected(object sender, RoutedEventArgs e)
        {
            var tab = sender as TabItem;
            string header = tab.Header.ToString();
            tab.Header = header.Substring(0, header.Length - 1);


        }
    }
}


