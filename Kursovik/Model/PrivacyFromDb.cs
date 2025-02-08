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
    public class PrivacyFromDb
    {
        public static List<privacy> getprivacyDocs()
        {
            List<privacy> privacys = new List<privacy>();
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "SELECT * from get_privacyDoc()";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        privacys.Add(new privacy((int)reader[0], reader[1].ToString()));
                    }
                }
                reader.Close();
                return privacys;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return privacys;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
