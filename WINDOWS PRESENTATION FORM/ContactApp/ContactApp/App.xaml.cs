using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace ContactApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static string databaseName = "Contact.db";
      //  static string folderPath=Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        public static string datbasepath=System.IO.Path.Combine(@"D:\Data\WINDOWS PRESENTATION FORM\WPF NEW\ContactApp\DataBase", databaseName);
    }
}
