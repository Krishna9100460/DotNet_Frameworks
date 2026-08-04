using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WPFRoutedEvents
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string d { get; set; }
       
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void MyCustomControl_Click(object sender, RoutedEventArgs e)
        {
             d = "custom control";
            txtblock.Text= d;
            MessageBox.Show(d);
        }




    }
}
