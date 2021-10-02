using csharpjwt.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace csharpjwt.SQLHelpers
{
    public class AgentSQL
    {

        public static string DBConn = Startup.DBConn;
        private static Byte[] Key;
        private static Byte[] DBPassword;
        private static Byte[] IV;
        public AgentDashBoardModel GetAgentDashBoard(int UserID, int month, int year)
        {
            AgentDashBoardModel data = new AgentDashBoardModel();
            try
            {
                using (SqlConnection conn = new SqlConnection(DBConn))
                {
                    using (SqlCommand cmd = new SqlCommand("spAgentUserDashBoard", conn))//call Stored Procedure
                    {
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@UserID", UserID);
                        cmd.Parameters.AddWithValue("@Month", month);
                        cmd.Parameters.AddWithValue("@Year", year);

                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        if (reader.Read())
                        {




                            data.UserID = Convert.ToInt32(reader["UserID"].ToString());

                            data.AgentID = Convert.ToInt32(reader["AgentID"].ToString());
                            data.UserName = reader["UserName"].ToString();
                            data.TotalCustomers = Convert.ToInt32(reader["TotalCustomers"].ToString());

                            data.ActiveCustomers = Convert.ToInt32(reader["ActiveCustomers"].ToString());
                            data.PaidCustomers = Convert.ToInt32(reader["PaidCustomers"].ToString());
                            data.DormantCustomers = Convert.ToInt32(reader["DormantCustomers"].ToString());


                            data.MonthEarning = Convert.ToInt32(reader["MonthEarning"].ToString());
                            data.AverageEarning = Convert.ToInt32(reader["AverageEarning"].ToString());

                            data.CurrentBalance = Convert.ToInt32(reader["CurrentBalance"].ToString());

                            data.StatusID = Convert.ToInt32(reader["StatusID"].ToString());
                            data.StatusName = reader["StatusName"].ToString();





                        }
                    }
                }
            }
            catch (Exception ex)
            {
                 //  return null;
            }

            return data;
        }


    }
}
