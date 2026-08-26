using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.DataAccess
{
    public class clsMembersData
    {
        public static DataTable GetAllMembers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select * from Members";
            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                connection.Close();
            }


            return dt;
        }





        public static bool GetMemberByID(int MemberID, ref string FirstName, ref string LastName, ref string Phone, ref string Email, ref string Address)
        {
            bool isfound = false;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Members where MemberID = @MemberID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MemberID", MemberID);
           

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isfound = true;
                   
                    FirstName = reader["FirstName"].ToString();
                    LastName = reader["LastName"].ToString();
                    Phone = reader["Phone"].ToString();
                    Email =  reader["Email"].ToString();
                    Address = reader["Address"].ToString();


                }
                else
                {
                    isfound = false;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return isfound;

        }


        public static bool AddMember( string FirstName,  string LastName,  string Phone,  string Email,  string Address)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO Members ( FirstName, LastName, Phone,  Email,  Address)" +
                " VALUES (@FirstName,@LastName,@Phone,@Email,@Address)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Address", Address);
         




            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
            return rowsAffected > 0;
        }


        public static bool UpdateMember(int MemberID,string FirstName, string LastName, string Phone, string Email, string Address)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "update Members set FirstName=@FirstName,LastName=@LastName,Phone=@Phone,Email=@Email,Address=@Address" +
                " where MemberID=@MemberID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Address", Address);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
            finally
            {
                connection.Close();
            }
            return rowsAffected > 0;

        }


        public static bool DeleteMember(int MemberID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "delete from Members where MemberID=@MemberID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@MemberID", MemberID);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }
            finally
            {
                connection.Close();
            }
            return rowsAffected > 0;

        }
    }
}
