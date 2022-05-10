using MySql.Data.MySqlClient;
using System.Data;
using Entities;

namespace DataAccessLayer
{
    public class AccountManagerDB : ICRUD<Account>
    {
        private MySqlConnection conn;

        public AccountManagerDB()
        {
           conn = ConnectionDB.GetConnection();
        }

        public void Add(Account obj)
        {
            string sql = "INSERT INTO account (Username,Password,Salt) VALUES (@Username,@Password,@Salt)";
            MySqlCommand cmd = new MySqlCommand(sql,conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@Username", MySqlDbType.VarChar).Value = obj.Username;
            cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = obj.Password;
            cmd.Parameters.Add("@Salt", MySqlDbType.VarChar).Value = obj.Salt;

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
            string sql = "SELECT username,password,salt,AccountID FROM account INNER JOIN contract On contract.employee_id = account.AccountID WHERE contract.is_valid = true";
            List<Account> accounts = new List<Account>(); 
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Account account = new Account(reader[0].ToString(), reader[1].ToString(),reader[2].ToString(),Convert.ToInt32(reader[3]));                    
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
            string sql = "UPDATE account SET Username = @Username, Password = @Password, Salt = @Salt WHERE AccountID = @ID"; 
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;
            cmd.Parameters.Add("@Username", MySqlDbType.VarChar).Value = obj.Username;
            cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = obj.Password;
            cmd.Parameters.Add("@Salt", MySqlDbType.VarChar).Value = obj.Salt;

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
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Username", MySqlDbType.VarChar).Value = username;
            cmd.Parameters.Add("@Password", MySqlDbType.VarChar).Value = password;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Account password updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public string GetEmployeeWorkPositionByAccount(string username)
        {
            string sql = "SELECT Workposition FROM `employee` INNER JOIN account On employee.ID = account.AccountID WHERE account.Username = @Username"; 
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@Username", MySqlDbType.VarChar).Value = username;
            string result = " ";
            try
            {
                conn.Open();
                result = cmd.ExecuteScalar().ToString();
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Account dosen't have an employee! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
            return result;
        }

        public int GetNextID()
        {
            string sql = "SELECT AUTO_INCREMENT FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_SCHEMA = 'dbi481796' AND TABLE_NAME = 'account';";
            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                conn.Open();              
                return Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch (MySqlException ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
        }
    }

}

