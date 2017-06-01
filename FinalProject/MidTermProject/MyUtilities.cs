using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTermProject
{
    class MyUtilities
    {
        public static string GetConnected()
        {
            return "Server=SQL.NEIT.EDU,4500;Database=SE255_NRicci;User Id=SE255_NRicci;Password = 001405200;";
        }
    }
}
