using LibraryManagementSystem.DataAccess;
using System;
using System.Data;

namespace LibraryManagementSystem.Business
{
    public class clsBorrowing
    {
        public enum _enMode
        {
            Add,
            Update
        }

        _enMode Mode;

        public int BorrowingID { get; set; }
        public int BookID { get; set; }
        public int MemberID { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Status { get; set; }


        public clsBorrowing()
        {
            BorrowingID = 0;
            BookID = 0;
            MemberID = 0;
            BorrowDate = DateTime.Now;
            ReturnDate = null;
            Status = string.Empty;

            Mode = _enMode.Add;
        }


        public clsBorrowing(
            int BorrowingID,
            int BookID,
            int MemberID,
            DateTime BorrowDate,
            DateTime? ReturnDate,
            string Status)
        {
            this.BorrowingID = BorrowingID;
            this.BookID = BookID;
            this.MemberID = MemberID;
            this.BorrowDate = BorrowDate;
            this.ReturnDate = ReturnDate;
            this.Status = Status;

            Mode = _enMode.Update;
        }


        public static DataTable GetAllBorrowings()
        {
            return clsBorrowingsData.GetAllBorrowings();
        }


        public static clsBorrowing GetBorrowingByID(int BorrowingID)
        {
            int BookID = 0;
            int MemberID = 0;
            DateTime BorrowDate = DateTime.Now;
            DateTime? ReturnDate = null;
            string Status = string.Empty;

            if (clsBorrowingsData.GetBorrowingByID(
                BorrowingID,
                ref BookID,
                ref MemberID,
                ref BorrowDate,
                ref ReturnDate,
                ref Status))
            {
                return new clsBorrowing(
                    BorrowingID,
                    BookID,
                    MemberID,
                    BorrowDate,
                    ReturnDate,
                    Status);
            }

            return null;
        }


        private bool _AddBorrowing()
        {
            return clsBorrowingsData.AddBorrowing(
                this.BookID,
                this.MemberID,
                this.BorrowDate,
                this.ReturnDate,
                this.Status);
        }


        private bool _UpdateBorrowing()
        {
            return clsBorrowingsData.UpdateBorrowing(
                this.BorrowingID,
                this.BookID,
                this.MemberID,
                this.BorrowDate,
                this.ReturnDate,
                this.Status);
        }


        public static bool DeleteBorrowing(int BorrowingID)
        {
            return clsBorrowingsData.DeleteBorrowing(BorrowingID);
        }


        public bool Save()
        {
            switch (Mode)
            {
                case _enMode.Add:

                    if (_AddBorrowing())
                    {
                        Mode = _enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }


                case _enMode.Update:

                    return _UpdateBorrowing();
            }

            return false;
        }
    }
}