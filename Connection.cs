using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace plantImproveSystem
{
    class Connection
    {
        public static MySqlConnection getConnection()
        {
            string connection = "server=localhost;database=pis;uid=root;pwd='';sslmode=none;";
            return new MySqlConnection(connection);
        }

        public static void Insert()
        {
            MySqlCommand mCommand = new MySqlCommand("insert");
            MySqlParameter paramName = new MySqlParameter();
            paramName.ParameterName = "@name";
            paramName.Value = "adnan";
            mCommand.Parameters.Add(paramName);
            mCommand.ExecuteNonQuery();
        }
        public static void Update()
        {
            MySqlCommand mCommand = new MySqlCommand("update");
            MySqlParameter paramName = new MySqlParameter();
            paramName.ParameterName = "@name";
            paramName.Value = "adnan";
            mCommand.Parameters.Add(paramName);
            mCommand.ExecuteNonQuery();
        }
        public static void Delete()
        {
            MySqlCommand mCommand = new MySqlCommand("delete");
            MySqlParameter paramName = new MySqlParameter();
            paramName.ParameterName = "@name";
            paramName.Value = "adnan";
            mCommand.Parameters.Add(paramName);
            mCommand.ExecuteNonQuery();
        }
    }
}
