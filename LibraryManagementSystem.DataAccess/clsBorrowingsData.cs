using System;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagementSystem.DataAccess
{
    public class clsBorrowingsData
    {
        public static DataTable GetAllBorrowings()
        {
            DataTable dt = new DataTable();

            SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = "SELECT * FROM Borrowings";

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


        public static bool GetBorrowingByID(
            int BorrowingID,
            ref int BookID,
            ref int MemberID,
            ref DateTime BorrowDate,
            ref DateTime? ReturnDate,
            ref string Status)
        {
            bool isfound = false;

            SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
                "SELECT * FROM Borrowings WHERE BorrowingID = @BorrowingID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrowingID", BorrowingID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isfound = true;

                    BookID = (int)reader["BookID"];
                    MemberID = (int)reader["MemberID"];
                    BorrowDate = (DateTime)reader["BorrowDate"];

                    if (reader["ReturnDate"] != DBNull.Value)
                    {
                        ReturnDate = (DateTime)reader["ReturnDate"];
                    }
                    else
                    {
                        ReturnDate = null;
                    }

                    Status = reader["Status"].ToString();
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


        public static bool AddBorrowing(
            int BookID,
            int MemberID,
            DateTime BorrowDate,
            DateTime? ReturnDate,
            string Status)
        {
            int rowsAffected = 0;

            SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
                "INSERT INTO Borrowings " +
                "(BookID, MemberID, BorrowDate, ReturnDate, Status) " +
                "VALUES (@BookID, @MemberID, @BorrowDate, @ReturnDate, @Status)";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BookID", BookID);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@BorrowDate", BorrowDate);

            if (ReturnDate.HasValue)
                command.Parameters.AddWithValue("@ReturnDate", ReturnDate.Value);
            else
                command.Parameters.AddWithValue("@ReturnDate", DBNull.Value);

            command.Parameters.AddWithValue("@Status", Status);

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


        public static bool UpdateBorrowing(
            int BorrowingID,
            int BookID,
            int MemberID,
            DateTime BorrowDate,
            DateTime? ReturnDate,
            string Status)
        {
            int rowsAffected = 0;

            SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
                "UPDATE Borrowings SET " +
                "BookID=@BookID, " +
                "MemberID=@MemberID, " +
                "BorrowDate=@BorrowDate, " +
                "ReturnDate=@ReturnDate, " +
                "Status=@Status " +
                "WHERE BorrowingID=@BorrowingID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrowingID", BorrowingID);
            command.Parameters.AddWithValue("@BookID", BookID);
            command.Parameters.AddWithValue("@MemberID", MemberID);
            command.Parameters.AddWithValue("@BorrowDate", BorrowDate);

            if (ReturnDate.HasValue)
                command.Parameters.AddWithValue("@ReturnDate", ReturnDate.Value);
            else
                command.Parameters.AddWithValue("@ReturnDate", DBNull.Value);

            command.Parameters.AddWithValue("@Status", Status);

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


        public static bool DeleteBorrowing(int BorrowingID)
        {
            int rowsAffected = 0;

            SqlConnection connection =
                new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query =
                "DELETE FROM Borrowings WHERE BorrowingID=@BorrowingID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@BorrowingID", BorrowingID);

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