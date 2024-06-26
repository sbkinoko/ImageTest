﻿using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ImageTest
{
    /// <summary>
    /// Interaction logic for SubWindow.xaml
    /// </summary>
    public partial class SubWindow : Window
    {
        public SubWindow(AppViewModel sharedViewModel)
        {
            this.DataContext = sharedViewModel;
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            selectFile();
        }

        private void selectFile()
        {

            //OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            {
                openFileDialog.Title = "ファイル選択ダイアログ";
                openFileDialog.Filter = "すべてのファイル(*.*)|*.*";

                //ファイル選択ダイアログを開く
                if (openFileDialog.ShowDialog() == true)
                {
                    roadedImage.Source = new BitmapImage(new Uri(openFileDialog.FileName));
                }
            }
        }
    }
}