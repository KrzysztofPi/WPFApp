using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ProjektZalWPF
{
    class MyDatabaseHelper
    {
        static SqlConnection sqlCon = new SqlConnection("Data Source=.; Initial Catalog=PrzepisyGry; Integrated Security=True;");

        public static bool login(string username, string pass)
        {
            try
            {
                sqlCon.Open();
                String query = "SELECT COUNT(1) FROM Users WHERE Username=@Username AND Password=@Password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.Parameters.AddWithValue("@Username", username);
                sqlCmd.Parameters.AddWithValue("@Password", pass);
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if (count == 1)
                {
                    return true;
                }
                else return false;
            }
            catch
            {
                MessageBox.Show("Nazwa lub hasło niepoprawne!");
                return false;
            }
        }

        public static void addArticle(string tytArt, string zawArt, string przepisyGry)
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }
            try
            {
                sqlCon.Close();
            }
            catch { }
            try
            {
                SqlCommand sqlCmd = new SqlCommand("addArticle", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add(new SqlParameter("@nazwaArt", tytArt));
                sqlCmd.Parameters.Add(new SqlParameter("@trescArt", zawArt));
                sqlCmd.Parameters.Add(new SqlParameter("@nazwaTabeli", przepisyGry));
                sqlCon.Open();
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Dodano poprawnie! :)");
            }
            catch (Exception e)
            {
                MessageBox.Show("Wystąpił błąd przy dodawaniu danych \n\n\n\n" + e, "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            sqlCon.Close();
        }

        public static List <string> seeArticle(string tytArt, string przepisyGry)
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }

            var seeArt = new List<string>();
            try
            {

                SqlCommand sqlCmd = new SqlCommand("seeArticle", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add(new SqlParameter("@nazwaArt", tytArt));
                sqlCmd.Parameters.Add(new SqlParameter("@nazwaTabeli", przepisyGry));
                sqlCon.Open();
                IDataReader result = sqlCmd.ExecuteReader();
                
                while (result.Read())
                {
                    seeArt.Add(result[2].ToString());
                }
            }
            catch
            {
                MessageBox.Show("Wystąpił błąd przy pobieraniu danych", "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            sqlCon.Close();
            return seeArt;
        }

        public static List<string> seeArtList(string przepisyGry)
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }

            var artList = new List<string>();
            try
            {
                SqlCommand sqlCmd = new SqlCommand("getArticleList", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add(new SqlParameter("@nazwaTabeli", przepisyGry));
                sqlCon.Open();
                IDataReader result = sqlCmd.ExecuteReader();
                
                while (result.Read())
                {
                    artList.Add(result[0].ToString());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Wystąpił błąd przy pobieraniu listy artykułów \n\n\n\n" + e.ToString(), "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            sqlCon.Close();
            return artList;
        }

        public static void delArticle (string tytArt, string przepisyGry)
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }

            try
            {
                SqlCommand sqlCmd = new SqlCommand("deleteArticle", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add(new SqlParameter("@nazwaArt", tytArt));
                sqlCmd.Parameters.Add(new SqlParameter("@nazwaTabeli", przepisyGry));
                sqlCon.Open();
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Usunięto poprawnie! :)");
            }
            catch (Exception e)
            {
                MessageBox.Show("Wystąpił błąd przy usuwaniu danych \n\n\n\n" + e, "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            sqlCon.Close();
        }

        public static void editArticle (string tytArt, string zawArt, string przepisyGry)
        {
            if (sqlCon.State == ConnectionState.Open)
            {
                sqlCon.Close();
            }

            try
            {
                SqlCommand sqlCmd = new SqlCommand("editArticle", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.Add(new SqlParameter("@nazwaArt", tytArt));
                sqlCmd.Parameters.Add(new SqlParameter("@trescArt", zawArt));
                sqlCmd.Parameters.Add(new SqlParameter("@nazwaTabeli", przepisyGry));
                sqlCon.Open();
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Zaktualizowano poprawnie! :)");
            }
            catch (Exception e)
            {
                MessageBox.Show("Wystąpił błąd przy edytowniu danych \n\n\n\n" + e, "Błąd", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            sqlCon.Close();
        }
    }
}
