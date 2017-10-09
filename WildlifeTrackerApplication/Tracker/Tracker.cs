using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Tracker
{
    public class TrackerDB
    {
        private const string connString = "Initial Catalog=WildlifeTracker;Data Source=localhost;Integrated Security=SSPI;";
        private SqlConnection sqlConnection1 = new SqlConnection(connString);
        public void SaveWildlifeTrackerData(string name,string location, string uptimes, string interfaceType, int services, DateTime currenttime,int CPUUsage,long MemoryUsage,long DiskUsage, string IPAddress)
        {
            
            sqlConnection1.Open();
            
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SaveWildlifeTrackerInfo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection1;

            SqlParameter param1 = new SqlParameter();
            param1.ParameterName = "@DeviceID";
            param1.DbType = DbType.String;
            param1.SqlValue = name;
            param1.Size = 50;
            param1.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param1);

            SqlParameter param2 = new SqlParameter();
            param2.ParameterName = "@Location";
            param2.DbType = DbType.String;
            param2.SqlValue = location;
            param2.Size = 50;
            param2.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param2);

            SqlParameter param3 = new SqlParameter();
            param3.ParameterName = "@Uptime";
            param3.DbType = DbType.String;
            param3.SqlValue = uptimes;
            param3.Size = 50;
            param3.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param3);

            SqlParameter param4 = new SqlParameter();
            param4.ParameterName = "@InterfaceType";
            param4.DbType = DbType.String;
            param4.SqlValue = interfaceType;
            param4.Size = 50;
            param4.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param4);

            SqlParameter param5 = new SqlParameter();
            param5.ParameterName = "@Services";
            param5.DbType = DbType.Int32;
            param5.SqlValue = services;
            param5.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param5);

            SqlParameter param6 = new SqlParameter();
            param6.ParameterName = "@currentTimeStamp";
            param6.DbType = DbType.DateTime;
            param6.SqlValue = currenttime;
            param6.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param6);

            SqlParameter param7 = new SqlParameter();
            param7.ParameterName = "@cpuUsage";
            param7.DbType = DbType.Int32;
            param7.SqlValue = CPUUsage;
            param7.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param7);

            SqlParameter param8 = new SqlParameter();
            param8.ParameterName = "@memoryUsage";
            param8.DbType = DbType.Int64;
            param8.SqlValue = MemoryUsage;
            param8.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param8);

            SqlParameter param9 = new SqlParameter();
            param9.ParameterName = "@diskUsage";
            param9.DbType = DbType.Int64;
            param9.SqlValue = DiskUsage;
            param9.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param9);

            SqlParameter param10 = new SqlParameter();
            param10.ParameterName = "@IPAddress";
            param10.DbType = DbType.String;
            param10.SqlValue = IPAddress;
            param10.Size = 50;
            param10.Direction = ParameterDirection.Input;
            cmd.Parameters.Add(param10);
            
            cmd.ExecuteNonQuery();
            sqlConnection1.Close();
        }

        public DataTable FetchData()
        {
            DataTable dt = new DataTable();
            sqlConnection1.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Fetch_WildlifeTracker_Info";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = sqlConnection1;
            SqlDataAdapter sda = new SqlDataAdapter(cmd.CommandText, sqlConnection1);
            sda.Fill(dt);
            sqlConnection1.Close();
            return dt;
        }
    }    
}
