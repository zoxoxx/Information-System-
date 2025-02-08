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
    public class TypeClientFromDb
    {
        public static List<typeClient> getAlltypes()
        {
            List<typeClient> types = new List<typeClient>();
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "SELECT * from get_typesClients()";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        types.Add(new typeClient((int)reader[0], reader[1].ToString()));
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

        public static List<Client> FiltrClientsByType(int type_id)
        {
            List<Client> clients = new List<Client>();
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "SELECT * from get_ClientsByType(@type_id)";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
                command.Parameters.AddWithValue("@type_id", type_id);
                NpgsqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        clients.Add(new Client((int)reader[0], (int)reader[1], reader[2].ToString(), reader[3].ToString()));
                    }
                }
                reader.Close();
                return clients;
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show(ex.Message);
                return clients;
            }
            finally
            {
                connection.Close();
            }
        }

    }
}
