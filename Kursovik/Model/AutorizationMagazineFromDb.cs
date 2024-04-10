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
    public class AutorizationMagazineFromDb
    {
        public static void EntranceAdd(int useridd, DateTime date_time)
        {
            NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connect.Open();
                string sqlExp = "call newAutorisation(@useridd, @date_time)";
                NpgsqlCommand cmd1 = new NpgsqlCommand(sqlExp, connect);
                cmd1.Parameters.AddWithValue("useridd", useridd);
                cmd1.Parameters.AddWithValue("date_time", date_time);
                int i = cmd1.ExecuteNonQuery();


            }
            catch (NpgsqlException ex)
            { MessageBox.Show("Ошибка записи: " + ex.Message); return; }
            connect.Close();
        }


        public static List<Autorization> getEntrances()
        {
            List<Autorization> auto = new List<Autorization>();
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "SELECT * from get_autorizationList()";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        auto.Add(new Autorization((int)reader[0], (DateTime)reader[1], (int)reader[2], reader[3].ToString(), reader[4].ToString(), reader[5].ToString()));
                    }
                }
                reader.Close();
                return auto;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return auto;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
