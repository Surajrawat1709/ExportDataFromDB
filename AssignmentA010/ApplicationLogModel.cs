using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentA010
{
    class ApplicationLogModel
    {
        public int ExecutionId { get; set; }
        public string SelectedSourceTables { get; set; }
        public string SelectedExportFormat { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string TotalExecutionTime { get; set; }
        public int TotalRecordsCountSource { get; set; }
        public int TotalRecordsExported { get; set; }
        public string OutputPath { get; set; }
        public string OutputFilename { get; set; }
    }
}