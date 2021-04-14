using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CWK2
{
    class HeaderLabel : Label
    {
        public HeaderLabel()
        {
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(116)))), ((int)(((byte)(171)))));
            Font = new System.Drawing.Font("Modern No. 20", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ForeColor = System.Drawing.Color.White;
            ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            Text = "HeaderLabel";
            TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        } 
    }
}
