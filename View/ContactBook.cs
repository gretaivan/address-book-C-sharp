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
    public partial class ContactBook : Form
    {
       

        public ContactBook(DataAccess data, List<Model.Contact> contacts)
        {
            InitializeComponent();
            this.contacts = contacts;
            this.data = data;

            for (int i = 0; i < contacts.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine("Add contact contact list: " + contacts.ElementAt(i));
            }

            
        }
        //load data when this form loads
        private void ContactBook_Load(object sender, EventArgs e)
        {
            //populateContacts();
            //get all contacts
            //contacts = data.getLocalContacts();
            //the populated data box is same as contact list
            
            listContacts.DataSource = contacts;
            //display info only full name
            listContacts.DisplayMember = "FullName";
            listContacts.Update();
        }




        //name in the list selected
        private void listContacts_Click(object sender, EventArgs e)
        {
            Model.Contact c = new Model.Contact();

            string ab = listContacts.GetItemText(listContacts.SelectedItem.ToString());
            string selected = listContacts.SelectedItem.ToString();
            MessageBox.Show(selected);



            // contacts.Find()
            System.Diagnostics.Debug.WriteLine(ab);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.Write($"search pressed with name {searchBox.Text}");
            string findName = searchBox.Text;
 
            Model.Contact found = new Model.Contact();
            
                for (int i = 0; i < contacts.Count; i++)
                {

                    if (contacts.ElementAt(i).FirstName.Equals(findName))
                    {
                        MessageBox.Show($"Contact with name: {findName} has been found\n {contacts.ElementAt(i).ToString()}");
                        return;
                    }
                }     
                MessageBox.Show($"Contact with name: {findName} has not been found");
            //    //DataAccess data = new DataAccess();
            //    //list contains people with specific name
            //    contacts = data.GetContacts(searchBox.Text); 
        }
        private void listContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // string index = listContacts.SelectedValue.ToString();
            //MessageBox.Show(index);

        }

        private void newContBtn_Click(object sender, EventArgs e)
        {
            AddContact newContact = new AddContact(data, contacts);
            //this.Close();
            newContact.Activate();
            newContact.Show();
            this.Dispose(); 


            //Model.Contact newCont = new Model.Contact();

            //the populated data box is same as contact list
           // listContacts.DataSource = contacts;
            //listContacts.Update();
            //display info only full name
          //  listContacts.DisplayMember = "FullName";

        }

        public void RefreshContactBook()
        {
            MainView mw = new MainView(); 

            this.Activate();
            this.Show(); 
            
           
            contacts = data.getLocalContacts();
            for (int i = 0; i < contacts.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine("Contact book REFRESHED contact list: " + contacts.ElementAt(i));
            }


            //the populated data box is same as contact list
            listContacts.DataSource = contacts;
            //display info only full name
            
            listContacts.DisplayMember = "FullName";
            this.Update(); 
            
        }

        List<Model.Contact> contacts;
        DataAccess data;
    }
  
}
