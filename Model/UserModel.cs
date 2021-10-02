using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharpjwt.Model
{
    public class UserModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public DateTime DateOfJoing { get; set; }
    }

    public class AgentDashBoardModel
    {





        public int UserID { get; set; }
        public int AgentID { get; set; }
        public string UserName { get; set; }



        public int TotalCustomers { get; set; }
        public int ActiveCustomers { get; set; }
        public int PaidCustomers { get; set; }
        public int DormantCustomers { get; set; }


        public int MonthEarning { get; set; }
        public int CurrentBalance { get; set; }
        public int AverageEarning { get; set; }
        public int StatusID { get; set; }
        public string StatusName { get; set; }





    }


}
