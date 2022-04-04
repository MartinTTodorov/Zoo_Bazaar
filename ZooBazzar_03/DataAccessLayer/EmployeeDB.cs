using Entities;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccessLayer
{
    public class EmployeeDB : ICRUD<Employee>
    {
        private string con = "Server=studmysql01.fhict.local;Uid=dbi481796;Database=dbi481796;Pwd=sql7915;";
        public void Add(int accountid,Employee obj)
        {
            string sql = "INSERT INTO employee (ID,FirstName,LastName,Address,Birthdate,Phone,Email,EmergencyContact,BSN,WorkPosition) VALUES (@ID,@FirstName,@LastName,@Address,@Birthdate,@Phone,@Email,@EmergencyContact,@BSN,@WorkPosition)";
            MySqlConnection conn = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = accountid;
            cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = obj.Name;
            cmd.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = obj.Lastname;
            cmd.Parameters.Add("@Address", MySqlDbType.VarChar).Value = obj.Address;
            cmd.Parameters.Add("@BirthDate", MySqlDbType.DateTime).Value = obj.Birthdate;
            cmd.Parameters.Add("@Phone", MySqlDbType.VarChar).Value = obj.Phone;
            cmd.Parameters.Add("@EmergencyContact", MySqlDbType.VarChar).Value = obj.EmargencyContact;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = obj.Email;
            cmd.Parameters.Add("@BSN", MySqlDbType.VarChar).Value = obj.Bsn;
            cmd.Parameters.Add("@WorkPosition", MySqlDbType.VarChar).Value = obj.GetWorkingPosition();            

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Employee is not inserted! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        public void Add(Employee obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            string sql = "DELETE FROM employee WHERE ID = @ID";
            MySqlConnection conn = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@ID", MySqlDbType.Int32).Value = id;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee deleted successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Can't delete employee{id}! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }
        }

        public List<Employee> Read()
        {
            string sql = "SELECT username,password,firstname,lastname,address,birthdate,email,phone,emergencycontact,bsn,workposition,id FROM employee INNER JOIN account ON employee.ID = account.AccountID";
            List<Employee> employees = new List<Employee>();
            MySqlConnection conn = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand(sql, conn);

            try
            {
                conn.Open();
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    if(reader[10].ToString() == "Manager")
                    {
                        Manager manager = new Manager(new Account(reader[0].ToString(), reader[1].ToString()), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), Convert.ToDateTime(reader[5]), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString());
                        manager.Id = Convert.ToInt32(reader[11]);
                        employees.Add(manager);
                    }
                    else if(reader[10].ToString() == "Resourceplanner")
                    {
                        ResourcePlanner resourcePlanner = new ResourcePlanner(new Account(reader[0].ToString(), reader[1].ToString()), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), Convert.ToDateTime(reader[5]), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString());
                        resourcePlanner.Id = Convert.ToInt32(reader[11]);
                        employees.Add(resourcePlanner);
                    }
                    else
                    {
                        Specialization specialization = (Specialization)Enum.Parse(typeof(Specialization), reader[10].ToString(), true);
                        Caretaker caretaker = new Caretaker(new Account(reader[0].ToString(), reader[1].ToString()), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), Convert.ToDateTime(reader[5]), reader[6].ToString(), reader[7].ToString(), reader[8].ToString(), reader[9].ToString(),specialization);
                        caretaker.Id = Convert.ToInt32(reader[11]);
                        employees.Add((caretaker));
                    }
                   
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

            return employees;
        }

        public void Update(int id, Employee obj)
        {
            string sql = "UPDATE employee SET FirstName = @FirstName,LastName = @Lastname,Address = @Address,Birthdate = @Birthdate,Phone = @Phone,Email = @Email,EmergencyContact = @EmergencyContact,BSN = @BSN,WorkPosition = @WorkingPosition WHERE ID = @ID ";
            MySqlConnection conn = new MySqlConnection(con);
            MySqlCommand cmd = new MySqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("@FirstName", MySqlDbType.VarChar).Value = obj.Name;
            cmd.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = obj.Lastname;
            cmd.Parameters.Add("@Address", MySqlDbType.VarChar).Value = obj.Address;
            cmd.Parameters.Add("@BirthDate", MySqlDbType.DateTime).Value = obj.Birthdate;
            cmd.Parameters.Add("@Phone", MySqlDbType.VarChar).Value = obj.Phone;
            cmd.Parameters.Add("@EmergencyContact", MySqlDbType.VarChar).Value = obj.EmargencyContact;
            cmd.Parameters.Add("@Email", MySqlDbType.VarChar).Value = obj.Email;
            cmd.Parameters.Add("@BSN", MySqlDbType.VarChar).Value = obj.Bsn;
            string workingposition = obj.GetWorkingPosition();
            cmd.Parameters.Add("@WorkingPosition", MySqlDbType.VarChar).Value = workingposition;
            cmd.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (MySqlException ex)
            {

                MessageBox.Show("Employee is not updated! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

        }

       
    }
}
