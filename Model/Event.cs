using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWK2
{
    public class Event
    {
        public int EventId { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public string StartTime { set; get; }
        public DateTime EndDate { set; get; }
        public string EndTime { set; get; }
        public String Location { set; get; }
        public TimeSpan Duration { set; get; }
        
        // public Event(string title)
        //{
        //    Title = title;
        //    StartDate = DateTime.Today;
        //    StartTime = DateTime.Now;
        //    EndDate = StartDate;
        //    EndTime = StartTime.AddHours(1);
        //}

        //public Event(string title, DateTime startDate, DateTime startTime, DateTime endDate, DateTime endTime, string location)
        //{
        //    Title = title;
        //    StartDate = startDate;
        //    StartTime = startTime;
        //    EndDate = endDate;
        //    EndTime = endTime;
        //    Location = location;
        //    Duration = EndTime - StartTime; 

        //}
        public Event(string title, DateTime startDate, DateTime endDate, string location)
        {
            Title = title;
            StartDate = startDate;
            StartTime = StartDate.ToShortTimeString();
            EndDate = endDate;
            EndTime = endDate.ToShortTimeString(); ;
            Location = location;
            Duration = EndDate.TimeOfDay - StartDate.TimeOfDay;

        }
        public Event(int eventId, string title, string startDate, string endDate, string location)
        {
            EventId = eventId;
            Title = title;
            StartDate = DateTime.Parse(startDate);
            StartTime = StartDate.ToShortTimeString();
            EndDate = DateTime.Parse(endDate);
            EndTime = EndDate.ToShortTimeString(); ;
            Location = location;
            Duration = EndDate.TimeOfDay - StartDate.TimeOfDay;

        }
        //public Event(string title, DateTime startDate, DateTime startTime, DateTime endDate, DateTime endTime, string location, int duration)
        //{
        //    Title = title;
        //    StartDate = startDate;
        //    StartTime = startTime;
        //    EndDate = endDate;
        //    EndTime = endTime;
        //    Location = location;
        //    Duration = duration; 
        //}
        public void addRecord()
        {
            System.Diagnostics.Debug.WriteLine("Add record");
        }
        public string TimeTitle
        { 
                get{ return $"{StartTime}  {Title}"; }
        }  


        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendLine(EventId.ToString());
            str.AppendLine(Title);
            str.AppendLine(StartDate.ToString());
            str.AppendLine(StartTime);
            str.AppendLine(EndDate.ToString());
            str.AppendLine(EndTime);
            str.AppendLine(Duration.ToString());
            str.AppendLine(Location);

            return str.ToString();
        }

    }
}
