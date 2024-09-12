using System;
using System.Data;
using System.Data.SqlClient;


namespace BankSystemDataAccess
{
    static public class UserData
    {
        static public bool GetUserByUserName(string UserName, ref string FirstName, ref string LastName, ref int Id, ref int PersonId, ref string PhoneNumber, ref string Email, ref string Password,
            ref int Permission, ref DateTime BirthDate, ref string ImagePath)
        {
            bool IsFind = false;
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = @"SELECT Users.Id, Users.UserName,Persons.FirstName, Persons.LastName, Persons.Email, Persons.PhoneNumber, Persons.BirthDate, Users.Permission ,
             Persons.ImagePath, Users.Password, Users.PersonId FROM Persons INNER JOIN
                  Users ON Persons.PersonID = Users.PersonId where Users.UserName=@UserName;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFind = true;

                    Id = (int)reader["Id"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    PhoneNumber = (string)reader["PhoneNumber"];
                    Email = (string)reader["Email"];
                    PersonId = (int)reader["PersonID"];
                    BirthDate = (DateTime)reader["BirthDate"];
                    Password = (string)reader["Password"];
                    Permission = (int)reader["Permission"];

                    ImagePath = (reader["ImagePath"] != DBNull.Value) ? (string)reader["ImagePath"] : "";

                }
                else
                { IsFind = false; }

                reader.Close();
            }
            catch (Exception ex) { IsFind = false; }
            finally { connection.Close(); }

            return IsFind;

        }


        static public bool GetUserByUserNameAndPassword(string UserName, ref string FirstName, ref string LastName, ref int Id, ref int PersonId, ref string PhoneNumber, ref string Email, string Password,
           ref int Permission, ref DateTime BirthDate, ref string ImagePath)
        {
            bool IsFind = false;
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = @"select * from View_UserDetails where  UserName=@UserName and Password=@Password;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFind = true;

                    Id = (int)reader["Id"];
                    FirstName = (string)reader["FirstName"];
                    LastName = (string)reader["LastName"];
                    PhoneNumber = (string)reader["PhoneNumber"];
                    Email = (string)reader["Email"];
                    PersonId = (int)reader["PersonID"];
                    BirthDate = (DateTime)reader["BirthDate"];
                    Permission = (int)reader["Permission"];

                    ImagePath = (reader["ImagePath"] != DBNull.Value) ? (string)reader["ImagePath"] : "";
                }
                else
                { IsFind = false; }

                reader.Close();
            }
            catch (Exception ex) { IsFind = false; }
            finally { connection.Close(); }

            return IsFind;

        }


        static public int Add(string UserName, string Password, int Permission, int PersonId)
        {
            int NewUserId = 0;

            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = @"insert into Users (UserName,Permission,PersonId,Password)values (@UserName,@Permission,@PersonId,@Password);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Permission", Permission);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@PersonId", PersonId);

            try
            {
                connection.Open();
                object Result = command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int insertedID))
                {
                    NewUserId = insertedID;
                }
            }
            catch (Exception ex) { }
            finally { connection.Close(); }

            return NewUserId;
        }

        static public bool Update(int Id, string UserName, string Password, int Permission, int PersonId)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = @"update Users  set 
                           UserName=@UserName , Password=@Password,Permission=@Permission,PersonId=@PersonId
                            where Id=@Id;";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permission", Permission);
            command.Parameters.AddWithValue("@PersonId", PersonId);
            command.Parameters.AddWithValue("@Id", Id);

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

            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = "delete Users where Id=@Id";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", Id);
            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { return false; }
            finally { connection.Close(); }
            return RowsAffected > 0;

        }

        static public int GetPersonIdByUserID(int UserId)
        {
            int PersonID = 0;
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = @"select PersonId from Users where Id=@Id;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@Id", UserId);

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

        static public int GetPersonIdByUserName(string UserName)
        {
            int PersonID = 0;
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = @"select PersonId from Users where UserName=@UserName;";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);

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

        static public bool Delete(string UserName)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = "delete Users where UserName=@UserName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@UserName", UserName);
            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { return false; }
            finally { connection.Close(); }
            return RowsAffected > 0;

        }

        static public DataTable All()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = @" select * from View_UserDetails";

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

        static public bool RegisterLogins(DateTime dateLogin, DateTime dateLogout, int UserID)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = @"insert into Logins ([Login Date],[Logout Date],[User Id]) values
                      (@dateLogin,@dateLogout,@UserID);";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@dateLogin", dateLogin);
            command.Parameters.AddWithValue("@dateLogout", dateLogout);
            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { return false; }
            finally { connection.Close(); }
            return RowsAffected > 0;
        }

        static public DataTable AllLogins()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            string query = @" select * from View_LoginsDetails";

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


    }
}
