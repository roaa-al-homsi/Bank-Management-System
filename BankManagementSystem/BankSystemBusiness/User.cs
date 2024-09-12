using BankSystemDataAccess;
using System;
using System.Data;

namespace BankSystemBusiness
{
    public class User : Person
    {
        private enum enMode { Add = 0, Update = 1 };
        private enMode _Mode;


        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Permission { get; set; }
        public int PersonId { get; set; }

        private User(string UserName, string FirstName, string LastName, int Id, int PersonId, string PhoneNumber, string Email, string Password
                , int Permission, DateTime BirthDate, string ImagePath) : base(PersonId, FirstName, LastName, Email, PhoneNumber, BirthDate, ImagePath)
        {
            this.Id = Id;
            this.UserName = UserName;
            this.Permission = Permission;
            this.Password = Password;
            this.PersonId = PersonId;
            _Mode = enMode.Update;
        }

        public User()
        {
            this.Id = -1;
            this.UserName = string.Empty;
            this.Permission = 0;
            this.Password = string.Empty;
            this.PersonId = -1;
            _Mode = enMode.Add;
        }

        static public User Find(string UserName)
        {
            int Id = -1;
            string FirstName = string.Empty;
            string LastName = string.Empty;
            string Email = string.Empty;
            int PersonId = -1;
            string PhoneNumber = string.Empty;
            DateTime BirthDate = new DateTime(1999, 1, 1);
            string ImagePath = string.Empty;

            string Password = string.Empty;
            int Permission = 1;

            if (UserData.GetUserByUserName(UserName, ref FirstName, ref LastName, ref Id, ref PersonId, ref PhoneNumber, ref Email, ref Password
                , ref Permission, ref BirthDate, ref ImagePath))
            {
                return new User(UserName, FirstName, LastName, Id, PersonId, PhoneNumber, Email, Password, Permission, BirthDate, ImagePath);
            }
            else
            {
                return null;
            }
        }
        static public User Find(string UserName, string Password)
        {
            int Id = -1;
            string FirstName = string.Empty;
            string LastName = string.Empty;
            string Email = string.Empty;
            int PersonId = -1;
            string PhoneNumber = string.Empty;
            DateTime BirthDate = new DateTime(1999, 1, 1);
            string ImagePath = string.Empty;
            int Permission = 1;

            if (UserData.GetUserByUserNameAndPassword(UserName, ref FirstName, ref LastName, ref Id, ref PersonId, ref PhoneNumber, ref Email, Password
                , ref Permission, ref BirthDate, ref ImagePath))
            {
                return new User(UserName, FirstName, LastName, Id, PersonId, PhoneNumber, Email, Password, Permission, BirthDate, ImagePath);
            }
            else
            {
                return null;
            }
        }
        private bool _Add()
        {
            if (!base.Save())
            {
                return false;
            }
            else
            {
                this.Id = UserData.Add(this.UserName, this.Password, this.Permission, base.Id);
                return (this.Id != -1);
            }
        }

        private bool _Update()
        {
            if (!base.Save())
            {
                return false;
            }
            else
            {
                return UserData.Update(this.Id, this.UserName, this.Password, this.Permission, this.PersonId);
            }
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.Add:
                    {
                        _Mode = enMode.Update;
                        return (_Add());
                    }
                case enMode.Update:
                    {
                        return _Update();
                    }
            }
            return false;
        }

        static public bool Delete(int ID)
        {
            int PersonId = UserData.GetPersonIdByUserID(ID);
            if (!UserData.Delete(ID))
            {
                return false;
            }
            else
            {
                return Person.DeletePerson(PersonId);
            }
        }

        static public bool Delete(string UserName)
        {
            int PersonId = UserData.GetPersonIdByUserName(UserName);
            if (!UserData.Delete(UserName))
            {
                return false;
            }
            else
            {
                return Person.DeletePerson(PersonId);
            }
        }

        static public DataTable All()
        {
            return UserData.All();
        }

        public bool RegisterLogins(DateTime dateLogin, DateTime dateLogout, int UserId)
        {
            return UserData.RegisterLogins(dateLogin, dateLogout, UserId);
        }

        static public DataTable ShowLogins()
        {
            return UserData.AllLogins();
        }




    }
}

