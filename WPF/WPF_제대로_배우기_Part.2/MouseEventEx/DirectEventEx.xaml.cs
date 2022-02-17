﻿using System;
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

namespace MouseEventEx
{
    /// <summary>
    /// DirectEventEx.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class DirectEventEx : Window
    {
        public DirectEventEx()
        {
            InitializeComponent();
        }

        private void btnSetColor(object sender, RoutedEventArgs e)
        {
            Button btn = e.Source as Button;
            btn.Background = Brushes.Yellow;

        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            e.Handled = true;
        }
    }
}
