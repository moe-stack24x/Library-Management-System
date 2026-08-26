using LibraryManagementSystem.DataAccess;
using System;
using System.Data;

namespace LibraryManagementSystem.Business
{
    public class clsBook
    {
        public enum _enMode
        {
            Add,
            Update
        }

        _enMode Mode;

        public int BookID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public int CategoryID { get; set; }
        public string ISBN { get; set; }
        public int PublishYear { get; set; }

        public int TotalCopies { get; set; }
        public int AvailableCopies { get; set; }

      


        public clsBook()
        {
            BookID = 0;
            Title = string.Empty;
            AuthorID = 0;
            CategoryID = 0;
            ISBN = string.Empty;
            PublishYear = 0;
            TotalCopies = 0;
            AvailableCopies = 0;
          

            Mode = _enMode.Add;
        }


        public clsBook(int BookID,string Title,int AuthorID,int CategoryID,string ISBN,int PublishYear,int TotalCopies,int AvailableCopies)
        {
            this.BookID = BookID;
            this.Title = Title;
            this.AuthorID = AuthorID;
            this.CategoryID = CategoryID;
            this.ISBN = ISBN;
            this.PublishYear = PublishYear;
            this.TotalCopies = TotalCopies;
            this.AvailableCopies = AvailableCopies;
         

            Mode = _enMode.Update;
        }


        public static DataTable GetAllBooks()
        {
            return clsBooksData.GetAllBooks();
        }


        public static clsBook GetBookByID(int BookID)
        {
            string Title = string.Empty;
            int AuthorID = 0;
            int CategoryID = 0;
            string ISBN = string.Empty;
            int PublishYear = 0;
            int TotalCopies = 0;
            int AvailableCopies = 0;
            bool IsAvailable = false;

            if (clsBooksData.GetBookByID(
                BookID,
                ref Title,
                ref AuthorID,
                ref CategoryID,
                ref ISBN,
                ref PublishYear,
                ref TotalCopies,
                ref AvailableCopies))
            {
                return new clsBook(
                    BookID,
                    Title,
                    AuthorID,
                    CategoryID,
                    ISBN,
                    PublishYear,
                    TotalCopies,
                    AvailableCopies);
            }

            return null;
        }


        private bool _AddBook()
        {
            return clsBooksData.AddBook(
                this.Title,
                this.AuthorID,
                this.CategoryID,
                this.ISBN,
                this.PublishYear,
                this.TotalCopies,
                this.AvailableCopies);
        }


        public static bool DeleteBook(int BookID)
        {
            return clsBooksData.DeleteBook(BookID);
        }


        private bool _UpdateBook()
        {
            return clsBooksData.UpdateBook(this.BookID,this.Title,this.AuthorID,this.CategoryID,this.ISBN, this.PublishYear, this.TotalCopies, this.AvailableCopies);
        }


        public bool Save()
        {
            switch (Mode)
            {
                case _enMode.Add:

                    if (_AddBook())
                    {
                        Mode = _enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case _enMode.Update:

                    return _UpdateBook();
            }

            return false;
        }
    }
}