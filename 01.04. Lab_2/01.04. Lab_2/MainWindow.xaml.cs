using System;
using System.Threading.Tasks;
using System.Windows;

namespace _01._04._Lab_2
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


        }
        private async void btnCalculate_Click_1(object sender, RoutedEventArgs e)
        {
            int number;
            try
            {

                if (int.TryParse(n.Text, out number) && number >= 0)
                {
                    long result = await CalculateFactorialAsync(number);
                    lblResult.Text = $"{number}! = {result}";
                }
                else
                {
                    lblResult.Text = "Please enter the positive integer number!";
                }
            }
            catch (Exception ex)
            {
                lblResult.Text = $"Error: {ex.Message}";
            }
        }

        private Task<long> CalculateFactorialAsync(long number)
        {
            return Task.Run(() =>
            {
                return CalculateFactorial(number);
            });
        }

        private long CalculateFactorial(long number)
        {
            if (number == 0 || number == 1)
                return 1;

            long factorial = 1;
            for (int i = 1; i <= number; i++)
            {
                if (factorial > long.MaxValue / i)
                {
                    throw new OverflowException("The result of calculating is bigger than possible.");
                }
                factorial *= i;
            }
            return factorial;
        }
    }
}