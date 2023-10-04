using CsvHelper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentA010
{
    class ApplicationLog
    {
        public static void logFile(string tableName, DateTime startTime, DateTime endTime, string elapsedTime, int totalRecords, int count, string filename, string formatType)
        {
            var csvPath1 = ConfigurationManager.AppSettings["dataExportApplicationLog"];
            if (!Directory.Exists(csvPath1))
                Directory.CreateDirectory(csvPath1);

            string formatType1 = "";

            var csvPath = csvPath1 + "DataExportApplicationLog.csv";
           
            if (formatType == "CSV Format")
                formatType1 = "CSV";
            else if (formatType == "Excel File")
                formatType1 = "Excel";
            else
                formatType1 = "Both";

            string outputFileName = (formatType == "CSV Format") ? ".csv" : ".xlsx";

            var testlist = new List<ApplicationLogModel>();

            try
            {
                testlist.Add(new ApplicationLogModel()
                {
                    ExecutionId = count,
                    SelectedSourceTables = tableName,
                    SelectedExportFormat = formatType1,
                    StartTime = startTime,
                    EndTime = endTime,
                    TotalExecutionTime = elapsedTime + " Sec",
                    TotalRecordsCountSource = totalRecords,
                    TotalRecordsExported = totalRecords,
                    OutputPath = ConfigurationManager.AppSettings["fileoutputPath"],
                    OutputFilename = filename + outputFileName

                });


                using (var streamWriter = new StreamWriter(csvPath, true))
                {
                    using (var csvWriter = new CsvWriter(streamWriter, System.Globalization.CultureInfo.InvariantCulture))
                    {
                        csvWriter.WriteRecords(testlist);                      
                    }

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
