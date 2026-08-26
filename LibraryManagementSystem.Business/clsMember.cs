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
    public class clsMember
    {
        public enum _enMode
        {
            Add,
            Update,

        }
        _enMode Mode;

        public int MemberID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
       


        public clsMember()
        {
            MemberID = 0;
            FirstName = string.Empty;
            LastName = string.Empty;
            Phone = string.Empty;
            Email = string.Empty;
            Address = string.Empty;
            

            Mode = _enMode.Add;

        }
        public clsMember(int MemberID,string FirstName, string LastName, string Phone, string Email, string Address)
        {

            this.MemberID = MemberID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
           

            Mode = _enMode.Update;

        }

        public static DataTable GetAllMembers()
        {
            return clsMembersData.GetAllMembers();
        }

        public static clsMember GetMemberByID(int MemberID)
        {

           
           string FirstName = string.Empty;
            string LastName = string.Empty;
            string Phone = string.Empty;
            string Email = string.Empty;
            string Address = string.Empty;

            if (clsMembersData.GetMemberByID(MemberID,ref FirstName,ref LastName,ref Phone,ref Email,ref Address))
            {
                return new clsMember(MemberID,  FirstName,  LastName,  Phone,  Email,  Address);
            }

            return null;
        }

        private bool _AddMember()
        {
            return clsMembersData.AddMember(this.FirstName, this.LastName, this.Phone, this.Email, this.Address);
        }

        public static bool DeleteMember(int MemberID)
        {
            return clsMembersData.DeleteMember(MemberID);
        }
        private bool _UpdateMember()
        {
            return clsMembersData.UpdateMember(this.MemberID, this.FirstName, this.LastName, this.Phone, this.Email, this.Address);
        }

        public bool Save()
        {
            switch (Mode)
            {


                case _enMode.Add:

                    if (_AddMember())
                    {


                        Mode = _enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }



                case _enMode.Update:

                    return _UpdateMember();


            }

            return false;

        }
    }
}
