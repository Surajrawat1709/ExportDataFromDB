using ClosedXML.Excel;
using CsvHelper;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentA010
{
    class CreateNewFile
    {
        static MySqlConnection con = DBConnection.GetConnection();

        public static void CreateCSVFile(string tablename, string filename, string dateTimestampfolder)
        {

            con.Open();

            MySqlDataReader dataReader = new MySqlCommand("select * from " + tablename, con).ExecuteReader();

            string outputfilepath = ConfigurationManager.AppSettings["fileoutputPath"];
            if (!Directory.Exists(outputfilepath))
                Directory.CreateDirectory(outputfilepath);


            string file1 = outputfilepath + dateTimestampfolder;
            if (!Directory.Exists(file1))
                Directory.CreateDirectory(file1);

            string fileLocation = file1 + "\\" + filename + ".csv";

            //  ConfigurationManager.AppSettings["fileName"];
            List<string> lines = new List<string>();
            var hasHeaderBeenWritten = false;

            string headerLine = "";
            try
            {

                using (var streamWriter = new StreamWriter(fileLocation, true))
                {
                    using (var csv = new CsvWriter(streamWriter, System.Globalization.CultureInfo.InvariantCulture))
                    {
                        while (dataReader.Read())
                        {
                            if (!hasHeaderBeenWritten)
                            {
                                for (var i = 0; i < dataReader.FieldCount; i++)
                                {
                                    csv.WriteField(dataReader.GetName(i));
                                }
                                csv.NextRecord();
                                hasHeaderBeenWritten = true;
                            }

                            for (var i = 0; i < dataReader.FieldCount; i++)
                            {
                                csv.WriteField(dataReader[i]);
                            }
                            csv.NextRecord();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMsg = @"Exception Place:{0} Exception Message: {1},Exception Detail: {2}";


                errorMsg = string.Format(errorMsg, "CreateCSVFile.cs", ex.Message, ex.ToString());
                ErrorLog.WriteLog(errorMsg);

            }
            finally
            {
                con.Close();
            }

        }

      

        public static void CreateExcelFile(string tablename, string filename, string dateTimestampfolder)
        {

            con.Open();

            string outputfilepath = ConfigurationManager.AppSettings["fileoutputPath"];
            if (!Directory.Exists(outputfilepath))
                Directory.CreateDirectory(outputfilepath);


            string file1 = outputfilepath + dateTimestampfolder;
            if (!Directory.Exists(file1))
                Directory.CreateDirectory(file1);

            string fileLocation = file1 + "\\" + filename + ".xlsx";

            //  ConfigurationManager.AppSettings["fileName"];

            try
            {

                using (MySqlCommand sqlcmd = new MySqlCommand("SELECT * FROM " + tablename))
                {
                    using (MySqlDataAdapter sqlda = new MySqlDataAdapter())
                    {
                        sqlcmd.Connection = con;
                        sqlda.SelectCommand = sqlcmd;

                        using (DataTable dt = new DataTable())
                        {
                            sqlda.Fill(dt);

                            using (XLWorkbook wb = new XLWorkbook())
                            {

                                wb.Worksheets.Add(dt, tablename);
                                wb.SaveAs(fileLocation);

                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMsg = @"Exception Place:{0} Exception Message: {1},Exception Detail: {2}";


                errorMsg = string.Format(errorMsg, "CreateExcelFile", ex.Message, ex.ToString());
                ErrorLog.WriteLog(errorMsg);
            }
            finally
            {
                con.Close();
            }
        }
    }
}