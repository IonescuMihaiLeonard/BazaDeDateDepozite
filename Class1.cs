using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;

namespace ionescu_mihai_leonard_proiect_bd_262
{
    class Class1
    {
        public static OracleConnection GetDBConnection()
        {
            string host = "193.226.51.37";
            int port = 1521;
            string sid = "o11g";
            string user = "mihaileonardionescu";
            string password = "mihaileonard#20";

            return Class2.GetDBConnection(host, port, sid, user, password);
        }
    }
}
