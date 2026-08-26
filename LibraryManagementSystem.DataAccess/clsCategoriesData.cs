using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Xml.Linq;

namespace LibraryManagementSystem.DataAccess
{
    public class clsCategoriesData
    {
        public static DataTable GetAllCategories()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Categories";
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
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }


            return dt;

        }

        public static bool GetCategoryByID(int CategoryID, ref string Name)
        {
            bool isfound = false;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Categories where CategoryID = @CategoryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryID", CategoryID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isfound = true;
                    Name = reader["Name"].ToString();


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


        public static bool AddCategory(string Name)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO Categories (Name) VALUES (@Name)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Name", Name);
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
        public static bool DeleteCategory(int CategoryID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "delete from Categories where CategoryID=@CategoryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryID", CategoryID);


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
        public static bool UpdateCategory(int CategoryID, string Name)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "update Categories set Name=@Name where CategoryID=@CategoryID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CategoryID", CategoryID);
            command.Parameters.AddWithValue("@Name", Name);

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



    }
}