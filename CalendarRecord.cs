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
    public partial class CalendarRecord : Form
    {
        DataAccess data;
        List<Model.Contact> contacts;
        List<Event> events;

        bool task;

        public bool Task
        {
            get { return task; }
            set { task = value; }
        }

        bool eventRec;

        public bool EventRec
        {
            get { return eventRec; }
            set { eventRec = value; }
        }

        public CalendarRecord(DataAccess data, List<Model.Contact> contacts, List<Event> events)
        {
            InitializeComponent();
           
            this.data = data;
            this.contacts = contacts;
            this.events = events; 
        }

        private void eventBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (eventBtn.Checked)
            {
                taskBtn.Checked = false;
            }
            this.EventRec = true;
            EventPanel ep = new EventPanel();
            this.dinamicPanel.Controls.Clear();
            this.dinamicPanel.Controls.Add(ep); 
            

        }

        private void taskBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (taskBtn.Checked)
            {
                eventBtn.Checked = false;
            }
            this.Task = true;
            TaskPanel tp = new TaskPanel();
            this.dinamicPanel.Controls.Clear();
            this.dinamicPanel.Controls.Add(tp); 
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
