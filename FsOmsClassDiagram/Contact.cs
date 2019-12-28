using System.Collections.Generic;

namespace FsOmsClassDiagram
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleInitial { get; set; }
        public string Email { get; set; }
        public string Identity { get; set; }
        public string JobTitle { get; set; }
        public string WorkPhone { get; set; }
        public string WorkFax { get; set; }
        public string MobilePhone { get; set; }
        public string AlternateEmail { get; set; }
        public bool IsPrimaryContact { get; set; }
        public bool ReceiveJobEmails { get; set; }
        public bool ReceiveMarketingEmails { get; set; }
        public string Note { get; set; }
        public ContactType Type { get; set; }
    }

    //Add-Remove-Edit API

    //SalesRep / Dev/ CEO
    public class ContactType
    {
        public string Name { get; set; }
    }
}

//Add new ContactType
//Remove ContactType - Checks if it's not referenced then it will delete it
//Edit 