using Kursovik.Classes;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovik.Model
{
    public class CategoryDocFromDb
    {
        public static List<document_category> getcategoryDocs()
        {
            List<document_category> categories = new List<document_category>();
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "SELECT * from get_categoryDoc()";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        categories.Add(new document_category((int)reader[0], reader[1].ToString(), reader[2].ToString()));
                    }
                }
                reader.Close();
                return categories;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return categories;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void CategoryChange(int category_id, string categoryname, string descriptioncategory)
        {
            NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connect.Open();
                string sqlExp = "call update_category(@category_id, @categoryname, @descriptioncategory)";
                NpgsqlCommand cmd1 = new NpgsqlCommand(sqlExp, connect);
                cmd1.Parameters.AddWithValue("category_id", category_id);
                cmd1.Parameters.AddWithValue("categoryname", categoryname);
                cmd1.Parameters.AddWithValue("descriptioncategory", descriptioncategory);
                int i = cmd1.ExecuteNonQuery();


            }
            catch (NpgsqlException ex)
            { MessageBox.Show("Ошибка добавления документа: " + ex.Message); return; }
            finally
            {
                MessageBox.Show("Категория успешно обновлена");
            }
            connect.Close();
        }

        public static void CategoryDelete(int category_id)
        {
            NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connect.Open();
                string sqlExp = "call delete_category(@category_id)";
                NpgsqlCommand cmd1 = new NpgsqlCommand(sqlExp, connect);
                cmd1.Parameters.AddWithValue("category_id", category_id);
                int i = cmd1.ExecuteNonQuery();


            }
            catch (NpgsqlException ex)
            { MessageBox.Show("Ошибка добавления документа: " + ex.Message); return; }
            finally
            {
                MessageBox.Show("Категория успешно удалена");
            }
            connect.Close();
        }

        public static void CategoryAdd(string categoryname, string descriptioncategory)
        {
            NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connect.Open();
                string sqlExp = "call add_category(@category_id, @categoryname, @descriptioncategory)";
                NpgsqlCommand cmd1 = new NpgsqlCommand(sqlExp, connect);
                cmd1.Parameters.AddWithValue("categoryname", categoryname);
                cmd1.Parameters.AddWithValue("descriptioncategory", descriptioncategory);
                int i = cmd1.ExecuteNonQuery();


            }
            catch (NpgsqlException ex)
            { MessageBox.Show("Ошибка добавления документа: " + ex.Message); return; }
            finally
            {
                MessageBox.Show("Категория успешно добавлена");
            }
            connect.Close();
        }

    }
}
