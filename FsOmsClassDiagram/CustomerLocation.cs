using System.Collections.Generic;

namespace FsOmsClassDiagram {
  public class CustomerLocation { 
    public bool IsPrimaryLocation { get; set; }
    public string Name { get; set; }
    public Address MailingAddress { get; set; }
    public Address BillingAddress { get; set; }
    public ICollection<Contact> Contacts { get; set; }
  }

  //Add new contact to existing location
  //Remove a contact from a location - At least there should be one contact - There has to be a primary contact all the time
  //Edit a contact
}