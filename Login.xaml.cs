using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Shapes;

namespace ProjektZalWPF
{
    public partial class Login : Window
    {

        public Login()
        {
            InitializeComponent();
            MyDatabaseHelper db = new MyDatabaseHelper();
        }

        private void btnZaloguj_Click(object sender, RoutedEventArgs e)
        {
            bool bl = MyDatabaseHelper.login(this.txtNazwa.Text, this.txtHaslo.Password);
            if (bl == true)
            {
                MessageBox.Show("Zalogowano poprawnie! :)");
                MainWindow glownyEkran = new MainWindow();
                glownyEkran.Show();
                this.Close();
            }
        }
    }
}
