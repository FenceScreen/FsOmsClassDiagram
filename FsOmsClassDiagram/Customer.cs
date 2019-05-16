using System.Collections.Generic;

namespace FsOmsClassDiagram {
  public class Customer : User {
    public string QbListId { get; set; }
    public Contact PrimaryContact { get; set; }
    public ICollection<Contact> Contacts { get; set; }
  }
}