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

namespace CopyPasteEx
{
    /// <summary>
    /// UnDoReDoEx.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class UnDoReDoEx : Window
    {
        public UnDoReDoEx()
        {
            InitializeComponent();
        }

        private void Undo_Click(object sender, RoutedEventArgs e)
        {
            MyTextBox.Undo();
            ShowFlags();
        }

        private void Redo_Click(object sender, RoutedEventArgs e)
        {
            MyTextBox.Redo();
            ShowFlags();
        }
        
        /*
            IsUndoEnabled 플래그 : 실행 취소 및 다시 실행 기능을 사용할 수 있는지 여부를 지정
         */

        private void IsUndoEnabled_Click(object sender, RoutedEventArgs e)
        {
            MyTextBox.IsUndoEnabled = ((CheckBox)sender).IsChecked.Value;
        }

        private void MyTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            ShowFlags();
        }

        // TextBox의 CanUndo, CanRedo 속성
        // CanUndo : 텍스트 박스의 컨트롤에서 이전 작업을 실행 취소할 수 있는지 여부를 나타내는 값(true, false)을 가져옴
        // CanRedo : 텍스트 박스의 컨트롤에서 가장 최근의 실행 취소 작업을 다시 실행할 수 있는지 여부를 나타내는 값을 가져옴
        private void ShowFlags()
        {
            Chk_Undo.IsChecked = MyTextBox.CanUndo;
            Chk_Redo.IsChecked = MyTextBox.CanRedo;
        }
    }
}
