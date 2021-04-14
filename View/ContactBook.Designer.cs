namespace CWK2
{
    partial class ContactBook
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
            this.components = new System.ComponentModel.Container();
            this.calendarDataSet = new CWK2.CalendarDataSet();
            this.calendarDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactTableAdapter = new CWK2.CalendarDataSetTableAdapters.ContactTableAdapter();
            this.contactBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contactBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.listContacts = new System.Windows.Forms.ListBox();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.searchBtn = new CWK2.CustButton();
            this.contactPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.newContBtn = new CWK2.CustButton();
            this.editBtn = new CWK2.CustButton();
            this.headerLabel1 = new CWK2.HeaderLabel();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource2)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.contactPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarDataSet
            // 
            this.calendarDataSet.DataSetName = "CalendarDataSet";
            this.calendarDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // calendarDataSetBindingSource
            // 
            this.calendarDataSetBindingSource.DataSource = this.calendarDataSet;
            this.calendarDataSetBindingSource.Position = 0;
            // 
            // contactBindingSource
            // 
            this.contactBindingSource.DataMember = "Contact";
            this.contactBindingSource.DataSource = this.calendarDataSet;
            // 
            // contactTableAdapter
            // 
            this.contactTableAdapter.ClearBeforeFill = true;
            // 
            // contactBindingSource1
            // 
            this.contactBindingSource1.DataMember = "Contact";
            this.contactBindingSource1.DataSource = this.calendarDataSet;
            // 
            // contactBindingSource2
            // 
            this.contactBindingSource2.DataMember = "Contact";
            this.contactBindingSource2.DataSource = this.calendarDataSetBindingSource;
            // 
            // listContacts
            // 
            this.listContacts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listContacts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listContacts.DisplayMember = "ContactId";
            this.listContacts.Font = new System.Drawing.Font("Corbel", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listContacts.FormattingEnabled = true;
            this.listContacts.ItemHeight = 40;
            this.listContacts.Location = new System.Drawing.Point(3, 2);
            this.listContacts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listContacts.Name = "listContacts";
            this.listContacts.ScrollAlwaysVisible = true;
            this.listContacts.Size = new System.Drawing.Size(690, 560);
            this.listContacts.Sorted = true;
            this.listContacts.TabIndex = 2;
            this.listContacts.ValueMember = "ContactId";
            this.listContacts.Click += new System.EventHandler(this.listContacts_Click);
            this.listContacts.SelectedIndexChanged += new System.EventHandler(this.listContacts_SelectedIndexChanged);
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.Font = new System.Drawing.Font("Corbel", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.Location = new System.Drawing.Point(120, 22);
            this.searchBox.Margin = new System.Windows.Forms.Padding(0, 19, 0, 0);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(355, 48);
            this.searchBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Corbel", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name: ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.91191F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.08809F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchBtn, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.searchBox, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 131);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(733, 74);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // searchBtn
            // 
            this.searchBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchBtn.AutoSize = true;
            this.searchBtn.BackColor = System.Drawing.Color.Gray;
            this.searchBtn.Font = new System.Drawing.Font("Corbel", 8.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.Color.White;
            this.searchBtn.Location = new System.Drawing.Point(478, 2);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(252, 69);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // contactPanel
            // 
            this.contactPanel.AutoSize = true;
            this.contactPanel.Controls.Add(this.tableLayoutPanel3);
            this.contactPanel.Controls.Add(this.tableLayoutPanel2);
            this.contactPanel.Controls.Add(this.headerLabel1);
            this.contactPanel.Location = new System.Drawing.Point(8, 38);
            this.contactPanel.Margin = new System.Windows.Forms.Padding(0);
            this.contactPanel.Name = "contactPanel";
            this.contactPanel.Size = new System.Drawing.Size(757, 1061);
            this.contactPanel.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.listContacts, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.newContBtn, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.editBtn, 0, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(27, 229);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.90683F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.91925F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.29814F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(696, 806);
            this.tableLayoutPanel3.TabIndex = 5;
            // 
            // newContBtn
            // 
            this.newContBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.newContBtn.AutoSize = true;
            this.newContBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newContBtn.BackColor = System.Drawing.Color.Gray;
            this.newContBtn.Font = new System.Drawing.Font("Corbel", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newContBtn.ForeColor = System.Drawing.Color.White;
            this.newContBtn.Location = new System.Drawing.Point(3, 604);
            this.newContBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.newContBtn.Name = "newContBtn";
            this.newContBtn.Size = new System.Drawing.Size(690, 99);
            this.newContBtn.TabIndex = 3;
            this.newContBtn.Text = "Add New Contact";
            this.newContBtn.UseVisualStyleBackColor = false;
            this.newContBtn.Click += new System.EventHandler(this.newContBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editBtn.AutoSize = true;
            this.editBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.editBtn.BackColor = System.Drawing.Color.Gray;
            this.editBtn.Font = new System.Drawing.Font("Corbel", 9.900001F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.Location = new System.Drawing.Point(3, 707);
            this.editBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(690, 97);
            this.editBtn.TabIndex = 4;
            this.editBtn.Text = "Edit Contact";
            this.editBtn.UseVisualStyleBackColor = false;
            // 
            // headerLabel1
            // 
            this.headerLabel1.AutoSize = true;
            this.headerLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(116)))), ((int)(((byte)(171)))));
            this.headerLabel1.Font = new System.Drawing.Font("Modern No. 20", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel1.ForeColor = System.Drawing.Color.White;
            this.headerLabel1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.headerLabel1.Location = new System.Drawing.Point(220, 51);
            this.headerLabel1.Name = "headerLabel1";
            this.headerLabel1.Size = new System.Drawing.Size(309, 54);
            this.headerLabel1.TabIndex = 4;
            this.headerLabel1.Text = "Contact Book";
            this.headerLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ContactBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(757, 1097);
            this.Controls.Add(this.contactPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(2000, 2001);
            this.MinimumSize = new System.Drawing.Size(600, 861);
            this.Name = "ContactBook";
            this.Text = "Contact Book";
            this.Load += new System.EventHandler(this.ContactBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.calendarDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.calendarDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactBindingSource2)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.contactPanel.ResumeLayout(false);
            this.contactPanel.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource calendarDataSetBindingSource;
        private CalendarDataSet calendarDataSet;
        private System.Windows.Forms.BindingSource contactBindingSource;
        private CalendarDataSetTableAdapters.ContactTableAdapter contactTableAdapter;
        private System.Windows.Forms.BindingSource contactBindingSource1;
        private System.Windows.Forms.BindingSource contactBindingSource2;
        private CustButton newContBtn;
        private System.Windows.Forms.ListBox listContacts;
        private HeaderLabel headerLabel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchBox;
        private CustButton searchBtn;
        private System.Windows.Forms.Panel contactPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private CustButton editBtn;
    }
}