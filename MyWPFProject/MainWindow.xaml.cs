using MyWPFProject.Model;
using System.Collections.Generic;
using System.Windows;

namespace MyWPFProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            datagridApps.ItemsSource = new List<Customers>()
            {
                new()
                {
                    Name = "Ahmet",
                    Surname = "Yıldız",
                    Email = "ahmetyildiz@xyz.com",
                    Phone = "0905325323232"
                },
                new()
                {
                    Name = "Mehmet",
                    Surname = "Öz",
                    Email = "mehmetoz@qwe.com",
                    Phone = "0905325323232"
                }
            };
        }
        private void btnFilter_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Filter button event is run!");
        }
    }
}
