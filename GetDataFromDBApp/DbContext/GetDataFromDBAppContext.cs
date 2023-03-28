using GetDataFromDBApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GetDataFromDBAppDbContext
{
    public class GetDataFromDBAppContext : DbContext
    {
        //public DbSet<ParameterValue> ParameterValue { get; set; }
        public DbSet<Parameter> Parameter { get; set; } 
        public GetDataFromDBAppContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=NewDataDB;Trusted_Connection=True;");

        }
    }

    //static string connectionString = "Server=DESKTOP-IGTK1UR;Database=Report;Trusted_Connection=True;";
    //public List<Parameter> GetMyDataFromStoredProcedure()
    //{
    //    List<Parameter> myData = new List<Parameter>();

    //    using (SqlConnection conn = new SqlConnection(connectionString))
    //    {
    //        SqlCommand cmd = new SqlCommand("monthReport_0007_TechnReport_BODY", conn);
    //        cmd.CommandType = CommandType.StoredProcedure;

    //        conn.Open();

    //        string GUID = Guid.NewGuid().ToString("N");

    //        using (SqlDataReader reader = cmd.ExecuteReader())
    //        {
    //            while (reader.Read())
    //            {
    //                Parameter model = new Parameter();
    //                model.ID_Parameter = Convert.ToString(GUID);
    //                model.ParameterName = Convert.ToString(reader["Descr"]);

    //                myData.Add(model);
    //            }
    //        }
    //    }
    //    return myData;
    //}
}
