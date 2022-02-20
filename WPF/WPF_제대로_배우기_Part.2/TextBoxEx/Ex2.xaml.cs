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

namespace TextBoxEx
{
    /// <summary>
    /// Ex2.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Ex2 : Window
    {
        public Ex2()
        {
            InitializeComponent();
        }

        /*
            TextBox에서 선택 위치를 얻어오기 위한 속성
            
            - CaretIndex : 캐럿의 위치를 설정
            - SelectionStart : 선택한 텍스트가 시작되는 위치값(CaretIndex와 같은 값을 리턴)
            - SelectionLength : 선택된 문자 수를 반환, 선택 문자가 없으면 0을 리턴
         */

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            // MyLabel.Content = MyTextBox.SelectedText;

            string locValue = string.Format(
                $"{MyTextBox.SelectedText} / Caret : {MyTextBox.CaretIndex} / Start: {MyTextBox.SelectionStart} / Length: {MyTextBox.SelectionLength}");

            MyLabel.Content = locValue;
        }

        private void SelBtn_Click(object sender, RoutedEventArgs e)
        {
            MyTextBox.Select(1, 4);
        }

        private void AllBtn_Click(object sender, RoutedEventArgs e)
        {
            MyTextBox.SelectAll();
        }
        
        /*
         * SelectionChanged 이벤트 : 선택한 텍스트를 변경하거나 캐럿을 이동할 때 발생하는 이벤트
         *                           마우스나 키보드 등의 입력 장치를 사용해서 선택을 조정할 때마다 발생
         */       
        private void MyTextBox_SelectionChanged(object sender, RoutedEventArgs e)
        {
            string locValue = string.Format(
                $"{MyTextBox.SelectedText} / Caret: {MyTextBox.CaretIndex} / Start: {MyTextBox.SelectionStart} /" +
                $"Length: {MyTextBox.SelectionLength}");

            MyLabel.Content = locValue;
        }

        /*
         * AutoWordSelection 속성 : 자동 단어 선택 기능으로 false 설정을 하면 이 기능이 해제된다.
         */
        private void Auto_Checked(object sender, RoutedEventArgs e)
        {
            MyTextBox.AutoWordSelection = ((CheckBox)sender).IsChecked.Value;
        }


    }
}
