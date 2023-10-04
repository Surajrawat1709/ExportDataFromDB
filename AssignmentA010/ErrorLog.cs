using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentA010
{
    class ErrorLog
    {
        public static void WriteLog(string msg)
        {
            string root = ConfigurationManager.AppSettings["errorLogPath"];
            if (!Directory.Exists(root))
                Directory.CreateDirectory(root);


            var currentDate = DateTime.Now;
            var monthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(currentDate.Month);
            //   var root = AppDomain.CurrentDomain.BaseDirectory + "\\logs";
            var yearPath = root + "\\" + "Error Log " + currentDate.Year.ToString() + "\\";
            var MonthPath = yearPath + currentDate.Year + "-" + monthName + "\\";
            var errorFile = MonthPath + "ErrorLogs-" + String.Format("{0:d-M-yyyy}", currentDate.Date) + ".txt";
            try
            {
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }
                if (!Directory.Exists(yearPath))
                {
                    Directory.CreateDirectory(yearPath);
                }
                if (!Directory.Exists(MonthPath))
                {
                    Directory.CreateDirectory(MonthPath);
                }
                if (!File.Exists(errorFile))
                {
                    FileStream fs = File.Create(errorFile);
                    fs.Close();
                }

                var oPErrorLog = new StringBuilder();
                oPErrorLog.Append(" ------------------ Application Error! " + currentDate.ToString() + " ------------------");
                oPErrorLog.AppendLine("");
                oPErrorLog.Append(msg);
                oPErrorLog.AppendLine("");
                oPErrorLog.AppendLine("----------------------------------------------------------------------------------------------------------------");
                using (StreamWriter writer = File.AppendText(errorFile))
                {
                    writer.WriteAsync(oPErrorLog.ToString());
                }
            }
            catch (Exception ex)
            {
                string errorMsg = @"Exception Place:{0} Exception Message: {1},Exception Detail: {2}";


                errorMsg = string.Format(errorMsg, "GetTablesDetails.cs", ex.Message, ex.ToString());
                ErrorLog.WriteLog(errorMsg);

            }
        }
    }
}
