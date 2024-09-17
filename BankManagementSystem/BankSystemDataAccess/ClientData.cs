using System;
using System.Data;
using System.Data.SqlClient;


namespace BankSystemDataAccess
{
    static public class ClientData
    {
        static public bool GetClientByAccountNumber(string AccountNumber, ref string FirstName,
            ref string LastName, ref int Id, ref int PersonId, ref string PhoneNumber, ref string Email, ref string PinCode,
            ref double Salary, ref DateTime DateBirth, ref string ImagePath)
        {

            return GenericData.GetClient<string, int>
          ("select * from View_ClientDetails where AccountNumber = @AccountNumber;", "@AccountNumber", AccountNumber, ref Id, "ClientID", ref FirstName, ref LastName, ref PersonId, ref PhoneNumber, ref Email, ref PinCode, ref Salary, ref DateBirth, ref ImagePath);

        }


        static public int AddNewClient(string AccountNumber, double Salary, DateTime BirthDate, string PineCode, int PersonID)
        {

            int NewClientId = 0;

            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = @"insert into Clients (AccountNumber,PinCode,Salary,PersonID)values (@AccountNumber,@PinCode,@Salary,@PersonID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PinCode", PineCode);
            command.Parameters.AddWithValue("@Salary", Salary);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    NewClientId = insertedID;
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return NewClientId;
        }

        static public bool Update(int Id, string AccountNumber, string PinCode, double Salary, int PersonID)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = @"update Clients  set 
                           AccountNumber=@AccountNumber , PinCode=@PinCode,Salary=@Salary,PersonID=@PersonID
                            where ClientID=@ClientID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@Salary", Salary);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@ClientID", Id);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { return false; }
            finally { connection.Close(); }
            return RowsAffected > 0;

        }

        static public bool Delete(int ID)
        {
            return GenericData.Delete<int>("delete Clients where ClientID=@ClientID", "@ClientID", ID);

        }

        static public bool Delete(string AccountNumber)
        {
            return GenericData.Delete<string>("delete Clients where AccountNumber=@AccountNumber", "@AccountNumber", AccountNumber);
        }

        static public int GetPersonIdByClientID(int ClientID)
        {
            return GenericData.GetPersonIdOrClientId<int>("select PersonID from Clients where ClientID=@ClientID;", "@ClientID", ClientID);

        }

        static public int GetPersonIdByClientAccountNumber(string AccountNumber)
        {
            return GenericData.GetPersonIdOrClientId<string>("select PersonID from Clients where AccountNumber=@AccountNumber;", "@AccountNumber", AccountNumber);

        }

        static public int GetClientIdByAccountNumber(string AccountNumber)
        {
            return GenericData.GetPersonIdOrClientId<string>("select ClientID from Clients where AccountNumber=@AccountNumber;", "@AccountNumber", AccountNumber);

        }

        static public bool Exist(int ID)
        {
            return GenericData.Exist<int>("select Found=1 from Clients where ClientID=@ClientID;", "@ClientID", ID);

        }

        static public bool Exist(string AccountNumber)
        {
            return GenericData.Exist<string>("select Found=1 from Clients where AccountNumber=@AccountNumber;", "@AccountNumber", AccountNumber);

        }

        static public bool ClientIdExistInTransfers(int ID)
        {
            return GenericData.Exist<int>("select Found=1 from Transfers where [Source Client Id]=@ID or [Destination Client Id]=@ID;", "@ID", ID);

        }

        static public DataTable AllClients()
        {
            return GenericData.All("select * from View_ClientDetails;");
        }

        static public double TotalBalance()
        {
            double total = 0;
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = @"select sum(Salary) from Clients;";
            SqlCommand command = new SqlCommand(query, connection);
            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    total = insertedID;
                }

            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return total;
        }

        static public bool Deposit(double AmountDeposit, string AccountNumber)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);

            string query = "update Clients set Salary = Salary + @AmountDeposit  where AccountNumber=@AccountNumber";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AmountDeposit", AmountDeposit);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { return false; }
            finally { connection.Close(); }

            return RowsAffected > 0;
        }

        static public bool RegisterTransfers(DateTime dateTime, int SourceClientId, int DestinationClientId, double Amount,
            double SalarySourceAccount, double SalaryDestinationAccount, int UserId)
        {

            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = @"insert into Transfers ([Date Time],[Source Client Id],[Destination Client Id],Amount,[Salary source account],[Salary destination account],[User Id]) 
                           values (@dateTime,@SourceClientId,@DestinationClientId,@Amount,@SalarySourceAccount,@SalaryDestinationAccount,@UserId);";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@dateTime", dateTime);
            command.Parameters.AddWithValue("@SourceClientId", SourceClientId);
            command.Parameters.AddWithValue("@DestinationClientId", DestinationClientId);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@SalarySourceAccount", SalarySourceAccount);
            command.Parameters.AddWithValue("@SalaryDestinationAccount", SalaryDestinationAccount);
            command.Parameters.AddWithValue("@UserId", UserId);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return RowsAffected > 0;

        }
        static public DataTable Transaction()
        {
            return GenericData.All("select * from View_Transaction;");
        }

        static public DataTable Transfers()
        {
            return GenericData.All("select * from View_TransferDetails;");

        }


    }
}
