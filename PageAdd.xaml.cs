using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
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
    public partial class PageAdd : Page
    {
        string tableName;
        
        public PageAdd()
        {
            InitializeComponent();
            btnAdd.IsEnabled = false;
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtBoxNazwaArt.Text) || String.IsNullOrWhiteSpace(txtBoxZawArt.Text))
            {
                MessageBox.Show("Uzupełnij wszystkie pola!","Błąd!",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            else
            {
                MyDatabaseHelper.addArticle(txtBoxNazwaArt.Text, txtBoxZawArt.Text, tableName);
            }
        }

        private void cBoxRodzajGry_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cBoxRodzajGry.SelectedIndex == 0)
            {
                btnAdd.IsEnabled = false;
            }
            if (cBoxRodzajGry.SelectedIndex != 0)
            {
                btnAdd.IsEnabled = true;
                tableName = Helper.WhatLaws(cBoxRodzajGry.SelectedIndex);
            }
        }
    }
}
