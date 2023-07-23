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

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Country> people = new List<Country>();
        public MainWindow()
        {
            InitializeComponent();
            people.Add(new Country
            {
                countryName = "Pakistan",
                code = "Pk"
            }
            );
            people.Add(new Country
            {
                countryName = "India",
                code = "Ind"
            }
            );
            people.Add(new Country
            {
                countryName = "United Kingdom",
                code = "UK"
            }
            );


            myComboBox.ItemsSource = people;


        }

        private void submitButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Hello {firstNameText.Text}");

        }

        public class Country
        {
            public string countryName { get; set; }
            public string code { get; set; }

            public string FullName
            {
                get
                {
                    return countryName + " (" + code+")";
                }
            }
        }
    }
}
