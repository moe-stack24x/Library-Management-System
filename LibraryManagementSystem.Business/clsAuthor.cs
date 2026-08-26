using LibraryManagementSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LibraryManagementSystem.Business
{
    public class clsAuthor
    {
      public  enum _enMode
        {
            Add,
            Update,

        }
        _enMode Mode;

        public int AuthorID { get; set; }
        public string Name { get; set; }

        public clsAuthor()
        {
            AuthorID = 0;
            Name = string.Empty;
            Mode = _enMode.Add;

        }
        public clsAuthor(int AuthorID, string Name)
        {
            this.AuthorID = AuthorID;
            this.Name = Name;
            Mode = _enMode.Update;

        }

        public static DataTable GetAllAuthors()
        {
            return clsAuthorsData.GetAllAuthors();
        }

        public static clsAuthor GetAuthorByID(int authorID)
        {
            string AuthorName=" ";

            if (clsAuthorsData.GetAuthorByID(authorID, ref AuthorName))
            {
                return new clsAuthor(authorID, AuthorName);
            }

              return null;
        }

        private bool _AddAuthor()
        {
            return clsAuthorsData.AddAuthor(this.Name);
        }

        public static bool DeleteAuthor(int authorID)
        {   
            return clsAuthorsData.DeleteAuthor(authorID);
        }
        private bool _UpdateAuthor()
        {
            return clsAuthorsData.UpdateAuthor(this.AuthorID, this.Name);
        }

      public  bool Save()
        {
            switch (Mode)
            {


                case _enMode.Add:

                    if (_AddAuthor())
                    {


                        Mode = _enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }



                case _enMode.Update:

                    return _UpdateAuthor();


            }

            return false;

        }
    }
}
