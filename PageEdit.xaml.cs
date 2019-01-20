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
    public partial class PageEdit : Page
    {
        static string tableName;

        public PageEdit()
        {
            InitializeComponent();
        }

        private void cBoxArticleList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cBoxArticleList.SelectedIndex != 0)
            {
                txtTrescArt.IsEnabled = true;
                btnSave.IsEnabled = true;
                btnWyswietl.IsEnabled = true;
            }
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (txtTrescArt.Text.Contains(lblTrescArt.Content.ToString()))
            {
                MessageBox.Show("Brak zmian do zapisania.", "Brak zmian", MessageBoxButton.OK, MessageBoxImage.Hand);
            }
            else
            {
                MyDatabaseHelper.editArticle(cBoxArticleList.Text, txtTrescArt.Text, tableName);
                lblTrescArt.Content = MyDatabaseHelper.seeArticle(cBoxArticleList.Text, tableName).Last().ToString();
            }
        }

        private void cBoxWhatLaws_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cBoxWhatLaws.SelectedIndex != 0)
            {
                cBoxArticleList.IsEnabled = true;
                tableName = Helper.WhatLaws(cBoxWhatLaws.SelectedIndex);
                cBoxArticleList.Items.Clear();
                cBoxArticleList.Items.Add("Wybierz artykuł:");

                for (int i = 0; i < MyDatabaseHelper.seeArtList(tableName).Count; i++)
                {
                    cBoxArticleList.Items.Add(MyDatabaseHelper.seeArtList(tableName).ElementAt(i).ToString());
                }
            }
        }

        private void btnWyswietl_Click(object sender, RoutedEventArgs e)
        {
            tableName = Helper.WhatLaws(cBoxWhatLaws.SelectedIndex);
            txtTrescArt.Text = MyDatabaseHelper.seeArticle(cBoxArticleList.Text, tableName).Last().ToString();
            lblTrescArt.Content = MyDatabaseHelper.seeArticle(cBoxArticleList.Text, tableName).Last().ToString();
        }
    }
}
