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

namespace SewingFactory
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            SewingFactory.WSRSewingFactoryDataSet wSRSewingFactoryDataSet = ((SewingFactory.WSRSewingFactoryDataSet)(this.FindResource("wSRSewingFactoryDataSet")));
            // Load data into the table User. You can modify this code as needed.
            SewingFactory.WSRSewingFactoryDataSetTableAdapters.UserTableAdapter wSRSewingFactoryDataSetUserTableAdapter = new SewingFactory.WSRSewingFactoryDataSetTableAdapters.UserTableAdapter();

          string role=  wSRSewingFactoryDataSetUserTableAdapter.AuthQuery(Login.Text,Password.Text) ;
            
            if(role.Remove(8)=="Director")
            {
                Director dir = new Director();
                dir.Show();
                this.Close();
            }
            if (role.Remove(7) == "Manager")
            {
                Managers dir = new Managers();
                dir.Show();
                this.Close();
            }
            if (role.Remove(8) == "Storager")
            {
                Storagers dir = new Storagers();
                dir.Show();
                this.Close();
            }
            if (role.Remove(7) == "Orderer")
            {
                Orderers dir = new Orderers();
                dir.Show();
                this.Close();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

           
        }
    }
}
