using System.Collections.Generic;
using System.Linq;

namespace FsOmsClassDiagram {
  public class Customer {
    public int Id { get; set; }
    public Credentials Credentials { get; set; }
    public string QbListId { get; set; }
    public string CompanyName { get; set; }
    public string SalesRespId { get; set; }
    public string CustomerType { get; set; }
    public string QbTaxCodeListId { get; set; }
    public string QbTaxItemListId { get; set; }
    public CustomerLocation PrimaryLocation => Locations.FirstOrDefault(x => x.IsPrimaryLocation);
    public ICollection<Contact> Contacts { get; set; }
    public ICollection<CustomerLocation> Locations { get; set; }
  }
}