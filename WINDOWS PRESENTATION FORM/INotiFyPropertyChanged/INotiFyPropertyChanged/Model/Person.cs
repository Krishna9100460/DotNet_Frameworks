using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INotiFyPropertyChanged.Model
{
    internal class Person : INotifyPropertyChanged
    {
        private string firstName;
        private string lastName;
        private string fullName;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                firstName = value;
                OnPropertyRaised("FirstName");
                OnPropertyRaised("FullName");

            }
        }
        public string LastName
        {
            get { return lastName; }
            set
            {
                lastName = value;
                OnPropertyRaised("LastName");
                OnPropertyRaised("FullName");
            }
        }

        public string FullName
        {
            get { return fullName; }
            set
            {
                fullName = value;
                OnPropertyRaised("FullName");
            }
        }

        public Person()
        {
            firstName = "krishna";
            lastName = "prasad";
            fullName=firstName+ " " + lastName;
        }

        #region
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyRaised(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
