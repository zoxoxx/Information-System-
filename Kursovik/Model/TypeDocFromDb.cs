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
    public class TypeDocFromDb
    {
        public static List<type_document> gettypeDocs()
        {
            List<type_document> types = new List<type_document>();
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "SELECT * from get_typeDoc()";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        types.Add(new type_document((int)reader[0], reader[1].ToString()));
                    }
                }
                reader.Close();
                return types;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return types;
            }
            finally
            {
                connection.Close();
            }
        }


        public static List<Document> FiltrDocsByAvailability (int avail_id)
        {
            List<Document> documents = new List<Document>();
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "SELECT * from get_DocsByAvail(@avail_id)";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                command.Parameters.AddWithValue("avail_id", avail_id);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        documents.Add(new Document((int)reader[0], reader[1].ToString(), (int)reader[2], (int)reader[3], (DateTime)reader[4], reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), (int)reader[8], reader[9].ToString(), reader[10].ToString()));
                    }
                }
                reader.Close();
                return documents;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return documents;
            }
            finally
            {
                connection.Close();
            }
        }


        public static List<Document> FiltrDocsByCategory(int category_id)
        {
            List<Document> documents = new List<Document>();
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "SELECT * from get_DocsByCategory(@category_id)";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                command.Parameters.AddWithValue("category_id", category_id);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        documents.Add(new Document((int)reader[0], reader[1].ToString(), (int)reader[2], (int)reader[3], (DateTime)reader[4], reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), (int)reader[8], reader[9].ToString(), reader[10].ToString()));
                    }
                }
                reader.Close();
                return documents;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return documents;
            }
            finally
            {
                connection.Close();
            }
        }


        public static List<Document> FiltrDocsByCategoryAndAvail(int category_id, int avail_id)
        {
            List<Document> documents = new List<Document>();
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "SELECT * from get_DocsByCategoryAndAvail(@category_id, @avail_id)";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                command.Parameters.AddWithValue("category_id", category_id);
                command.Parameters.AddWithValue("avail_id", avail_id);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        documents.Add(new Document((int)reader[0], reader[1].ToString(), (int)reader[2], (int)reader[3], (DateTime)reader[4], reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), (int)reader[8], reader[9].ToString(), reader[10].ToString()));
                    }
                }
                reader.Close();
                return documents;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return documents;
            }
            finally
            {
                connection.Close();
            }
        }


    }
}
