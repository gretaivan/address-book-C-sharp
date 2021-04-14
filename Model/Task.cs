using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWK2
{
    class Task
    {
        public string Title
        { get; set; }
        public DateTime StartDate
        { get; set; }
        //public DateTime StartTime
        //{ set; get; }
        public DateTime EndDate
        { set; get; }
        //public DateTime EndTime
        //{ set; get; }

        public Task(string title, DateTime startDate, DateTime endDate)
        {
            Title = title;
            StartDate = startDate;
            // StartTime = StartTime;
            EndDate = endDate;
        }

        public void addRecord()
        {
            System.Diagnostics.Debug.WriteLine("Add record");
        }

    }
}
