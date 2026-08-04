using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDependencyProperty
{
    internal class DataModel:INotifyPropertyChanged
    {
       
        private string fname;
        private string lname;
        private string gmail;
        private string location;
        public string DateOfBirth { get; set; }

        public string Gender { get; set; }

        public string Fname
        {
            get { return fname; } set
            {
                fname = value;
              //  OnPropertyChanged("Fname");
              
            }
        }

        public string Lname
        {
            get { return lname; }
            set
            {
                lname= value;
              //  OnPropertyChanged("Lname");
               
            }
        }
        public string Gmail
        {
            get { return gmail; }
            set
            {
                gmail = value;
               // OnPropertyChanged("Age");
            }
        }
        public string Location
        {
            get { return location; }
            set
            {
                location= value;// OnPropertyChanged(nameof(Location));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged!=null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
