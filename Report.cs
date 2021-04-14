using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWK2
{
    public partial class Report : Form
    {
        private List<Event> events;
        private DataAccess data;
        // private int dayCounter = 28;
        private DateTime today = DateTime.Now;
        private TimeSpan totalDuration;
        private string weekOneTxt, weekTwoTxt, weekThreeTxt, weekFourTxt;

        public TimeSpan weekOneDuration;

       public string getWeekTxt(TimeSpan weekOneDuration)
        {
            DateTime temp = new DateTime(); 
           // temp = 
            string txt = weekOneDuration.ToString("c");
            return txt;

        }

        public Report(DataAccess data, List<Event> events)
        {
            InitializeComponent();

            this.Activate();
            this.Show(); 


            this.events = events;
            this.data = data;

            int dayCounter = 14;
            DateTime tempDate = new DateTime();
            tempDate = today.AddDays(-dayCounter);

            TimeSpan pastAvrDuration = getDuration(tempDate, today);

            System.Diagnostics.Debug.WriteLine($"\nPAST AVERAGE {pastAvrDuration}\n");
            // double avr = double.Parse(pastAvrDuration.ToString());



            DateTime weekOneStart = getStartofWeek(tempDate.AddDays(7));
            weekOneDuration = getDuration(weekOneStart, weekOneStart.AddDays(6));
            weekOneTxt = weekOneDuration.ToString();


            DateTime weekTwoStart = getStartofWeek(weekOneStart.AddDays(7));
            TimeSpan weekTwoDuration = getDuration(weekTwoStart, weekTwoStart.AddDays(6));
            weekTwoTxt = getWeekTxt(weekTwoDuration);// weekTwoDuration.ToString();

            DateTime weekThreeStart = getStartofWeek(weekTwoStart.AddDays(7));
            TimeSpan weekThreeDuration = getDuration(weekThreeStart, weekThreeStart.AddDays(6));
            weekThreeTxt = weekThreeDuration.ToString();

            DateTime weekFourStart = getStartofWeek(weekThreeStart.AddDays(7));
            TimeSpan weekFourDuration = getDuration(weekFourStart, weekFourStart.AddDays(6));
            weekThreeTxt = weekFourDuration.ToString();
        }


        public TimeSpan getDuration(DateTime tempDateStart, DateTime tempDateEnd )
        {
            for (int i = 0; i < events.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine($"Iteration {i}");
                DateTime eventDate = events.ElementAt(i).StartDate;

                //Check that event date > tempDate and < today
                int condition1 = checkDateRange(eventDate, tempDateStart);
                int condition2 = checkDateRange(eventDate, tempDateEnd);
                if ((condition1 > 0) && (condition2 <= 0))
                {
                    totalDuration += events.ElementAt(i).Duration;
                    System.Diagnostics.Debug.WriteLine($"Duration {events.ElementAt(i).Duration} New total duration: {totalDuration}");
                }
            }
            return totalDuration;
        }

        public int checkDateRange(DateTime date1, DateTime date2)
        {
            int value = DateTime.Compare(date1, date2);
          //  if (value > 0)
              //"date1 is later than date2. 
         //   else if (value < 0)
              //  System.Diagnostics.Debug.WriteLine("date1 is earlier than date2. ");
          //  else
              //  System.Diagnostics.Debug.WriteLine("date1 is the same as date2. ");
            return value;
        }

        private void Report_Load(object sender, EventArgs e)
        {
            this.weekOneLbl.Text = weekOneTxt;
            this.weekTwoLbl.Text = weekTwoTxt;
            this.weekThreeLbl.Text = weekThreeTxt;
            this.weekFourLbl.Text = weekFourTxt;
        }

        public DateTime getStartofWeek(DateTime date)
        {
            DateTime startOfWeek = date;

            string weekday = date.DayOfWeek.ToString();

            switch (weekday)
            {
                case "Monday":
                    System.Diagnostics.Debug.WriteLine(date.ToString());
                    return startOfWeek = date;
                    break;

                case "Tuesday":
                    System.Diagnostics.Debug.WriteLine(date.ToString());
                    return startOfWeek = date.AddDays(-1);
                    break;

                case "Wednesday":
                    System.Diagnostics.Debug.WriteLine(date.ToString());
                    return startOfWeek = date.AddDays(-2);
                    break;

                case "Thursday":
                    System.Diagnostics.Debug.WriteLine(date.ToString());
                    return startOfWeek = date.AddDays(-3);
                    break;
                case "Friday":
                    System.Diagnostics.Debug.WriteLine(date.ToString());
                    return startOfWeek = date.AddDays(-4);
                    break;
                case "Saturday":
                    System.Diagnostics.Debug.WriteLine(date.ToString());
                    return startOfWeek = date.AddDays(-5);
                    break;
                case "Sunday":
                    System.Diagnostics.Debug.WriteLine(date.ToString());
                    return startOfWeek = date.AddDays(-6);
                    break;
            }

            System.Diagnostics.Debug.WriteLine(date.ToString());
            return startOfWeek;
        }


    }
}
