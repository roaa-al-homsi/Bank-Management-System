using System;
using System.Data.SqlClient;

namespace BankSystemDataAccess
{
    static public class PersonData
    {

        static public int AddNew(string FirstName, string LastName, string PhoneNumber, string Email, DateTime BirthDate, string ImagePath)
        {
            int NewPersonID = 0;

            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = @"insert into Persons (FirstName,LastName,Email,PhoneNumber,BirthDate,ImagePath)values
(@FirstName,@LastName,@Email,@PhoneNumber,@BirthDate,@ImagePath);
                           SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("@BirthDate", BirthDate);

            if (ImagePath != null)
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    NewPersonID = insertedID;
                }

            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return NewPersonID;
        }

        static public bool Update(int Id, string FirstName, string LastName, string PhoneNumber, string Email, DateTime BirthDate, string ImagePath)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = @"update Persons  set 
                           FirstName=@FirstName , LastName=@LastName,Email=@Email,PhoneNumber=@PhoneNumber,BirthDate=@BirthDate ,ImagePath=@ImagePath
                            where PersonId=@Id;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@BirthDate", BirthDate);
            command.Parameters.AddWithValue("@Id", Id);
            if (ImagePath != null)
            {
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            }
            else
            {
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);
            }

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { return false; }
            finally { connection.Close(); }
            return RowsAffected > 0;

        }

        static public bool Delete(int Id)
        {
            return GenericData.Delete<int>("delete Persons where PersonID=@PersonID", "@PersonID", Id);

        }

    }




}
