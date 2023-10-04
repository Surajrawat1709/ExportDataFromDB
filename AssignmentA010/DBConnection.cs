using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentA010
{
    class DBConnection
    {

        public static MySqlConnection GetConnection()
        {
            string con = @"Server=localhost;database=assignmentdb;uid=root;pwd=SuraT9999";

            MySqlConnection cn = new MySqlConnection(con);

            return cn;


        }
    }
}

