using System.Collections.Generic;

namespace FsOmsClassDiagram {
  public class CustomerLocation {
    public int Id { get; set; }
    public bool IsPrimaryLocation { get; set; }
    public string Name { get; set; }
    public Customer Customer { get; set; }
    public int CustomerId { get; set; }
    public Address Address { get; set; }
    public string SalesRespId { get; set; }
    public ICollection<Contact> Contacts { get; set; }
  }
}