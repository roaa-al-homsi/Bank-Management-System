using BankSystemDataAccess;
using System;


namespace BankSystemBusiness
{
    public class Person
    {
        private enum enMode { Update = 0, AddNew = 1 };
        private enMode _Mode;
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime BirthDate { get; set; }
        public string ImagePath { get; set; }


        public Person(int Id, string FirstName, string LastName, string Email,
            string PhoneNumber, DateTime BirthDate, string ImagePath)
        {
            this.Id = Id;
            this.Email = Email;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.PhoneNumber = PhoneNumber;
            this.BirthDate = BirthDate;
            this.ImagePath = ImagePath;
            _Mode = enMode.Update;
        }

        public Person()
        {
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.Email = string.Empty;
            this.PhoneNumber = string.Empty;
            this.Id = -1;
            this.BirthDate = DateTime.MinValue;
            this.ImagePath = string.Empty;
            _Mode = enMode.AddNew;
        }

        private bool _AddNew()
        {
            this.Id = PersonData.AddNew(this.FirstName, this.LastName, this.PhoneNumber, this.Email, this.BirthDate, this.ImagePath);
            return (Id != -1);
        }

        private bool _Update()
        {
            return PersonData.Update(this.Id, this.FirstName, this.LastName, this.PhoneNumber, this.Email, this.BirthDate, this.ImagePath);

        }
        public static bool DeletePerson(int ID)
        {
            return PersonData.Delete(ID);
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    _Mode = enMode.Update;
                    return (_AddNew());

                case enMode.Update:
                    return _Update();
            }
            return false;
        }



    }
}
