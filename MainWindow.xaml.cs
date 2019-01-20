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

namespace ProjektZalWPF
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Main.Content = new PageFilm();
        }

        private void btnPomoc_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show()
            MessageBox.Show("Jeżeli potrzebujesz pomocy, skontaktuj się z nami mailowo! \n\n\n aaa@aaa.aa", "Pomoc");
        }

        private void btnDodaj_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new PageAdd();
        }

        private void btnEdytuj_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new PageEdit();
        }

        private void btnUsun_Click(object sender, RoutedEventArgs e)
        {
            Main.Content = new PageDel();
        }
    }
}
