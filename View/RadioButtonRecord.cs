using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CWK2
{
    public partial class RadioButtonRecord : UserControl
    {
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

        public RadioButtonRecord()
        {
            InitializeComponent();
        }
        private void eventRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (eventRadioButton.Checked)
            {
                taskRadioButton.Checked = false;
            }
            this.EventRec = true;
        }
        private void taskRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (taskRadioButton.Checked)
            {
                eventRadioButton.Checked = false;
            }
            this.Task = true;
        }
    }
}
