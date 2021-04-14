using System;

namespace CWK2
{
    partial class RadioButtonRecord
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
            this.eventRadioButton = new System.Windows.Forms.RadioButton();
            this.taskRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // radioButtonGreat
            // 
            this.eventRadioButton.AutoSize = true;
            this.eventRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.eventRadioButton.Location = new System.Drawing.Point(3, 4);
            this.eventRadioButton.Name = "radioBtnEvent";
            this.eventRadioButton.Size = new System.Drawing.Size(51, 17);
            this.eventRadioButton.TabIndex = 0;
            this.eventRadioButton.TabStop = true;
            this.eventRadioButton.Text = "Event";
            this.eventRadioButton.UseVisualStyleBackColor = false;
            this.eventRadioButton.CheckedChanged += new System.EventHandler(this.eventRadioButton_CheckedChanged);
            // 
            // radioButtonGood
            // 
            this.taskRadioButton.AutoSize = true;
            this.taskRadioButton.BackColor = System.Drawing.Color.Transparent;
            this.taskRadioButton.Location = new System.Drawing.Point(53, 5);
            this.taskRadioButton.Name = "radioButtonGood";
            this.taskRadioButton.Size = new System.Drawing.Size(39, 17);
            this.taskRadioButton.TabIndex = 1;
            this.taskRadioButton.TabStop = true;
            this.taskRadioButton.Text = "Ok";
            this.taskRadioButton.UseVisualStyleBackColor = false;
       
            // 
            // RadioButtons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.taskRadioButton);
            this.Controls.Add(this.eventRadioButton);
            this.Name = "RadioButtons";
            this.Size = new System.Drawing.Size(101, 27);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

       



        #endregion
        private System.Windows.Forms.RadioButton eventRadioButton;
        private System.Windows.Forms.RadioButton taskRadioButton;
    }
}
