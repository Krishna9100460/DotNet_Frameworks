using System;
using System.ComponentModel;
using System.Reflection;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Controls;
using static CalculatorApp.DataModel;

namespace CalculatorApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double lastnumber, resul;
        double newnumber;
        SelectedOperator? selectedOperator;
        string? description = null;

        // this constructor used for initiale startup for the application , it is also called the code behind file of the XAML code file 
        public MainWindow()
        {
            InitializeComponent();
        }

        //evenet creation for Button handler .
        #region AC Button Event method 
        private void AcBtn_Clicked(object sender, RoutedEventArgs e)
        {
            ResultLable.Content = "0";
            dataLable.Content = "";
            lastnumber = 0;
        }
        #endregion

        #region Square Button event method 
        private void SquareBtn_Clicked(object sender, RoutedEventArgs e)
        {
            if(double.TryParse(ResultLable.Content.ToString(),out lastnumber))
            {
                lastnumber *= lastnumber;
                ResultLable.Content = lastnumber;
            }
        }
        #endregion

        #region Percentage(%) Button event method 
        private void PerBtn_Clicked(object sender, RoutedEventArgs e)
        {
            double tempNumber=0;
            if (double.TryParse(ResultLable.Content.ToString(), out tempNumber))
            {
                tempNumber= tempNumber /100;
                if(lastnumber!=0)
                {
                    tempNumber *= lastnumber;
                }
                ResultLable.Content = tempNumber;
            }
        }
        #endregion

        #region Numbers Button event method 
        private void Number_Clicked(object sender, RoutedEventArgs e)
        {
            int selectedValue = int.Parse((sender as Button).Content.ToString());
            if (ResultLable.Content.ToString() == "0")
            {
                ResultLable.Content = $"{selectedValue}";
            }
            else
            {
                ResultLable.Content = $"{ResultLable.Content}{selectedValue}";
            }
        }
        #endregion

        #region Equal(=) Button event method 
        private void EuqalBtn_click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(ResultLable.Content.ToString(), out newnumber))
            {
                if (selectedOperator != null)
                {
                    switch (selectedOperator)
                    {
                        case SelectedOperator.Addition:
                            resul = CalculationHelper.Add(lastnumber, newnumber);
                            
                            break;
                        case SelectedOperator.Subtraction:
                            resul = CalculationHelper.Sub(lastnumber, newnumber);
                            
                            break;
                        case SelectedOperator.Multiplication:
                            resul = CalculationHelper.Mul(lastnumber, newnumber);
                            
                            break;
                        case SelectedOperator.Divide:
                            resul = CalculationHelper.Div(lastnumber, newnumber);
                            break;
                    }
                    ResultLable.Content = resul;
                    dataLable.Content += $"{newnumber}=";
                }
            }
        }
        #endregion

        #region Dot Button event method 
        private void DotBtm_Clicked(object sender, RoutedEventArgs e)
        {
            string? data=ResultLable.Content.ToString();
            if (data != null)
            {
                if (data.Contains("."))
                {
                    ///
                }
                else
                {
                    ResultLable.Content = $"{ResultLable.Content}.";
                }
            }
        }
        #endregion

        #region operator Button event method 
        private void Operation_Clicked(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(ResultLable.Content.ToString(), out lastnumber))
            {
                ResultLable.Content ="0";
            }
            if (sender == PlusBtn)
            {
                selectedOperator = SelectedOperator.Addition;
                description = typeof(SelectedOperator).GetField(SelectedOperator.Addition.ToString())?
                              .GetCustomAttribute<DescriptionAttribute>()?.Description;
            }

            if (sender == MinusBtn)
            {
                selectedOperator = SelectedOperator.Subtraction;
                description = typeof(SelectedOperator).GetField(SelectedOperator.Subtraction.ToString())?
                              .GetCustomAttribute<DescriptionAttribute>()?.Description;
            }

            if (sender == MulBtn)
            {
                selectedOperator = SelectedOperator.Multiplication;
                description = typeof(SelectedOperator).GetField(SelectedOperator.Multiplication.ToString())?
                              .GetCustomAttribute<DescriptionAttribute>()?.Description;
            }

            if (sender == DivBtn)
            {
                selectedOperator = SelectedOperator.Divide;
                description = typeof(SelectedOperator).GetField(SelectedOperator.Divide.ToString())?
                              .GetCustomAttribute<DescriptionAttribute>()?.Description;
            }
            dataLable.Content = $"{lastnumber}{description}";
        }
        #endregion
    }
}
