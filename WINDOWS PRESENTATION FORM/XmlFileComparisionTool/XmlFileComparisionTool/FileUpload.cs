using GalaSoft.MvvmLight.Command;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Xml;

namespace XmlFileComparisionTool
{

    internal class FileUpload:INotifyPropertyChanged
    {
        private string CurrentFilePath;
        private string GoldenFilePath;
        CurrentFileRead read=new CurrentFileRead();
        XmlDocument xmlDoc = new XmlDocument();
        public string CurrenFile
        {
            get { return CurrentFilePath; }
            set
            {
                CurrentFilePath = value;
                OnPropertyChanged(nameof(CurrenFile));
            }
        }

        public string GoldenFile
        {
            get { return GoldenFilePath; }
            set
            {
                GoldenFilePath = value;
                OnPropertyChanged(nameof(GoldenFile));
            }
        }

        public ICommand UploadFile1Command { get; private set; }
        public ICommand UploadFile2Command { get; private set; }
        public ICommand CompareFile { get; private set; }

        public FileUpload()
        {
            UploadFile1Command = new RelayCommand(UploadFile1);
            UploadFile2Command = new RelayCommand(UploadFile2);
            CompareFile = new RelayCommand(read.CompareFileGenerator);
           
        }

        private void UploadFile1()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "XML files (*.xml)|*.xml";

                if (openFileDialog.ShowDialog() == true)
                {
                    CurrenFile = openFileDialog.FileName;
                }

                if (CurrenFile == null)
                {
                    MessageBox.Show("File not Uploaded");
                }
                else
                {
                    xmlDoc.Load(CurrenFile);
                    read.CurrentReportReader(xmlDoc.DocumentElement);
                   // read.FileNameCreate(CurrenFile);
                }
            }
            catch(Exception )
            {
                MessageBox.Show("Curent Files Path missmatch");
            }
        }

        private void UploadFile2()
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "XML files (*.xml)|*.xml";

                if (openFileDialog.ShowDialog() == true)
                {
                    GoldenFile = openFileDialog.FileName;
                }

                if (GoldenFile == null)
                {
                    MessageBox.Show("File not Uploaded");
                }
                else
                {
                    xmlDoc.Load(GoldenFile);
                    read.GoldenReportReader(xmlDoc.DocumentElement);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
