using System.Collections.Generic;

namespace FsOmsClassDiagram {
  public class Customer {
    public int Id { get; set; }
    public Credentials Credentials { get; set; }
    public string QbListId { get; set; }
    public string CompanyName { get; set; }
    public Address Address { get; set; }
    public string SalesRespId { get; set; }
    public string CustomerType { get; set; }
    public string QbTaxCodeListId { get; set; }
    public string QbTaxItemListId { get; set; } 
    public ICollection<Contact> Contacts { get; set; }
  }
}