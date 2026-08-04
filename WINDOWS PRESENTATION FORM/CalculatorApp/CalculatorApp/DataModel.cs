using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace CalculatorApp
{
    //Static class creation : static class is the class which is unable to create the object for the static class 
    // static class having only static methods and static fields 
    public class DataModel
    {
        //Enum Creation 
        //enum is the special class that represents the read-only and unchanged variables 
        public enum SelectedOperator
        {
            [Description("+")]
            Addition,

            [Description("-")]
            Subtraction,

            [Description("*")]
            Multiplication,

            [Description("/")]
            Divide
        }


    }
}
