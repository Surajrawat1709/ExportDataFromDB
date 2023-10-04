using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentA010
{

    public partial class Form1 : Form
    {
        int count = 0;

        CustomStopwatch stopwatch = new CustomStopwatch();

        List<string> tablesList = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            List<string> names = GetTablesDetails.GetAllTables();

            // Console.WriteLine("Table names in AssignmentDB are:");
            for (int i = 0; i < names.Count; i++)
            {
                tablesList.Add(names[i]);
                tableComboBox.Items.Add(names[i]);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String tableName = tableComboBox.SelectedItem.ToString();
            String formatType = formatComboBox.SelectedItem.ToString();
            if (tablesList.Contains(tableName))
            {
                Console.WriteLine("Choose target output format:\n 1 for CSV \n 2 for Excel \n 3 for Both Excel and CSV");
                string outputFormat = Console.ReadLine();

                //Count total records
                int totalRecords = GetTablesDetails.GetTotalRecords(tableName);

                // Begin timing
                stopwatch.Start();

                String fileName = tableName + "Data_" + count + stopwatch.StartAt.Value.ToString("ddMMyyyy_HHmmss");
                String dateTimestampfolder = stopwatch.StartAt.Value.ToString("ddMMyyyy_HHmmss");

                //  GetCSV.GetCSVFile(tableName, outputFormat, fileName, dateTimestampfolder);

                if (formatType == "CSV Format")
                    CreateNewFile.CreateCSVFile(tableName, fileName, dateTimestampfolder);
                else if (formatType == "Excel File")
                    CreateNewFile.CreateExcelFile(tableName, fileName, dateTimestampfolder);
                else
                {
                    CreateNewFile.CreateCSVFile(tableName, fileName, dateTimestampfolder);
                    CreateNewFile.CreateExcelFile(tableName, fileName, dateTimestampfolder);
                }

                // Stop timing
                stopwatch.Stop();

                TimeSpan ts = stopwatch.Elapsed;

                //Format and display the TimeSpan value.
                string elapsedTime = String.Format("{0:00}:{1:00}", ts.Seconds, ts.Milliseconds / 10);

                ApplicationLog.logFile(tableName, stopwatch.StartAt.Value, stopwatch.EndAt.Value, elapsedTime, totalRecords, count, fileName, formatType);
                MessageBox.Show("Files exported successfully!!");
            }
            else
            {
                MessageBox.Show("Enter valid value !!");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TableName_Click(object sender, EventArgs e)
        {

        }
    }
}
