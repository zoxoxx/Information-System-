
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
    public class UserFromDb
    {
        public User GetUser(string login, string password)
        {
            User user = null;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr))
                {
                    connect.Open();

                    string sqlExp = "SELECT * from check_users(@Login)";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connect);
                    cmd.Parameters.AddWithValue("Login", login);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    if (reader.HasRows)
                    {
                        reader.Read();
                        if (password != "")
                        {
                            if (password == (string)reader["password_"])
                            {
                                DateTime Birthday = DateTime.Now;
                                if (!(reader[8] is DBNull))
                                {
                                    Birthday = Convert.ToDateTime(reader[8]);
                                }
                                user = new User((int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), 
                                    reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), (int)reader[7], Birthday);
                            }
                            else
                            {
                                MessageBox.Show("Неверный пароль");
                            }
                        }
                    }
                    return user;
                }
            }
            catch (NpgsqlException ex)
            { MessageBox.Show(ex.Message); return user; }
        }


       public   User UpdateInfo(int user_id)
        {
            User user = null;
            try
            {
                using (NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr))
                {
                    connect.Open();

                    string sqlExp = "SELECT * from update_info_user(@user_id)";
                    NpgsqlCommand cmd = new NpgsqlCommand(sqlExp, connect);
                    cmd.Parameters.AddWithValue("user_id", user_id);
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();


                        user = new User((int)reader[0], reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[5].ToString(), reader[6].ToString(), (int)reader[7], (DateTime)reader[8]);

                    }
                    else
                    {
                        MessageBox.Show("Нет такого пользователя");
                    }



                    return user;
                }
            }
            catch (NpgsqlException ex)
            { MessageBox.Show(ex.Message); return user; }
        }

    

    public static void updateUser(int useridd, string emaill, string photoo, string surnamee, string namee, string patronymicc)
        {
            NpgsqlConnection connect = new NpgsqlConnection(DbConnection.connectionStr);
            try
            {
                connect.Open();
                string sqlExp = "call update_Sotr(@useridd, @emaill, @photoo, @surnamee, @namee, @patronymicc)";
                NpgsqlCommand cmd1 = new NpgsqlCommand(sqlExp, connect);
                cmd1.Parameters.AddWithValue("useridd", useridd);
                cmd1.Parameters.AddWithValue("emaill", emaill);
                cmd1.Parameters.AddWithValue("photoo", photoo);
                cmd1.Parameters.AddWithValue("surnamee", surnamee);
                cmd1.Parameters.AddWithValue("namee", namee);
                cmd1.Parameters.AddWithValue("patronymicc", patronymicc);
                int i = cmd1.ExecuteNonQuery();


            }
            catch (NpgsqlException ex)
            { MessageBox.Show("Ошибка записи: " + ex.Message); return; }
            connect.Close();
        }

    }
}
