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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace visibilityStatusEx
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
            var visibility = LeftPanel.Visibility;
            
            switch(visibility)
            {
                case Visibility.Visible:
                    LeftPanel.Visibility = Visibility.Hidden;
                    break;
                case Visibility.Hidden:
                    LeftPanel.Visibility = Visibility.Collapsed;
                    break;
                case Visibility.Collapsed:
                    LeftPanel.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void IsVisible_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(LeftPanel.IsVisible.ToString(), "IsVisible");
        }

        private void Opacity_Click(object sender, RoutedEventArgs e)
        {
            double opacity = LeftPanel.Opacity;
            opacity -= 0.25;

            if( opacity < 0)
            {
                opacity = 1;
            }

            LeftPanel.Opacity = opacity;
        }

        private void Me_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("click");
        }

        private void IsHitTestVisible_Click(object sender, RoutedEventArgs e)
        {
            LeftPanel.IsHitTestVisible = !LeftPanel.IsHitTestVisible;
        }

        private void IsEnabled_Click(object sender, RoutedEventArgs e)
        {
            LeftPanel.IsEnabled = !LeftPanel.IsEnabled;
        }
    }
}
