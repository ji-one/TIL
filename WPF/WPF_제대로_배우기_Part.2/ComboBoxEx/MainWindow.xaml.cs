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

namespace ComboBoxEx
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
            var cpu = (ComboBoxItem)CPU.SelectedItem;
            var ram = (ComboBoxItem)RAM.SelectedItem;

            // var cpuVal = cpu == null ? "Cpu 선택이 안됨" : cpu.Content;
            var cpuVal = cpu == null ? CPU.Text : cpu.Content;
            var ramVal = ram == null ? "RAM 선택이 안됨" : ram.Content;

            MessageBox.Show($"CPU: {cpuVal}, RAM: {ramVal}");
        }

        private void RAM_DropDownOpened(object sender, EventArgs e)
        {
            RAM.Text = "";
        }
    }
}
