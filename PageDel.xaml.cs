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
    public partial class PageDel : Page
    {
        static string tableName;

        public PageDel()
        {
            InitializeComponent();
            cBoxWhatLaws.SelectedIndex = 0;
            cBoxWhatLaws.IsEnabled = false;
            cBoxJakiePrzepisy.SelectedIndex = 0;
        }

        private void cBoxJakiePrzepisy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cBoxJakiePrzepisy.SelectedIndex != 0)
            {
                cBoxWhatLaws.IsEnabled = true;
                tableName = Helper.WhatLaws(cBoxJakiePrzepisy.SelectedIndex);
                cBoxWhatLaws.Items.Clear();
                cBoxWhatLaws.Items.Add("Wybierz artykuł:");

                for (int i = 0; i < MyDatabaseHelper.seeArtList(tableName).Count; i++)
                {
                    cBoxWhatLaws.Items.Add(MyDatabaseHelper.seeArtList(tableName).ElementAt(i).ToString());
                }
            }
        }

        private void cBoxWhatLaws_SelectionChanged(object sender, SelectionChangedEventArgs e) { }

        private void btnSee_Click(object sender, RoutedEventArgs e)
        {
            tableName = Helper.WhatLaws(cBoxJakiePrzepisy.SelectedIndex);
            lblTrescArt.Content = MyDatabaseHelper.seeArticle(cBoxWhatLaws.Text, tableName).Last().ToString();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            tableName = Helper.WhatLaws(cBoxJakiePrzepisy.SelectedIndex);
            MyDatabaseHelper.delArticle(cBoxWhatLaws.Text, tableName);
            lblTrescArt.Content = "";
            if (MyDatabaseHelper.seeArtList(tableName) == null)
            {
                MessageBox.Show("Brak więcej artykułów w tym dziale.", "Lista pusta", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                cBoxJakiePrzepisy.SelectedIndex = 0;
            }
        }
    }
}
