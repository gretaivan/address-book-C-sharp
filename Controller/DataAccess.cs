using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Configuration;
using System.Threading; 

/*
 * Handles data management commands
 *Could be renamed to contact data manager
 */
namespace CWK2
{
   public class DataAccess
    {
        List<Model.Contact> contacts = new List<Model.Contact>();
        List<Event> events = new List<Event>();
        List<Event> dayEvents = new List<Event>();
        Model.Contact newContact;
        //return contact List
        public List<Model.Contact> getContactList()
        { 
            return contacts; 
        }


        /**
        *CONNECT with
        *using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DB.CnnVal("CalendarDB")))
        *using - means that connection is automatically opened and closed
        */

        public List<Event> dbGetEvents()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DB.ConnectionString("CalendarDB")))
            {
                var eventOutput = connection.Query<Event>($"SELECT * FROM Event").ToList();
                setEventList(eventOutput);
                return events;
            } 
        }
        public List<Event> getEvents()
        {
            return events; 
        }
        /*
         * GET EVENT FOR A SPECIFIC DAY
         */
        public List<Event> getDayEvent(DateTime day) 
        {
            string dayString = $"{day.ToShortDateString()}_%";
            System.Diagnostics.Debug.Write(dayString+"\n");
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DB.ConnectionString("CalendarDB")))
            { 

                var dayEventOutput = connection.Query<Event>($"SELECT * FROM Event WHERE StartDate LIKE '{dayString}'").ToList();
                setDayEventList(dayEventOutput);
                return dayEvents;
            }
        }

        //return list of all contacts
        public List<Model.Contact> GetContacts()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DB.ConnectionString("CalendarDB")))
            {
                var output = connection.Query<Model.Contact>($"SELECT * FROM Contact").ToList();
                setList(output); 
                return contacts;
            }
        }
        public List<Model.Contact> getLocalContacts()
        {
                return contacts;
        }
        public void setList(List<Model.Contact> dbContacts)
        {
            
            for (int i = 0; i < dbContacts.Count; i++)
            {
                contacts.Add(dbContacts.ElementAt(i));     
            }      
        }
        public void setEventList(List<Event> dbEvents)
        {

            for (int i = 0; i < dbEvents.Count; i++)
            {
                events.Add(dbEvents.ElementAt(i));
            }
        }
        public void setDayEventList(List<Event> Events)
        {

            for (int i = 0; i < Events.Count; i++)
            {
                dayEvents.Add(Events.ElementAt(i));
            }
        }
        /*
         * CALLED BY ADD CONTACT FORM
         */
        public bool InsertContact(string name, string lName, string mobNum, string email, string address, string notes, DateTime bday)
        {
            bool status = false;

            //using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DB.ConnectionString("CalendarDB")))
            //{
            //Model.Contact newCont = new Model.Contact(name, lName, mobNum, email, address, notes, bday);
            //newCont.ContactId = contacts.Count;
            //contacts.Add(newCont);

            //try
            //{  //add new contact
            //    connection.Execute("[dbo].[Insert_Contact] @FirstName, @LastName, @MobileNum, @Email, @Address, @Notes, @DateOfBirth", newCont);
            //    System.Diagnostics.Debug.WriteLine("Contact Added");
            //    status = true; 
            //}
            //catch (Exception e)
            //{
            //    System.Diagnostics.Debug.WriteLine(e.ToString());
            //}

            // // Model.Contact newContact = new Model.Contact {FirstName = name, LastName = lName, MobileNum = mobNum, Email = email, Address = address, Notes = notes, DateOfBirth = bday};
            //  //    

            //  //    List<Model.Contact> contacts = new List<Model.Contact>();
            //  //    contacts.Add(newContact);

            //  //    //connection.Execute(sql: $"insert into Contact [FirstName = {name}],[LastName = {lName}]");
            //  //    //insert in database
            //  //    // connection.Execute("dbo.Contact_Insert @FirstName, @LastName, @MobileNum,@Email,@Address,@Notes,@DateOfBirth");
            ////connection.Execute($"Insert_Contact into Contact([FirstName],[LastName], [MobileNum],[Email],[Address],[Notes],[DateOfBirth]) values('{name}','{lName}','{mobNum}','{email}','{address}','{notes}','{bday}')");


            ////    DROP PROCEDURE[dbo].Insert_Contact
            ////GO

            ////CREATE PROCEDURE[dbo].Insert_Contact
            ////(
            ////   @FirstName nvarchar(50),
            ////   @LastName nvarchar(50),
            ////   @MobileNum nvarchar(20),
            ////   @Email nvarchar(50),
            ////   @Address nvarchar(MAX),
            ////   @Notes nvarchar(MAX),
            ////   @DateOfBirth date
            ////)
            ////AS
            ////  
            ////                INSERT INTO Contact
            ////                         (FirstName, LastName, MobileNum, Email, Address, Notes, DateOfBirth)
            ////VALUES(@FirstName, @LastName, @MobileNum, @Email, @Address, @Notes, @DateOfBirth);

            ////                SELECT ContactId, FirstName, LastName, MobileNum, Email, Address, Notes, DateOfBirth FROM Contact WHERE(ContactId = SCOPE_IDENTITY())
            ////GO


            //                //    System.Diagnostics.Debug.WriteLine($"New contact {newContact} added");
            //}



            newContact = new Model.Contact(name, lName, mobNum, email, address, notes, bday);
            newContact.ContactId = contacts.Count;
            contacts.Add(newContact);

            for (int i = 0; i < contacts.Count; i++)
            {
                System.Diagnostics.Debug.WriteLine(contacts.ElementAt(i));
            }

            string contactId = newContact.contactIdString();
            System.Diagnostics.Debug.WriteLine($"New contact {newContact} added");




            ////DB to insert the record
            //status = DB.insert("[dbo].[Contact]", "FirstName, LastName, MobileNum, Email, Address, Notes, DateOfBirth", $"'{name}','{lName}','{mobNum}','{email}','{address}','{notes}','{bday}'");
            ////      status = DB.insert("[dbo].[Contact]", "[FirstName], [LastName], [MobileNum], [Email], [Address], [Notes], [DateOfBirth]", $"N'{name}',N'{lName}',N'{mobNum}',N'{email}',N'{address}',N'{notes}',N'{bday}'");



            /*
             * Add new contact into the database using thread 
             */

            ThreadStart myThreadStart = new ThreadStart(dbInsert);
            Thread connectionThread = new Thread(myThreadStart);
            connectionThread.Start();

            status = DB.insertCont(newContact);


            System.Diagnostics.Debug.WriteLine($"The insert status: {status}");

            return status;
        }

        public void dbInsert()
        {
            DB.insertCont(newContact);
        }
    }
}