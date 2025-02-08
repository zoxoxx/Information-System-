using Kursovik.Classes;
using Npgsql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Kursovik.Model
{
    public class DocumentFromDb
    {
        public static List<Document> getPrivacyDocs()
        {
            List<Document> privDoc = new List<Document>();
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "SELECT * from get_privacyDocs()";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        privDoc.Add(new Document((int)reader[0], reader[1].ToString(), (int)reader[2], (int)reader[3], (DateTime)reader[4], reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), (int)reader[8], reader[9].ToString(), reader[10].ToString()));
                    }
                }
                reader.Close();
                return privDoc;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return privDoc;
            }
            finally
            {
                connection.Close();
            }
        }

        public static Document getDoc(int documentidd)
        {
            Document document = null;
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "SELECT * from searchDocs(@documentidd)";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                command.Parameters.AddWithValue("documentidd", documentidd);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        document = new Document((int)reader[0], reader[1].ToString(), (int)reader[2], (int)reader[3], (DateTime)reader[4], reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), (int)reader[8], reader[9].ToString(), reader[10].ToString());
                    }
                }
                reader.Close();
                return document;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return document;
            }
            finally
            {
                connection.Close();
            }
        }



        public static List<Document> getPublicDocs()
        {
            List<Document> privDoc = new List<Document>();
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "SELECT * from get_publicDocs()";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        privDoc.Add(new Document((int)reader[0], reader[1].ToString(), (int)reader[2], (int)reader[3], (DateTime)reader[4], reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), (int)reader[8], reader[9].ToString(), reader[10].ToString()));
                    }
                }
                reader.Close();
                return privDoc;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return privDoc;
            }
            finally
            {
                connection.Close();
            }
        }


        public static List<Document> getAllDocs()
        {
            List<Document> privDoc = new List<Document>();
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "SELECT * from get_AllDocs()";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        privDoc.Add(new Document((int)reader[0], reader[1].ToString(), (int)reader[2], (int)reader[3], (DateTime)reader[4], reader[5].ToString(), reader[6].ToString(), reader[7].ToString(), (int)reader[8], reader[9].ToString(), reader[10].ToString()));
                    }
                }
                reader.Close();
                return privDoc;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return privDoc;
            }
            finally
            {
                connection.Close();
            }
        }

        public static void DocumentAdd(int typeidd, int bookshell_numberr, int row_numberr, DateTime create_datetimee, string creatorr, string filepathh, int categoryidd, int privacyidd, int availabilityidd, string namee)
        {
            NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connect.Open();
                string sqlExp = "call newDocument(@typeidd, @bookshell_numberr, @row_numberr, @create_datetimee, @creatorr, @filepathh, @categoryidd, @privacyidd, @availabilityidd, @namee)";
                NpgsqlCommand cmd1 = new NpgsqlCommand(sqlExp, connect);
                cmd1.Parameters.AddWithValue("typeidd", typeidd);
                cmd1.Parameters.AddWithValue("bookshell_numberr", bookshell_numberr);
                cmd1.Parameters.AddWithValue("row_numberr", row_numberr);
                cmd1.Parameters.AddWithValue("create_datetimee", create_datetimee);
                cmd1.Parameters.AddWithValue("creatorr", creatorr);
                cmd1.Parameters.AddWithValue("filepathh", filepathh);
                cmd1.Parameters.AddWithValue("categoryidd", categoryidd);
                cmd1.Parameters.AddWithValue("privacyidd", privacyidd);
                cmd1.Parameters.AddWithValue("availabilityidd", availabilityidd);
                cmd1.Parameters.AddWithValue("namee", namee);
                int i = cmd1.ExecuteNonQuery();


            }
            catch (NpgsqlException ex)
            { MessageBox.Show("Ошибка добавления документа: " + ex.Message); return; }
            connect.Close();
        }


        public static void DocumentChange(int document_id, int typeidd, int bookshell_numberr, int row_numberr, DateTime create_datetimee, string creatorr, string filepathh, int categoryidd, int privacyidd, int availabilityidd, string namee)
        {
            NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connect.Open();
                string sqlExp = "call changeDocument(@document_id, @typeidd, @bookshell_numberr, @row_numberr, @create_datetimee, @creatorr, @filepathh, @categoryidd, @privacyidd, @availabilityidd, @namee)";
                NpgsqlCommand cmd1 = new NpgsqlCommand(sqlExp, connect);
                cmd1.Parameters.AddWithValue("document_id", document_id);
                cmd1.Parameters.AddWithValue("typeidd", typeidd);
                cmd1.Parameters.AddWithValue("bookshell_numberr", bookshell_numberr);
                cmd1.Parameters.AddWithValue("row_numberr", row_numberr);
                cmd1.Parameters.AddWithValue("create_datetimee", create_datetimee);
                cmd1.Parameters.AddWithValue("creatorr", creatorr);
                cmd1.Parameters.AddWithValue("filepathh", filepathh);
                cmd1.Parameters.AddWithValue("categoryidd", categoryidd);
                cmd1.Parameters.AddWithValue("privacyidd", privacyidd);
                cmd1.Parameters.AddWithValue("availabilityidd", availabilityidd);
                cmd1.Parameters.AddWithValue("namee", namee);
                int i = cmd1.ExecuteNonQuery();


            }
            catch (NpgsqlException ex)
            { MessageBox.Show("Ошибка добавления документа: " + ex.Message); return; }
            connect.Close();
        }



        public static void DeleteDocument(int document_id)
        {
            NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connect.Open();
                string sqlExp = "select deleteDocument(@document_id)";
                NpgsqlCommand cmd1 = new NpgsqlCommand(sqlExp, connect);
                cmd1.Parameters.AddWithValue("document_id", document_id);
                int i = cmd1.ExecuteNonQuery();


            }
            catch (NpgsqlException ex)
            { MessageBox.Show("Ошибка удаления документа: " + ex.Message); return; }
            connect.Close();
        }


    }
}


