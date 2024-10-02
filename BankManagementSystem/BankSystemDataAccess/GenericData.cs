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

        static public int GetPersonIdOrClientId<T>(string query, string ParameterName, T ParameterValue)
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

        static public bool Exist<T>(string query, string ParameterName, T ParameterValue)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(SettingsData.ConnectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue(ParameterName, ParameterValue);
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

    }

}
