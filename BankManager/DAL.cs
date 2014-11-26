using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Data.SqlClient;
using System.Data.Common;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace BankManager
{
    // Data Access Layer
    class DAL
    {
        // строка соединения с БД
        string connectionString = @"Data Source=localhost;Initial Catalog=BankDB;Integrated Security=True;";
        
        // Извлекает записи  из таблицы Debitors и возвращает в виде ArrayList
        public ArrayList GetAllDebitors()
        {
            ArrayList allDebitors = new ArrayList();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM dbo.Debitors ORDER BY Name", sqlConnection);
            try
            {
                sqlConnection.Open();
                // об. для чтения потока строк из БД
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.HasRows)
                    foreach (DbDataRecord result in sqlDataReader)
                        allDebitors.Add(result);
            }
            catch 
            { 
            }

            }
            //sqlConnection.Dispose();
            return allDebitors;
        }

        internal ArrayList SearchForDebitors(string debName, string debPostNum, string debPhoneNum)
        {
            ArrayList searchedDebitors = new ArrayList();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand("SearchDebitor", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                //1-й параметр
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@debName";
                param.Value = debName;
                param.SqlDbType = System.Data.SqlDbType.NVarChar;
                param.Direction = System.Data.ParameterDirection.Input;
                command.Parameters.Add(param);
                //2-й параметр
                param = new SqlParameter();
                param.ParameterName = "@debPostNum";
                param.Value = debPostNum;
                param.SqlDbType = System.Data.SqlDbType.NVarChar;
                param.Direction = System.Data.ParameterDirection.Input;
                command.Parameters.Add(param);
                //3-й параметр
                param = new SqlParameter();
                param.ParameterName = "@debPhoneNum";
                param.Value = debPhoneNum;
                param.SqlDbType = System.Data.SqlDbType.NVarChar;
                param.Direction = System.Data.ParameterDirection.Input;
                command.Parameters.Add(param);

                try
                {
                    connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                        foreach (DbDataRecord item in dataReader)
                        {
                            searchedDebitors.Add(item);
                        }
                }
                catch
                {
                }
            }
            return searchedDebitors;
        }

        // Извлекает записи  из таблицы Credits для данного дебитора. (Используется хранимая процедура.)
        internal ArrayList GetAllCreditsForDebitor(string debitorID)
        {
            ArrayList allCreditsForDebitor = new ArrayList();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                SqlCommand command = new SqlCommand("GetAllCreditsByDebitor", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@DebitorID";
                param.Value = new Guid(debitorID);
                param.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
                param.Direction = System.Data.ParameterDirection.Input;
                command.Parameters.Add(param);

                try
                {
                    connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    if(dataReader.HasRows)
                        foreach (DbDataRecord item in dataReader)
                        {
                            allCreditsForDebitor.Add(item);
                        }
                }
                catch 
                {
                }
            }
            return allCreditsForDebitor;
        }

        // Извлекает записи  из таблицы Payments для данного кредита. (Используется строковый литерал.)
        internal ArrayList GetAllPaymentsForCredit(string creditID)
        {
            ArrayList allPaymentsForCredit = new ArrayList();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = String.Format("Select * From Payments Where CreditID = '{0}' Order By PaymentDate", creditID);
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    SqlDataReader dataReader = command.ExecuteReader();
                    if (dataReader.HasRows)
                        foreach (DbDataRecord item in dataReader)
                        {
                            allPaymentsForCredit.Add(item);
                        }
                }
                catch
                {
                }
            }
            return allPaymentsForCredit;
        }

        // Добавление нового дебитора в БД. (Строковый литерал)
        public bool SaveNewDebitor(string ID, string Name, string Number, string PhoneNumber)
        {
            bool flag = false;
            string query = String.Format("INSERT INTO Debitors (ID, Name, PostNumber, PhoneNumber) VALUES ('{0}','{1}','{2}','{3}')",
                ID, Name, Number, PhoneNumber);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                        flag = true;
                }
                catch { }
            }
            return flag;
        }

        // Добавление нового кредита в БД (Параметризованный запрос)
        public bool SaveNewCredit(Guid ID, Guid DebitorID, int Amount, int Balance, DateTime OpeningDate)
        {
            bool flag = false;
            string sAmount = Amount.ToString(CultureInfo.InvariantCulture.NumberFormat);
            // Параметризированный запрос
            string query = String.Format
                ("INSERT INTO Credits " +
                "(ID, DebitorID, Amount, Balance, OpeningDate) " + 
                "VALUES (@ID, @DebitorID, @Amount, @Balance, @OpeningDate)");
                
            using(SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                // Параметры запроса
                SqlParameter param = new SqlParameter("@ID", ID);
                param.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@DebitorID";
                param.Value = DebitorID;
                param.SqlDbType = System.Data.SqlDbType.UniqueIdentifier;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Amount";
                param.Value = Amount;
                param.SqlDbType = System.Data.SqlDbType.Money;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@Balance";
                param.Value = Balance;
                param.SqlDbType = System.Data.SqlDbType.Money;
                command.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@OpeningDate";
                param.Value = OpeningDate;
                param.SqlDbType = System.Data.SqlDbType.DateTime;
                command.Parameters.Add(param);

                try
                {
                    connection.Open();
                    if (command.ExecuteNonQuery() == 1)
                        flag = true;
                }
                catch (SqlException e)
                {
                    Console.WriteLine("\n\n" + e.Message);
                }
            }
            return flag;
        }

        // Добавление нового платежа в БД. Работа в режиме транзакции.
        public bool SaveNewPayment(Guid ID, Guid CreditID, decimal Amount, DateTime PaymentDate)
        {
            bool flag = true;
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlTransaction sqlTransact = con.BeginTransaction();
                SqlCommand com = con.CreateCommand();
                com.Transaction = sqlTransact;

                string sAmount = Amount.ToString(CultureInfo.InvariantCulture.NumberFormat);
                try
                {
                    string query = String.Format
                        ("INSERT INTO Payments (ID, CreditID, Amount, PaymentDate)" +
                        " VALUES ('{0}', '{1}', '{2}','{3}')",
                        ID, CreditID, sAmount, PaymentDate);
                    com.CommandText = query;
                    com.ExecuteNonQuery();
                    
                    query = String.Format
                        ("UPDATE Credits SET Balance = (Balance - '{0}') WHERE ID = '{1}'", sAmount, CreditID);
                    com.CommandText = query;
                    com.ExecuteNonQuery();
                    sqlTransact.Commit();
                }
                catch (Exception)
                {
                    sqlTransact.Rollback();
                    flag = false;
                }
                finally
                {
                    if (con.State == System.Data.ConnectionState.Open)
                        con.Dispose();
                }
            }
            return flag;
        }

        // Сохранение БД в файлах формата CSV
        internal bool SaveDBToCSVFile()
        {
            bool resultDebitors;

            //FileStream fileStream = new FileStream("Debitors.csv", FileMode.Create);
            //StreamWriter file = new StreamWriter(fileStream, Encoding.ASCII);

            string query = "SELECT * FROM Debitors";
            using(SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    StreamWriter file1 = new StreamWriter(new FileStream("Debitors.csv", FileMode.Create), Encoding.GetEncoding(1251));
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    file1.WriteLine("Start of file");
                    file1.WriteLine(@"""ID"";""Name"";""PostNumber"";""PhoneNumber""");

                    if (reader.HasRows)
                        while (reader.Read())
                            file1.WriteLine(@"""" + reader.GetValue(0).ToString() + @""";""" +
                                reader.GetString(1) + @""";""" +
                                reader[2].ToString() + @""";""" +
                                reader[3].ToString() + @"""", Encoding.ASCII);
                    else
                        file1.WriteLine("No data in data base.");

                    file1.WriteLine("End of file");
                    resultDebitors = true;
                    file1.Dispose();
                }
                catch (Exception)
                {
                    resultDebitors = false;
                }
            }

            //-------------------------------------

            bool resultCredits;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    StreamWriter file2 = new StreamWriter(new FileStream("Credits.csv", FileMode.Create), Encoding.GetEncoding(1251));
                    query = "SELECT * FROM Credits";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    file2.WriteLine("Start of file");
                    file2.WriteLine(@"""ID"";""DebitorID"";""Amount"";""Balance"";""OpeningDate""");

                    if (reader.HasRows)
                        while (reader.Read())
                            file2.WriteLine(@"""" + 
                                reader[0].ToString() + @""";""" +
                                reader[1].ToString() + @""";""" +
                                reader[2].ToString() + @""";""" +
                                reader[3].ToString() + @""";""" +
                                reader[4].ToString() + @"""", Encoding.ASCII);
                    else
                        file2.WriteLine("No data in data base.");

                    file2.WriteLine("End of file");
                    resultCredits = true;
                    file2.Dispose();
                }
                catch (Exception)
                {
                    resultCredits = false;
                }
            }

            //-------------------------------------
            bool resultPayments;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    StreamWriter file2 = new StreamWriter(new FileStream("Payments.csv", FileMode.Create), Encoding.GetEncoding(1251));
                    query = "SELECT * FROM Payments";
                    SqlCommand com = new SqlCommand(query, con);
                    con.Open();
                    SqlDataReader reader = com.ExecuteReader();

                    file2.WriteLine("Start of file");
                    file2.WriteLine(@"""ID"";""CreditID"";""Amount"";""PaymentDate""");

                    if (reader.HasRows)
                        while (reader.Read())
                            file2.WriteLine(@"""" +
                                reader[0].ToString() + @""";""" +
                                reader[1].ToString() + @""";""" +
                                reader[2].ToString() + @""";""" +
                                reader[3].ToString() + @"""", Encoding.ASCII);
                    else
                        file2.WriteLine("No data in data base.");

                    file2.WriteLine("End of file");
                    resultPayments = true;
                    file2.Dispose();
                }
                catch (Exception)
                {
                    resultPayments = false;
                }
            }
            //---------------------------------------------------
            if (resultDebitors && resultCredits && resultPayments)
                return true;
            else
                return false;
        }
    }
}
