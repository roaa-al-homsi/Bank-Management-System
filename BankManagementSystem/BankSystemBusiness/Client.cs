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
            string FirstName = string.Empty;
            string LastName = string.Empty;
            string Email = string.Empty;
            double Salary = 1;
            int PersonId = -2;
            string PhoneNumber = string.Empty;
            DateTime BirthDate = new DateTime(1999, 1, 1);
            string PinCode = string.Empty;
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

        public static bool Exist(int ID)
        {
            return ClientData.Exist(ID);
        }

        public static bool Exist(string AccountNumber)
        {
            return ClientData.Exist(AccountNumber);
        }

        public static bool ClientIdExistInTransfers(int ID)
        {
            return ClientData.Exist(ID);

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
            if (!Exist(ID))
            {
                return false;
            }

            if (ClientIdExistInTransfers(ID))
            {
                return false;
            }

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
            if (!Exist(AccountNumber))
            {
                return false;
            }

            int ClientID = ClientData.GetClientIdByAccountNumber(AccountNumber);
            if (ClientIdExistInTransfers(ClientID))
            {
                return false;
            }

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

        public static DataTable All()
        {
            return ClientData.AllClients();
        }

        public bool ReadyClient()
        {
            if (_Mode == enMode.AddNew && Exist(this.AccountNumber))
            {
                return false;
            }

            if (this.Salary <= 0 || this.PinCode == null || this.PersonId == 0)
            {
                return false;
            }

            if (base.FirstName == null || base.LastName == null || base.Email == null || base.PhoneNumber == null || base.BirthDate == null)
            {
                return false;
            }

            return true;

        }

        public bool Save()
        {
            if (!ReadyClient())
            {
                return false;
            }

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

        public bool Deposit(double AmountDeposit)
        {
            this.Salary += AmountDeposit;
            return ClientData.Deposit(AmountDeposit, this.AccountNumber);
        }

        public bool Withdraw(double AmountWithdraw)
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

        private void _RegisterTransfers(double Amount, Client ClientDestination, int UserId)
        {
            DateTime dateTime = DateTime.Now;

            ClientData.RegisterTransfers(dateTime, this.Id, ClientDestination.Id, Amount, this.Salary, ClientDestination.Salary, UserId);
        }

        public bool Transfer(double Amount, Client DestinationClient, int UserId)
        {
            if (this.AccountNumber == DestinationClient.AccountNumber)
            {
                return false;
            }

            if (Amount > this.Salary)
            {
                return false;
            }
            Withdraw(Amount);
            DestinationClient.Deposit(Amount);
            _RegisterTransfers(Amount, DestinationClient, UserId);
            return true; ;
        }

        static public DataTable Transaction()
        {
            return ClientData.Transaction();

        }

        static public DataTable Transfers()
        {
            return ClientData.Transfers();

        }




    }
}

