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

namespace WPF_Controllers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Handlchecked(object sender, RoutedEventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            if (cb == checkbox1)
            {
                txt1.Text = "two stats checked";
            }
            else
            {
                txt2.Text = "three states checked";
            }
        }
        private void Handlunchecked(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox == checkbox1)
            {
                txt1.Text = "two stats unchecked";
            }
            else
            {
                txt2.Text = "three states unchecked";
            }
        }

        #region ContextMenu
        private void BoldeChecked(object sender, RoutedEventArgs e)
        {
            txtBox.FontWeight= FontWeights.SemiBold;
            txtBox.HorizontalAlignment=HorizontalAlignment.Right;
        }
        private void BoldUnChecked(object sender, RoutedEventArgs e)
        {
            txtBox.FontWeight= FontWeights.Normal;
        }
        private void italicChecked(object sender, RoutedEventArgs e)
        {
            txtBox.FontStyle= FontStyles.Italic;
            txt1.FontFamily = FontFamily ;
        }
        private void itlalicUncheck(object sender, RoutedEventArgs e)
        {
            txtBox.FontStyle= FontStyles.Normal;
        }
        private void Font_Increase(object sender, RoutedEventArgs e)
        {
            if(txtBox.FontSize<18)
            {
                txtBox.FontSize += 5;
            }
               
        }
        private void Font_Decrease(object sender, RoutedEventArgs e)
        {
            if(txtBox.FontSize>10)
            {
                txtBox.FontSize -= 5;
            }
        }

        private void Copy(object sender, RoutedEventArgs e)
        {
            txtBox.Copy();
        }
        private void Past(object sender, RoutedEventArgs e)
        {
            txtBox.Paste();
        }
        private void Cut(object sender, RoutedEventArgs e)
        {
            txtBox.Cut();
        }
        private void Undo(object sender, RoutedEventArgs e)
        {
            txtBox.Undo();
        }
        #endregion
        #region message box Controller
        private void MsgBox(object sender, RoutedEventArgs e)
        {
            string msgTxt = "Are you sure want to close";
            string txt = "My Title";
            MessageBoxButton btn = MessageBoxButton.YesNoCancel;
            MessageBoxResult result= MessageBox.Show(msgTxt, txt, btn);
          /*  switch (result)
            {
                case MessageBoxResult.Yes:Close(); 
                    break;
                    case MessageBoxResult.No:txtBox2.Text="No";
                    break;
                case MessageBoxResult.Cancel: txtBox2.Text= "Cancle";
                    break;
            }*/
        }
        #endregion

        #region Menu controller

        private void MenuItem1(object sender, RoutedEventArgs e)
        {
            MenuItem item= sender as MenuItem;
            this.Title ="File"+ item.Header;
        }
        private void MenuItem2(object sender, RoutedEventArgs e)
        {
            MenuItem item = sender as MenuItem;
            this.Title = "Edit" + item.Header;
        }
        private void MenuItem3(object sender, RoutedEventArgs e)
        {
            MenuItem item = sender as MenuItem;
            this.Title = "View" + item.Header;
        }
        #endregion
    }

}
