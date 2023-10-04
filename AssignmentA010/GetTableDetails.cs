using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentA010
{
    class GetTablesDetails
    {
        static MySqlConnection con = DBConnection.GetConnection();
        public static List<string> GetAllTables()
        {
            List<string> result = new List<string>();
            try
            {
                con.Open();
                MySqlCommand cmd = new MySqlCommand("SELECT table_name FROM information_schema.tables WHERE table_schema = 'assignmentDB'", con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                    result.Add(reader["table_name"].ToString());
            }
            catch (Exception ex)
            {
                string errorMsg = @"Exception Place:{0} Exception Message: {1},Exception Detail: {2}";
                errorMsg = string.Format(errorMsg, "GetTablesDetails.cs", ex.Message, ex.ToString());
                ErrorLog.WriteLog(errorMsg);
                return result;
            }
            finally
            {
                con.Close();
            }

            return result;
        }
        public static int GetTotalRecords(string tableName)
        {
            string stmt = string.Format("SELECT COUNT(*) FROM {0}", tableName);

            int count = 0;
            try
            {
                using (MySqlCommand cmd = new MySqlCommand(stmt, con))
                {
                    con.Open();
                    count = Convert.ToInt32(cmd.ExecuteScalar());

                    return count;
                }
            }
            catch (Exception ex)
            {
                string errorMsg = @"Exception Place:{0} Exception Message: {1},Exception Detail: {2}";


                errorMsg = string.Format(errorMsg, "GetTablesDetails.cs", ex.Message, ex.ToString());
                ErrorLog.WriteLog(errorMsg);
                return 0;
            }
            finally
            {
                con.Close();
            }
        }
    }
}

