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
    public class OrderFromDb
    {
        public static void OrderAdd(int client_id, int user_id, DateTime dateget, int status_id, int document_id)
        {
            NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connect.Open();



                string sqlExp = "call add_order(@client_id, @user_id, @dateget, @status_id, @document_id)";
                NpgsqlCommand cmd1 = new NpgsqlCommand(sqlExp, connect);
                cmd1.Parameters.AddWithValue("client_id", client_id);
                cmd1.Parameters.AddWithValue("user_id", user_id);
                cmd1.Parameters.AddWithValue("dateget", dateget);
                cmd1.Parameters.AddWithValue("status_id", status_id);
                cmd1.Parameters.AddWithValue("document_id", document_id);
                int i = cmd1.ExecuteNonQuery();
                MessageBox.Show("Заказ успешно добавлен");

            }
            catch (NpgsqlException ex)
            { MessageBox.Show("Ошибка записи: " + ex.Message); return; }
            connect.Close();
        }

        public static int GetCounterOrders(int client_id)
        {
            int count;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr))
                {
                    connect.Open();
                    
                    string sqlExp = "SELECT * from check_countOrders(@id_client)";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connect);
                    cmd.Parameters.AddWithValue("id_client", client_id);
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();


                        count = (int)reader[0];
                        return count;

                    }
                   else
                    {
                        MessageBox.Show("Заказов нет");
                        return 0;
                    }



                   
                }
            }
            catch (NpgsqlException ex)
            { MessageBox.Show(ex.Message); return 0; }
        }


        public static List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr))
                {
                    connect.Open();

                    string sqlExp = "SELECT * from get_orders()";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connect);
                    
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                       while( reader.Read())
                        { 


                        orders.Add(new Order((int)reader[0], (int)reader[1], (int)reader[2], (DateTime)reader[3], (int)reader[4], (int)reader[5]));
                        }
                        return orders;

                    }
                    else
                    {
                        MessageBox.Show("Заказов нет");
                        return orders;
                    }




                }
            }
            catch (NpgsqlException ex)
            { MessageBox.Show(ex.Message); return orders; }
        }


    }
}
