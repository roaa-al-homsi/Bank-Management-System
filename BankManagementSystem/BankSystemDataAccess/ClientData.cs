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
            bool IsFind = false;

            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = @"SELECT Clients.ClientID, Persons.FirstName, Persons.LastName, Persons.Email, Persons.PhoneNumber, 
                        Persons.BirthDate, Persons.ImagePath,Clients.AccountNumber, Clients.Pincode, Clients.Salary, Clients.PersonID
                FROM Persons INNER JOIN Clients ON Persons.PersonID = Clients.PersonID where Clients.AccountNumber=@AccountNumber;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFind = true;

                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    PhoneNumber = (string)reader["PhoneNumber"];
                    Email = (string)reader["Email"];
                    PinCode = (string)reader["PinCode"];
                    Id = (int)reader["ClientID"];
                    PersonId = (int)reader["PersonID"];
                    DateBirth = (DateTime)reader["BirthDate"];
                    Salary = Convert.ToDouble(reader["Salary"]);


                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }
                }
                else
                { IsFind = false; }

                reader.Close();

            }
            catch (Exception ex) { IsFind = false; }
            finally { connection.Close(); }

            return IsFind;
        }


        static public bool GetClientByClientID(int ID, ref string AccountNumber, ref string FirstName,
           ref string LastName, ref int PersonId, ref string PhoneNumber, ref string Email, ref string PinCode,
           ref double Salary, ref DateTime DateBirth, ref string ImagePath)
        {
            bool IsFind = false;

            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = @"SELECT Clients.ClientID, Persons.FirstName, Persons.LastName, Persons.Email, Persons.PhoneNumber, 
                        Persons.BirthDate,Persons.ImagePath, Clients.AccountNumber, Clients.Pincode, Clients.Salary, Clients.PersonID
                FROM Persons INNER JOIN Clients ON Persons.PersonID = Clients.PersonID where Clients.ClientID=@ClientID;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFind = true;

                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    PhoneNumber = (string)reader["PhoneNumber"];
                    Email = (string)reader["Email"];
                    PinCode = (string)reader["PinCode"];
                    AccountNumber = (string)reader["AccountNumber"];
                    PersonId = (int)reader["PersonID"];
                    DateBirth = (DateTime)reader["BirthDate"];
                    Salary = Convert.ToDouble(reader["Salary"]);
                    if (reader["ImagePath"] != DBNull.Value)
                    {
                        ImagePath = (string)reader["ImagePath"];
                    }
                    else
                    {
                        ImagePath = "";
                    }
                }
                else
                { IsFind = false; }

                reader.Close();

            }
            catch (Exception ex) { IsFind = false; }
            finally { connection.Close(); }

            return IsFind;
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
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = "delete Clients where ClientID=@ClientID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { return false; }
            finally { connection.Close(); }
            return RowsAffected > 0;
        }

        static public bool Delete(string AccountNumber)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = "delete Clients where AccountNumber=@AccountNumber";
            SqlCommand command = new SqlCommand(query, connection);
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

        static public int GetPersonIdByClientID(int ClientID)
        {
            int PersonID = 0;
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = @"select PersonID from Clients where ClientID=@ClientID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ClientID);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return PersonID;
        }

        static public int GetPersonIdByClientAccountNumber(string AccountNumber)
        {

            int PersonID = 0;
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = @"select PersonID from Clients where AccountNumber=@AccountNumber;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return PersonID;

        }

        static public bool Exists(int ID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = @"select Found=1 from Clients where ClientID=@ClientID;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ClientID", ID);
            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                IsFound = Reader.HasRows;
                Reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return IsFound;

        }

        static public DataTable AllClients()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = @"SELECT Clients.ClientID, Persons.FirstName, Persons.LastName, Persons.Email, Persons.PhoneNumber, 
                        Persons.BirthDate,Persons.ImagePath, Clients.AccountNumber, Clients.Pincode, Clients.Salary, Clients.PersonID
                FROM Persons INNER JOIN Clients ON Persons.PersonID = Clients.PersonID ;";

            SqlCommand command = new SqlCommand(query, connection);


            try
            {
                connection.Open();
                SqlDataReader Reader = command.ExecuteReader();
                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }
                Reader.Close();
            }
            catch (Exception ex) { }
            finally { connection.Close(); }
            return dt;
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

        static public bool Deposit(float AmountDeposit, string AccountNumber)
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










    }
}
