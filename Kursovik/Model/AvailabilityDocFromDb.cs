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
    public class AvailabilityDocFromDb
    {
        public static List<availability> getavailabilityDocs()
        {
            List<availability> availabilities = new List<availability>();
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "SELECT * from get_availabilityDoc()";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        availabilities.Add(new availability((int)reader[0], reader[1].ToString()));
                    }
                }
                reader.Close();
                return availabilities;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return availabilities;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
