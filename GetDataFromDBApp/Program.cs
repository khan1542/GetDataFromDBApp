// See https://aka.ms/new-console-template for more information
using Azure;
using GetDataFromDBApp.Models;
using GetDataFromDBAppDbContext;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

class Program
{
    static string connectionString = "Server=DESKTOP-IGTK1UR;Database=Report;Trusted_Connection=True;";
    static string newConnectionString = @"Server=(localdb)\mssqllocaldb;Database=NewDataDB;Trusted_Connection=True;";
    static async Task Main(string[] args)
    {
        //string storedProcedureName = "dbo.monthReport_0007_TechnReport_BODY";

        //using (SqlConnection sourceConnection = new(connectionString))
        //{
        //    await sourceConnection.OpenAsync();

        //    using (SqlCommand command = new SqlCommand(storedProcedureName, sourceConnection))
        //    {  
        //        command.CommandType = CommandType.StoredProcedure;

        //        command.Parameters.AddWithValue("@dt", "2018.01.01");
        //        command.Parameters.AddWithValue("@year", 0);

        //        // Create a data table to hold the result set
        //        DataTable dataTable = new DataTable();

        //        // Execute the command and load the result set into the data table
        //        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
        //        {
        //            adapter.Fill(dataTable);
        //        }

        //        // Create a new DbContext object for the destination database
        //        using (GetDataFromDBAppContext context = new GetDataFromDBAppContext())
        //        {
        //            // Add the data from the data table to the database
        //            foreach (DataRow row in dataTable.Rows)
        //            {
        //                Parameter reportData = new Parameter
        //                {
        //                    ID_Parameter = Convert.ToInt32(row["ID_Parameter"]),
        //                    ParameterName = row["ParameterName"].ToString(),
        //                };

        //                context.Parameter.Add(reportData);
        //            }

        //            context.SaveChanges();
        //        }
        //    }
        //}

        string storedProcedureName = "monthReport_0007_TechnReport_BODY";

        using (SqlConnection connection = new(connectionString))
        {
            await connection.OpenAsync();

            Console.WriteLine("Подключение открыто");
            //Вывод информации о подключении
            Console.WriteLine("Свойства подключения:");
            Console.WriteLine($"\tСтрока подключения: {connection.ConnectionString}");
            Console.WriteLine($"\tБаза данных: {connection.Database}");
            Console.WriteLine($"\tСостояние: {connection.State}");

            SqlCommand command = new SqlCommand(storedProcedureName, connection);
            // указываем, что команда представляет хранимую процедуру
            command.CommandType = CommandType.StoredProcedure;
            // передать параметры для хранимой процедуры
            command.Parameters.AddWithValue("@dt", "2018.01.01");
            command.Parameters.AddWithValue("@year", 0);

            using (SqlDataReader reader = await command.ExecuteReaderAsync())
            {
                while (reader.Read())
                {
                    //Accessing the data using the string key as index
                    Console.WriteLine(reader["Descr"] + "|" + reader["sDp1"] + "|" + reader["sDp2"] + "|"
                        + reader["sDp4"] + "|" + reader["sDp6"] + "|" + reader["sDp7"] + "|"
                        + reader["sDp8"] + "|" + reader["sDp9"] + "|" + reader["sDp10"] + "|" + reader["sDp255"]);
                    //Accessing the data using the integer index position as key
                    //Console.WriteLine(sdr[0] + ",  " + sdr[1] + ",  " + sdr[2] + ",  " + sdr[3]);
                }

                //if (reader.HasRows)
                //{
                //    await reader.ReadAsync();

                //    for (int i = 0; i < 10; i++)
                //    {
                //        object value = reader.GetValue(i);
                //        Console.WriteLine($"{value}");
                //    };
                //}
            }
            
        }

    }

}