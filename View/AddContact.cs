using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient; 

namespace CWK2
{
    public partial class AddContact : Form
    {
        List<Model.Contact> contacts;
        public AddContact(DataAccess data, List<Model.Contact> contacts)
        {
            InitializeComponent();
            
            this.data = data;
            this.contacts = contacts;

            for (int i = 0; i < contacts.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine("Add contact list contact list: " + contacts.ElementAt(i));
            }
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Debug.WriteLine("Calling DataAccess to insert contact");
            bool status = data.InsertContact(firstName.Text, lastName.Text, mobNum.Text, email.Text, address.Text, notes.Text, dateTimePicker1.Value);

            if (status = false)
            {
                MessageBox.Show("Connection error, contact details stored only locally.");
            }
            else
            {
                MessageBox.Show("Contact has been added");
            }


            //add to data list
            this.Close();


            //CALL METHOD OF CONTACT FORM! perhaps load form it needs to get updated list
           // contacts = data.getLocalContacts();

            for (int i = 0; i < contacts.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine("Add contact list contact list: " + contacts.ElementAt(i));
            }

            MainView cb = new MainView(data, contacts);
            

            //contact form needs to update the record too 
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close(); 
        }
        DataAccess data; 
    }
    
}
