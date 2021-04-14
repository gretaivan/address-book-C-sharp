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
    public partial class MainView : Form
    {
        public List<Model.Contact> savedContactList = new List<Model.Contact>();
        private DataAccess data = new DataAccess();
        private ContactBook contacts;
        private List<Event> events = new List<Event>();
        List<Event> dayEvents = new List<Event>();


        //todays' date
        private DateTime Today { get; set; }
        private DateTime TempDate { get; set; }
        private string MonthText
        {
            get { return TempDate.ToString("MMMM"); }
            set { MonthText = TempDate.ToString("MMMM"); }
        }
        private string TodayText
        {
            get { return Today.ToString("dddd, dd MMMM yyyy"); }
            set { TodayText = Today.ToString("dddd, dd MMMM yyyy"); }
        }
        private DateTime weekStart;
        private Label[] monthDays = new Label[7];
        private string monthDayText { set; get; }

        private ListBox[] daysList = new ListBox[7]; 

        /*
         * USED FOR THE FIRST INITIALISATION WHEN APPLICATION STARTED
         */
        public MainView()
        {

            InitializeComponent();

            monthDays[0] = monthDayMondayLabel;
            monthDays[1] = monthDayTsdLabel;
            monthDays[2] = monthDayWedLabel;
            monthDays[3] = monthDayThrLabel;
            monthDays[4] = monthDayFrLabel;
            monthDays[5] = monthDaySatLabel;
            monthDays[6] = monthDaySunLabel;

            daysList[0] = listBox1;
            daysList[1] = listBox2;
            daysList[2] = listBox3;
            daysList[3] = listBox4;
            daysList[4] = listBox5;
            daysList[5] = listBox6;
            daysList[6] = listBox7;



            savedContactList = data.GetContacts();
            events = data.dbGetEvents(); 

            for(int i = 0; i < events.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine("Weekly view contact list: " + events.ElementAt(i));
            }
        }

        public MainView(DataAccess data, List<Model.Contact> savedContactList)
        {

            InitializeComponent();

            monthDays[0] = monthDayMondayLabel;
            monthDays[1] = monthDayTsdLabel;
            monthDays[2] = monthDayWedLabel;
            monthDays[3] = monthDayThrLabel;
            monthDays[4] = monthDayFrLabel;
            monthDays[5] = monthDaySatLabel;
            monthDays[6] = monthDaySunLabel;

            daysList[0] = listBox1;
            daysList[1] = listBox2;
            daysList[2] = listBox3;
            daysList[3] = listBox4;
            daysList[4] = listBox5;
            daysList[5] = listBox6;
            daysList[6] = listBox7;

            this.savedContactList = savedContactList;
            this.data = data;
            this.events = data.getEvents(); 

            for (int i = 0; i < savedContactList.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine("Weekly view contact list: " + savedContactList.ElementAt(i));
            }


            //contacts = new ContactBook(data, savedContactList);
        }

        private void MainView_Load(object sender, EventArgs e)
        {
            Today = DateTime.Now;

            //set the label for todays' date
            this.label1.Text = TodayText;

            //value that sets day panels
            TempDate = Today;

            //set the month label
            monthLabel.Text = MonthText;

            //set monthdays
            //get weekstart
            weekStart = getStartofWeek(TempDate);

            updateDayPanels();
        }

        /*
         *UPDATES: labels and list in the weekly dashboar
         *
         */
        public void updateDayPanels()
        {
            for (int i = 0; i < 7; i++)
            {

                DateTime day = weekStart.AddDays(i);

                //set day labels
                monthDayText = day.Day.ToString();
                monthDays[i].Text = monthDayText;


                //dayEvents = data.getDayEvent(day);
                List<Event> dayEventList = new List<Event>();

                //get a lit for a day
                dayEventList = setDayEventList(day);


                //dayEvents = events;
                dayEvents = dayEventList;
                daysList[i].DisplayMember = "TimeTitle";
                //set day list
                daysList[i].DataSource = dayEvents;
            }

        }

        /*
         * returns the event list for given day 
         */
        public List<Event> setDayEventList(DateTime day)
        {
            List<Event> dayEventList = new List<Event>();
            for (int j = 0; j < events.Count; j++)
            {
                string comparable = events.ElementAt(j).StartDate.ToShortDateString();
                if (comparable.Equals(day.ToShortDateString()))
                {
                    dayEventList.Add(events.ElementAt(j));
                }
            }
            return dayEventList;
        }

        private void ContactsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contacts = new ContactBook(data, savedContactList);
            this.calendarPanel.Hide();
            //this.calendarTableLayout.Hide();
            contacts.TopLevel = false;
            contacts.TopMost = true;
            contacts.Activate(); 

            //this.calendarPanel.Controls.Add(this.contacts);
            //this.calendarPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            //contacts.Dock = System.Windows.Forms.DockStyle.Fill;

            //contacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top)
            //| System.Windows.Forms.AnchorStyles.Left)
            //| System.Windows.Forms.AnchorStyles.Right)));
            //contacts.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //contacts.AutoSize = true;
            //contacts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;           
           
            this.Controls.Add(contacts);
           //this.Size = new System.Drawing.Size(200, 338);
            contacts.Show();
            this.Text = "Contact View";
        }

        private void ContactsToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            contacts = new ContactBook(data, savedContactList);
            this.calendarPanel.Hide();
            contacts.TopLevel = false;
            contacts.TopMost = true;
            this.Controls.Add(contacts);
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contacts.Anchor = AnchorStyles.Left;
            this.contacts.Anchor = AnchorStyles.Right;
            contacts.Show();
            this.Text = "Contact View";
        }
        

        private void WeeklyViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contacts.Hide();
            this.calendarPanel.Show();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            TempDate = dateTimePicker1.Value;
            //Update show month
            monthLabel.Text = MonthText;
            //monthLabel.Update(); 

            //set monthdays
            //get weekstart
            weekStart = getStartofWeek(TempDate);

            updateDayPanels(); 
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

        private void newRecord_Click(object sender, EventArgs e)
        {
            
            CalendarRecord record = new CalendarRecord(data, savedContactList, events);
            record.Activate();
            record.Show();
           
        }

        private void tIMEUSAGEREPORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report report = new Report(data, events); 
        }
    }
}