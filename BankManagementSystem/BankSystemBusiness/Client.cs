using BankSystemDataAccess;
using System;
using System.Data;

namespace BankSystemBusiness
{
    public class Client : Person
    {

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;

        public int Id { get; set; }
        public string AccountNumber { get; set; }
        public string PinCode { get; set; }
        public double Salary { get; set; }
        public int PersonId { get; set; }

        public Client()
        {
            this.Id = -1;
            this.Email = string.Empty;
            this.BirthDate = DateTime.Now;
            this.Salary = 1;
            this.PhoneNumber = string.Empty;
            this.FirstName = string.Empty;
            this.LastName = string.Empty;
            this.PersonId = -1;

            _Mode = enMode.AddNew;
        }

        private Client(int Id, string FirstName, string LastName, string Email, string PhoneNumber, DateTime BirthDate,
            int PersonId, double Salary, string PinCode, string AccountNumber, string ImagePath) : base(PersonId, FirstName, LastName, Email, PhoneNumber, BirthDate, ImagePath)
        {

            this.PinCode = PinCode;
            this.Salary = Salary;
            this.AccountNumber = AccountNumber;
            this.Id = Id;
            this.PersonId = PersonId;

            _Mode = enMode.Update;
        }

        public static Client Find(string AccountNumber)
        {
            string FirstName = "";
            string LastName = "";
            string Email = "";
            double Salary = 1;
            int PersonId = -2;
            string PhoneNumber = "";
            DateTime BirthDate = new DateTime(1999, 1, 1);
            string PinCode = "";
            string ImagePath = null;
            int Id = -1;
            if (ClientData.GetClientByAccountNumber(AccountNumber, ref FirstName, ref LastName, ref Id,
                ref PersonId, ref PhoneNumber, ref Email, ref PinCode, ref Salary, ref BirthDate, ref ImagePath))
            {
                return new Client(Id, FirstName, LastName, Email, PhoneNumber, BirthDate,
             PersonId, Salary, PinCode, AccountNumber, ImagePath);
            }
            else
            {
                return null;
            }
        }

        public static Client Find(int ID)
        {
            string FirstName = string.Empty;
            string LastName = string.Empty;
            string Email = string.Empty;
            double Salary = 1;
            int PersonId = -1;
            string PhoneNumber = string.Empty;
            DateTime BirthDate = new DateTime(1999, 1, 1);
            string PinCode = string.Empty;
            string AccountNumber = string.Empty;
            string ImagePath = string.Empty;

            if (ClientData.GetClientByClientID(ID, ref AccountNumber, ref FirstName, ref LastName,
                ref PersonId, ref PhoneNumber, ref Email, ref PinCode, ref Salary, ref BirthDate, ref ImagePath))
            {
                return new Client(ID, FirstName, LastName, Email, PhoneNumber, BirthDate,
                                      PersonId, Salary, PinCode, AccountNumber, ImagePath);
            }

            else
            {
                return null;
            }
        }

        private bool _AddNew()
        {
            if (!base.Save())
            {
                return false;
            }
            this.Id = ClientData.AddNewClient(this.AccountNumber, this.Salary, this.BirthDate, this.PinCode, base.Id);
            return (Id != -1);
        }

        private bool _Update()
        {
            if (!base.Save())
            {
                return false;
            }
            return ClientData.Update(this.Id, this.AccountNumber, this.PinCode, this.Salary, base.Id);
        }

        public static bool Delete(int ID)
        {
            int PersonID = ClientData.GetPersonIdByClientID(ID);
            if (!ClientData.Delete(ID))
            {
                return false;
            }
            else
            {
                return Person.DeletePerson(PersonID);
            }
        }

        public static bool Delete(string AccountNumber)
        {
            int PersonID = ClientData.GetPersonIdByClientAccountNumber(AccountNumber);

            if (!ClientData.Delete(AccountNumber))
            {
                return false;
            }
            else
            {
                return Person.DeletePerson(PersonID);
            }
        }

        public static bool Exists(int ID)
        {
            return ClientData.Exists(ID);
        }

        public static DataTable All()
        {
            return ClientData.AllClients();
        }

        public bool Save()
        {
            switch (_Mode)
            {
                case enMode.AddNew:

                    _Mode = enMode.Update;
                    _AddNew();
                    return true;

                case enMode.Update:
                    return _Update();
            }
            return false;
        }

        public static double TotalSalaries()
        {
            return ClientData.TotalBalance();
        }
        public bool Deposit(float AmountDeposit)
        {
            this.Salary += AmountDeposit;
            return ClientData.Deposit(AmountDeposit, this.AccountNumber);
        }

        public bool Withdraw(float AmountWithdraw)
        {
            if (AmountWithdraw > this.Salary)
            {
                return false;
            }
            else
            {
                return Deposit(-1 * AmountWithdraw);
            }
        }

        private void _RegisterTransfers(float Amount, Client ClientDestination, string UserName)
        {
            DateTime dateTime = DateTime.Now;

            ClientData.RegisterTransfers(dateTime, this.AccountNumber, ClientDestination.AccountNumber, Amount, this.Salary, ClientDestination.Salary, UserName);

        }

        public bool Transfer(float Amount, Client DestinationClient)
        {
            if (Amount > this.Salary)
            {
                return false;
            }
            Withdraw(Amount);
            DestinationClient.Deposit(Amount);
            _RegisterTransfers(Amount, DestinationClient, "Roaa");
            return true; ;
        }






    }
}

