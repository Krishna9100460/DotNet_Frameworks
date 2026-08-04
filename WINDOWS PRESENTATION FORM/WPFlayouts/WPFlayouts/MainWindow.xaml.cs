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

namespace WPFlayouts
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button? b=sender as Button;
            string? str=b.Content.ToString()+"Button clicked";
            MessageBox.Show(str);
        }
        private void onMouseEnter(object sender, MouseEventArgs e)
        {
           Rectangle sou= e.Source as Rectangle;

            if(sou!=null)
            {
                sou.Fill=Brushes.BlueViolet;
            }

            txt1.Text = "Mouse Entered";
          
        }
        private void OnMouseLeave(object sender, MouseEventArgs e)
        {
            Rectangle sou
                 = sender as Rectangle;
            if(sou!=null)
            {
                sou.Fill=Brushes.Black;
            }
            txt2.Text = "Mouse Leave";
            txt1.Text = "";
            txt3.Text = "";
        }
        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            Point pnt=e.GetPosition(mer);
            txt2.Text = "Mouse Move: " + pnt.ToString();
        }
        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            Rectangle source = e.Source as Rectangle;
            Point pnt = e.GetPosition(mer);
            txt3.Text = "Mouse Click: " + pnt.ToString();

            if (source != null)
            {
                source.Fill = Brushes.Beige;
            }
        }
    }
}
