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
    public partial class DayPanel : UserControl
    {
        public DateTime PanelDate { get; set; } 

        public DayPanel()
        {
            InitializeComponent();
        }
    }
}
