using Kursovik.Classes;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kursovik.Model
{
    public class ClientFromDb
    {
        public Client GetClient(string login, string password)
        {
            Client client = null;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr))
                {
                    connect.Open();

                    string sqlExp = "SELECT * from check_clients(@Login)";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connect);
                    cmd.Parameters.AddWithValue("Login", login);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        if (password != "")
                        {
                            if (password == (string)reader["password"])
                            {            
                                client = new Client((int)reader[0], (int)reader[1], reader[2].ToString(), reader[3].ToString());
                            }
                            else
                            {
                                MessageBox.Show("Неверный пароль");
                            }

                        }
                    }
                    else
                    {
                        MessageBox.Show("Нет такого пользователя");
                    }
                    return client;
                }
            }
            catch (NpgsqlException ex)
            { MessageBox.Show(ex.Message); return client; }
        }

        public List<Client> getAllClients()
        {
            List<Client> clients = new List<Client>();
            NpgsqlConnection connection = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connection.Open();
                string sqlExp = "SELECT * from get_clients()";
                NpgsqlCommand command = new NpgsqlCommand(sqlExp, connection);
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


        public static void ClientDelete(int client_id)
        {
            NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connect.Open();
                string sqlExp = "call delete_client(@client_id)";
                NpgsqlCommand cmd1 = new NpgsqlCommand(sqlExp, connect);
                cmd1.Parameters.AddWithValue("client_id", client_id);
                int i = cmd1.ExecuteNonQuery();
                MessageBox.Show("Клиент был удален");
                
            }
            catch (NpgsqlException ex)
            { MessageBox.Show("Ошибка записи: " + ex.Message); return; }
            connect.Close();
        }

        public void ClientAdd(int type, string phone, string email, string pasword)
        {
            NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connect.Open();
                string sqlExp = "call registration_client(@typeId, @phonee, @emaill, @pasword)";
                NpgsqlCommand cmd1 = new NpgsqlCommand(sqlExp, connect);
                cmd1.Parameters.AddWithValue("phonee", phone);
                cmd1.Parameters.AddWithValue("pasword", pasword);
                cmd1.Parameters.AddWithValue("emaill", email);
                cmd1.Parameters.AddWithValue("typeId", type);
                int i = cmd1.ExecuteNonQuery();


            }
            catch (NpgsqlException ex)
            { MessageBox.Show("Ошибка записи: " + ex.Message); return; }
            connect.Close();
        }



        public void PhysAdd(string passport,string datePassport, string surnamee, string namee, string patronymicc, string adres, int clientId)
        {
            NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connect.Open();

                // DateTime dateObject = DateTime.ParseExact(datePassport, "yyyy-MM-dd", CultureInfo.InvariantCulture);
                //DateTime.TryParse(datePassport, out DateTime date);
                DateTime date;
                DateTime.TryParseExact(datePassport, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out date);


                 string sqlExp = "call registration_phys(@passport, @datePassport, @surnamee, @namee, @patronymicc, @adres, @clientId)";
                NpgsqlCommand cmd1 = new NpgsqlCommand(sqlExp, connect);
                cmd1.Parameters.AddWithValue("passport", passport);
                cmd1.Parameters.AddWithValue("datePassport", NpgsqlTypes.NpgsqlDbType.Date).Value = date.Date;
                cmd1.Parameters.AddWithValue("surnamee", surnamee);
                cmd1.Parameters.AddWithValue("namee", namee);
                cmd1.Parameters.AddWithValue("patronymicc", patronymicc);
                cmd1.Parameters.AddWithValue("adres", adres);
                cmd1.Parameters.AddWithValue("clientId", clientId);
                int i = cmd1.ExecuteNonQuery();
                 MessageBox.Show("Вы успешно зарегистрированы "); 
                
            }
            catch (NpgsqlException ex)
            { MessageBox.Show("Ошибка записи: " + ex.Message); return; }
            connect.Close();
        }


        public void UrAdd(string nameCompany, string companyAdress, int clientId)
        {
            NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connect.Open();



                string sqlExp = "call registration_urid(@nameCompany, @companyAdress, @clientId)";
                NpgsqlCommand cmd1 = new NpgsqlCommand(sqlExp, connect);
                cmd1.Parameters.AddWithValue("nameCompany", nameCompany);
                cmd1.Parameters.AddWithValue("companyAdress", companyAdress);
                cmd1.Parameters.AddWithValue("clientId", clientId);
                int i = cmd1.ExecuteNonQuery();
                MessageBox.Show("Вы успешно зарегистрированы "); 
                
            }
            catch (NpgsqlException ex)
            { MessageBox.Show("Ошибка записи: " + ex.Message); return; }
            connect.Close();
        }

        public Physical_Client GetPhysClient(int id)
        {
            Physical_Client client = null;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr))
                {
                    connect.Open();

                    string sqlExp = "SELECT * from check_phys_clients(@id_client)";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connect);
                    cmd.Parameters.AddWithValue("id_client", id);
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();


                        client = new Physical_Client(reader[0].ToString(), (DateTime)reader[1], reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), (int)reader[6], (int)reader[7]);

                    }
                    else
                    {
                        
                    }



                    return client;
                }
            }
            catch (NpgsqlException ex)
            { MessageBox.Show(ex.Message); return client; }
        }

        public Uridich_Client GetUrClient(int id)
        {
            Uridich_Client client = null;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr))
                {
                    connect.Open();

                    string sqlExp = "SELECT * from check_urid_clients(@id_client)";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connect);
                    cmd.Parameters.AddWithValue("id_client", id);
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();


                        client = new Uridich_Client(reader[0].ToString(), reader[1].ToString(), (int)reader[2], (int)reader[3]);

                    }
                    else
                    {
                       
                    }



                    return client;
                }
            }
            catch (NpgsqlException ex)
            { MessageBox.Show(ex.Message); return client; }
        }

        public static void UpdateUrClient(string nameCompany, string companyAdress, int clientId)
        {
            
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr))
                {
                    connect.Open();

                    string sqlExp = "call update_urid(@nameCompany, @companyAdress, @clientId)";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connect);
                    cmd.Parameters.AddWithValue("nameCompany", nameCompany);
                    cmd.Parameters.AddWithValue("companyAdress", companyAdress);
                    cmd.Parameters.AddWithValue("clientId", clientId);
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    


                    
                }
            }
            catch (NpgsqlException ex)
            { MessageBox.Show(ex.Message); }
        }



        public static void UpdatePhysClient(string pasport, DateTime datePassport, string surnamee, string namee, string patronymicc, string adres, int clientId)
        {

            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr))
                {
                    connect.Open();

                    string sqlExp = "call update_phys(@pasport, @datePassport, @surnamee, @namee, @patronymicc, @adres, @clientId)";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connect);
                    cmd.Parameters.AddWithValue("pasport", pasport);
                    cmd.Parameters.AddWithValue("datePassport", datePassport);
                    cmd.Parameters.AddWithValue("surnamee", surnamee);
                    cmd.Parameters.AddWithValue("namee", namee);
                    cmd.Parameters.AddWithValue("patronymicc", patronymicc);
                    cmd.Parameters.AddWithValue("adres", adres);
                    cmd.Parameters.AddWithValue("clientId", clientId);
                    NpgsqlDataReader reader = cmd.ExecuteReader();





                }
            }
            catch (NpgsqlException ex)
            { MessageBox.Show(ex.Message); }
        }



    }

}


    


