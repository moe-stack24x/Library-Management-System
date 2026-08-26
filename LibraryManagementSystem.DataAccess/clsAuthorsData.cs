using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Xml.Linq;

namespace LibraryManagementSystem.DataAccess
{
    public class clsAuthorsData
    {
        public static DataTable GetAllAuthors()
        {

            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query= "SELECT * FROM Authors";
            SqlCommand command =new SqlCommand(query, connection);


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

        public static bool GetAuthorByID(int AuthorID, ref string Name)
        {
            bool isfound = false;

           

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query= "SELECT * FROM Authors where AuthorID = @AuthorID";
            SqlCommand command =new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AuthorID", AuthorID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    isfound = true;
                    Name= reader["Name"].ToString();


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


        public static bool AddAuthor(string Name)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query= "INSERT INTO Authors (Name) VALUES (@Name)";
            SqlCommand command =new SqlCommand(query, connection);
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
        public static bool DeleteAuthor(int AuthorID)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "delete from Authors where AuthorID=@AuthorID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AuthorID", AuthorID);


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
        public static bool UpdateAuthor(int AuthorID,string Name)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "update Authors set Name=@Name where AuthorID=@AuthorID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AuthorID", AuthorID);
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