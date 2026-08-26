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
    public class clsCategory
    {
        public enum _enMode
        {
            Add,
            Update,

        }
        _enMode Mode;

        public int CategoryID { get; set; }
        public string Name { get; set; }

        public clsCategory()
        {
            CategoryID = 0;
            Name = string.Empty;
            Mode = _enMode.Add;

        }
        public clsCategory(int categoryID, string name)
        {
            this.CategoryID = categoryID;
            this.Name = name;
            Mode = _enMode.Update;

        }

        public static DataTable GetAllCategories()
        {
            return DataAccess.clsCategoriesData.GetAllCategories();
        }

        public static clsCategory GetCategoryByID(int categoryID)
        {
            string CategoryName = " ";

            if (clsCategoriesData.GetCategoryByID(categoryID, ref CategoryName))
            {
                return new clsCategory(categoryID, CategoryName);
            }

            return null;
        }

        private bool _AddCategory()
        {
            return DataAccess.clsCategoriesData.AddCategory(this.Name);
        }

        public static bool DeleteCategory(int categoryID)
        {
            return DataAccess.clsCategoriesData.DeleteCategory(categoryID);
        }
        private bool _UpdateCategory()
        {
            return DataAccess.clsCategoriesData.UpdateCategory(this.CategoryID, this.Name);
        }

        public bool Save()
        {
            switch (Mode)
            {


                case _enMode.Add:

                    if (_AddCategory())
                    {


                        Mode = _enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }



                case _enMode.Update:

                    return _UpdateCategory();


            }

            return false;

        }
    }
}
