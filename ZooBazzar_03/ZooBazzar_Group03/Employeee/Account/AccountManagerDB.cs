using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooBazzar_Group03
{
    public class AccountManagerDB : ICRUD<Account>
    {
        private string con = "Server=studmysql01.fhict.local;Uid=dbi481796;Database=dbi481796;Pwd=sql7915;";
        
        public void Add(Account obj)
        {
            string sql = "INSERT INTO account (Username,Password) VALUES (@Username,@Password)";
            MySqlConnection conn = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Username", MySqlDbType.VarChar).Value = obj.Username;
            cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = obj.Password;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Account is not inserted! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Delete(int id)
        {
            string sql = "DELETE FROM account WHERE AccountID = @ID";
            MySqlConnection conn = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Can't delete account{id}! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        public List<Account> Read()
        {
            string sql = "SELECT username,password, AccountID FROM account";
            List<Account> accounts = new List<Account>();
            MySqlConnection conn = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Account account = new Account(reader[0].ToString(), reader[1].ToString());
                    account.Id = Convert.ToInt32(reader[2]);
                    accounts.Add(account);
                }
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Error during reading the data in accounts! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            return accounts;
        }

        public void Update(int id, Account obj)
        {
            string sql = "UPDATE account SET Username = @Username, Password = @Password WHERE AccountID = @ID";
            MySqlConnection conn = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            cmd.Parameters.Add("@Username", MySqlDbType.VarChar).Value = obj.Username;
            cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = obj.Password;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Can't update account{id}! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }
        public void ChangePassword(string username, string password)
        {
            string sql = "UPDATE account SET password = @Password WHERE username = @Username";
            MySqlConnection conn = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = password;
            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account password successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Account password is not updated! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }
    }

}

