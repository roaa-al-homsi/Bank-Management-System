using System;
using System.Data;
using System.Data.SqlClient;

namespace BankSystemDataAccess
{
    static public class GenericData
    {
        static public bool Delete<T>(string query, string ParameterName, T DeleteBy)
        {
            int RowsAffected = 0;
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(ParameterName, DeleteBy);

            try
            {
                connection.Open();
                RowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex) { return false; }
            finally { connection.Close(); }
            return RowsAffected > 0;

        }

        static public int GetPersonId<T>(string query, string ParameterName, T ParameterValue)
        {
            int PersonID = 0;
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(ParameterName, ParameterValue);

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

        static public DataTable All(string query)
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
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

        static public bool GetClient<T1, T2>(string query, string ParameterName, T1 ParameterValue, ref T2 IdOrAcc, string NameIdOrAcc, ref string FirstName,
           ref string LastName, ref int PersonId, ref string PhoneNumber, ref string Email, ref string PinCode,
           ref double Salary, ref DateTime DateBirth, ref string ImagePath)
        {
            bool IsFind = false;
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(ParameterName, ParameterValue);

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
                    IdOrAcc = (T2)reader[NameIdOrAcc];
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

    }

}
