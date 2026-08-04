using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlFileComparisionTool
{
    public class XmlDataModel : INotifyPropertyChanged
    {
        private string AttributName { get; set; }
        private string AttributValue { get; set; }

        public string att_Name
        {
            get
            {
                return AttributName;
            }
            set
            {
                AttributName = value;
                OnPropertyChanged("att_Name");
            }
        }
        public string att_Value
        {
            get { return AttributValue; }
            set
            {
                AttributValue = value;
                OnPropertyChanged("att_Value");
            }
        }
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}
