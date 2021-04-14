namespace CWK2
{
    partial class CalendarRecord
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dinamicPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.eventBtn = new System.Windows.Forms.RadioButton();
            this.taskBtn = new System.Windows.Forms.RadioButton();
            this.saveBtn = new CWK2.CustButton();
            this.cancelBtn = new CWK2.CustButton();
            this.headerLabel1 = new CWK2.HeaderLabel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Controls.Add(this.dinamicPanel);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.headerLabel1);
            this.panel1.Location = new System.Drawing.Point(-3, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 1023);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.saveBtn, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.cancelBtn, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 923);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(815, 100);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // dinamicPanel
            // 
            this.dinamicPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dinamicPanel.Location = new System.Drawing.Point(44, 180);
            this.dinamicPanel.Name = "dinamicPanel";
            this.dinamicPanel.Size = new System.Drawing.Size(736, 716);
            this.dinamicPanel.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.eventBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.taskBtn, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(809, 86);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select calendar record type: ";
            // 
            // eventBtn
            // 
            this.eventBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.eventBtn.AutoSize = true;
            this.eventBtn.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eventBtn.Location = new System.Drawing.Point(680, 22);
            this.eventBtn.Name = "eventBtn";
            this.eventBtn.Size = new System.Drawing.Size(126, 41);
            this.eventBtn.TabIndex = 2;
            this.eventBtn.TabStop = true;
            this.eventBtn.Text = "Event";
            this.eventBtn.UseVisualStyleBackColor = true;
            this.eventBtn.CheckedChanged += new System.EventHandler(this.eventBtn_CheckedChanged);
            // 
            // taskBtn
            // 
            this.taskBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.taskBtn.AutoSize = true;
            this.taskBtn.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskBtn.Location = new System.Drawing.Point(492, 22);
            this.taskBtn.Name = "taskBtn";
            this.taskBtn.Size = new System.Drawing.Size(111, 41);
            this.taskBtn.TabIndex = 1;
            this.taskBtn.TabStop = true;
            this.taskBtn.Text = "Task";
            this.taskBtn.UseVisualStyleBackColor = true;
            this.taskBtn.CheckedChanged += new System.EventHandler(this.taskBtn_CheckedChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveBtn.AutoSize = true;
            this.saveBtn.BackColor = System.Drawing.Color.Gray;
            this.saveBtn.Font = new System.Drawing.Font("Corbel", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.ForeColor = System.Drawing.Color.White;
            this.saveBtn.Location = new System.Drawing.Point(471, 3);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(280, 64);
            this.saveBtn.TabIndex = 1;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cancelBtn.AutoSize = true;
            this.cancelBtn.BackColor = System.Drawing.Color.Gray;
            this.cancelBtn.Font = new System.Drawing.Font("Corbel", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.Color.White;
            this.cancelBtn.Location = new System.Drawing.Point(63, 3);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(280, 64);
            this.cancelBtn.TabIndex = 0;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // headerLabel1
            // 
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(116)))), ((int)(((byte)(171)))));
            this.headerLabel1.Font = new System.Drawing.Font("Modern No. 20", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel1.ForeColor = System.Drawing.Color.White;
            this.headerLabel1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.headerLabel1.Location = new System.Drawing.Point(169, 13);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(484, 54);
            this.headerLabel1.TabIndex = 0;
            this.headerLabel1.Text = "New Calendar Record";
            this.headerLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalendarRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(812, 1058);
            this.Controls.Add(this.panel1);
            this.Name = "CalendarRecord";
            this.Text = "CalendarRecord";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private HeaderLabel headerLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton eventBtn;
        private System.Windows.Forms.RadioButton taskBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel dinamicPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private CustButton cancelBtn;
        private CustButton saveBtn;
    }
}