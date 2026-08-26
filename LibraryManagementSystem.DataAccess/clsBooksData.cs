using System;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem.DataAccess
{
    public class clsBooksData
    {
        public static DataTable GetAllBooks()
        {
            DataTable dt = new DataTable();

            SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Books";

            SqlCommand command =
                new SqlCommand(query, connection);

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


        public static bool GetBookByID(
            int BookID,
            ref string Title,
            ref int AuthorID,
            ref int CategoryID,
            ref string ISBN,
            ref int PublishYear,
            ref int TotalCopies,
            ref int AvailableCopies)
        {
            bool isfound = false;

            SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
                "SELECT * FROM Books WHERE BookID = @BookID";

            SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookID", BookID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;

                    Title = reader["Title"].ToString();
                    AuthorID = (int)reader["AuthorID"];
                    CategoryID = (int)reader["CategoryID"];
                    ISBN = reader["ISBN"].ToString();
                    PublishYear = (int)reader["PublishYear"];
                    TotalCopies = (int)reader["TotalCopies"];
                    AvailableCopies = (int)reader["AvailableCopies"];
                   
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


        public static bool AddBook(
            string Title,
            int AuthorID,
            int CategoryID,
            string ISBN,
            int PublishYear,
            int TotalCopies,
            int AvailableCopies)
        {
            int rowsAffected = 0;

            SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
                "INSERT INTO Books " +
                "(Title, AuthorID, CategoryID, ISBN, PublishYear, TotalCopies, AvailableCopies) " +
                "VALUES " +
                "(@Title, @AuthorID, @CategoryID, @ISBN, @PublishYear, @TotalCopies, @AvailableCopies)";

            SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@AuthorID", AuthorID);
            command.Parameters.AddWithValue("@CategoryID", CategoryID);
            command.Parameters.AddWithValue("@ISBN", ISBN);
            command.Parameters.AddWithValue("@PublishYear", PublishYear);
            command.Parameters.AddWithValue("@TotalCopies", TotalCopies);
            command.Parameters.AddWithValue("@AvailableCopies", AvailableCopies);
         

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


        public static bool UpdateBook(
            int BookID,
            string Title,
            int AuthorID,
            int CategoryID,
            string ISBN,
            int PublishYear,
            int TotalCopies,
            int AvailableCopies)
          
        {
            int rowsAffected = 0;

            SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
                "UPDATE Books SET " +
                "Title=@Title, " +
                "AuthorID=@AuthorID, " +
                "CategoryID=@CategoryID, " +
                "ISBN=@ISBN, " +
                "PublishYear=@PublishYear, " +
                "TotalCopies=@TotalCopies, " +
                "AvailableCopies=@AvailableCopies " +
                "WHERE BookID=@BookID";

            SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookID", BookID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@AuthorID", AuthorID);
            command.Parameters.AddWithValue("@CategoryID", CategoryID);
            command.Parameters.AddWithValue("@ISBN", ISBN);
            command.Parameters.AddWithValue("@PublishYear", PublishYear);
            command.Parameters.AddWithValue("@TotalCopies", TotalCopies);
            command.Parameters.AddWithValue("@AvailableCopies", AvailableCopies);
         

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


        public static bool DeleteBook(int BookID)
        {
            int rowsAffected = 0;

            SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
                "DELETE FROM Books WHERE BookID=@BookID";

            SqlCommand command =
                new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookID", BookID);

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