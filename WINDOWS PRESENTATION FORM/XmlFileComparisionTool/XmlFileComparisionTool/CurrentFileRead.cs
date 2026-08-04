using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Media3D;
using System.Xml;
using System.Xml.Linq;

namespace XmlFileComparisionTool
{
    internal class CurrentFileRead
    {
       string? UploadedFileName=null;
       public  IList<string> GoldenData = new List<string>();
       public IList<string> CurrentData = new List<string>();

        /*public void FileNameCreate(string currentFile)
        {
            int start = currentFile.IndexOf(@"C2\") + 3;
            int end = currentFile.IndexOf(@"\N");
            UploadedFileName = currentFile.Substring(start, end - start);
        }*/
        public void CurrentReportReader(XmlNode node)
        {
            // Check if the node has attributes
            if (node.Attributes != null)
            {
                // Iterate over the attributes of the node
                foreach (XmlAttribute attribute in node.Attributes)
                {
                    string attributeName = attribute.Name;
                    string attributeValue = attribute.Value;
                    //add the data to Current list of data
                    CurrentData.Add(attributeValue);
                }
            }
            // Recursively process the child nodes
            foreach (XmlNode childNode in node.ChildNodes)
            {
                CurrentReportReader(childNode);
            }
        }
        public void GoldenReportReader(XmlNode node)
        {
            // Check if the node has attributes
            if (node.Attributes != null)
            {
                // Iterate over the attributes of the node
                foreach (XmlAttribute attribute in node.Attributes)
                {
                    string attributeName = attribute.Name;
                    string attributeValue = attribute.Value;
                   
                        GoldenData.Add(attributeValue);
                    //adding the data to Current list of data
                }
            }

            // Recursively process the child nodes
            foreach (XmlNode childNode in node.ChildNodes)
            {
                GoldenReportReader(childNode);
            }
        }
        public void CompareFileGenerator()
        {
            List<string>? data=null;
            try
            {
                if(GoldenData.Count==CurrentData.Count)
                {
                    MessageBox.Show("Both File are identical");
                }
                else
                {
                    MessageBox.Show("Both File are Different");
                    data = GoldenData.Except(CurrentData).ToList();
                   // data = GoldenData.ToList();
                }
               
                if (GoldenData.Count!=CurrentData.Count && GoldenData.Count > 0 && CurrentData.Count>0)
                {
                    using (StreamWriter writer = new StreamWriter(@"D:\DOCUMENT\XmlComparision"+DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss")+".csv"))
                    {
                        // Write the CSV header
                        writer.WriteLine("Miss matched Values");
                        // Write the data rows
                        foreach (string row in data)
                        {
                            writer.WriteLine(row);
                        }
                    } 
                    MessageBox.Show("Data Compared");
                }
                else
                {
                    MessageBox.Show("Please Upload the Files ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 

        }
    }
}
