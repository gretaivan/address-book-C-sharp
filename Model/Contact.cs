using System;
using System.Collections.Generic;
using System.Text;


namespace Model
{
    public class Contact
    {
        public int ContactId { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MobileNum { get; set; }
        public string Email {
            get; set; 
            //get { return Email; } 
            //set { 
            //    if (IsValidEmail(value))
            //    {
            //        Email = value;
            //    }
            //    else {
            //        throw new Exception("Invalid Email"); 
            //    }
            //} 
        }
        public string Address { get; set; }
        public string Notes { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string contactIdString()
        {
            string id = ContactId.ToString();
            return id;
        }

        public string FullName 
        {
            get { return $"{FirstName} {LastName}"; }
        }
        public Contact()
        {
        //    FirstName = "Empty Name";
        //    LastName = "Empty Last name";
        //    MobileNum = "Empty";
        }
        public Contact(string fn, string ln, string mn, string em, string addr, string notes)
        {
            FirstName = fn;
            LastName = ln;
            MobileNum = mn;
            Email = em;
            Address = addr;
            Notes = notes;
        }

        public Contact( string fn, string ln, string mn, string em, string addr, string notes, DateTime bday)
        {
            FirstName = fn;
            LastName = ln;
            MobileNum = mn;
            Email = em;
            Address = addr;
            Notes = notes;
            DateOfBirth = bday;
        }


        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


        public override string ToString()
        {
            var str = new StringBuilder();
            str.AppendLine(contactIdString());
            str.AppendLine(FirstName);
            str.AppendLine(LastName);
            str.AppendLine(MobileNum);
            str.AppendLine(Email);
            str.AppendLine(Address);
            str.AppendLine(Notes);
            str.AppendLine(DateOfBirth.ToString());

            return str.ToString(); 
        }
    }
}
