using System;

namespace CWK2
{
    partial class CustButton 
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn.Font = new System.Drawing.Font("Modern No. 20", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn.ForeColor = System.Drawing.SystemColors.Window;
            this.btn.Location = new System.Drawing.Point(0, 0);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(280, 64);
            this.btn.TabIndex = 0;
            this.btn.Text = "CustButton";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            // 
            // CustButton
            // 
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.Font = new System.Drawing.Font("Corbel", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Size = new System.Drawing.Size(280, 64);
            this.Text = "CustButton";
            this.UseVisualStyleBackColor = false;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_MouseUp);
            this.ResumeLayout(false);

        }

 



        #endregion
        private System.Windows.Forms.Button btn;


    }
}
