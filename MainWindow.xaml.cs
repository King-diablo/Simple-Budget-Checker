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

namespace WPF02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
        InitializeComponent();

            List<SpendingData> data = new List<SpendingData>();
            SpendingData spendingData = new SpendingData { NameOfExpence = "Food", Amount = 500.00, BudgetForExpence = 1000.00};
            data.Add(spendingData);

            spendingData = new SpendingData { NameOfExpence = "Travel", Amount = 900.00, BudgetForExpence = 10000.00 };
            data.Add(spendingData);

            spendingData = new SpendingData { NameOfExpence = "Utility", Amount = 50000.00, BudgetForExpence = 200000.00 };
            data.Add(spendingData);

            spendingData = new SpendingData { NameOfExpence = "", Amount = 0, BudgetForExpence = 0 };
            data.Add(spendingData);

            DataBox.ItemsSource = data;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(DataBox.SelectedItem != null)
            {
                SpendingData data = DataBox.SelectedItem as SpendingData;
                MessageBox.Show($"You Spent {data.Amount} On {data.NameOfExpence} With A Budget Of {data.BudgetForExpence} You" +
                    $"Have {data.BudgetForExpence - data.Amount} Left");
            }
        }
    }

    public class SpendingData
    {
        public string NameOfExpence { get; set; }

        public double Amount { get; set; }

        public double BudgetForExpence { get; set; }
    }
}
