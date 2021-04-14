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
    public partial class CustButton : Button
    {

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            //this.OnMouseDown(e);
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ForeColor = System.Drawing.Color.Black;
            // active = true;
        }

        private void btn_MouseUp(object sender, MouseEventArgs e)
        {
            //this.OnMouseUp(e);
            this.BackColor = System.Drawing.Color.Gray;
            this.ForeColor = System.Drawing.Color.White;
            // active = false;
        }

        public CustButton()
        {
            InitializeComponent();
        }
        
    }
}
