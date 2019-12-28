using System.Collections.Generic;
using System.Linq;

namespace FsOmsClassDiagram {
  public class Customer {
    public int Id { get; set; }
    public string QbListId { get; set; }
    public string Name { get; set; }
    public string CustomerType { get; set; }
    public string QbTaxCodeListId { get; set; }
    public string QbTaxItemListId { get; set; }
    //Tags
    public CustomerLocation PrimaryLocation => Locations.FirstOrDefault(x => x.IsPrimaryLocation);
    public ICollection<CustomerLocation> Locations { get; set; }
  }
}

//Add Customer with default location and primary contact
//Update customer
//Customer has to have at least one contact and one location - If there is only one it has to be primary
//Add/Remove/Edit Location - one contact is required 
//Add/Remove/Edit Contact


    //Search customers by name / Paging
//Default Flatten ViewModel - with primary location and all the contacts for the primary location - count of all contact and  - List of all the locations (Name/Id)
// GET API you pass id and I will return this view model 
// GET API to list all the locations for the current customer
// GET API TO list all the contacts for the current location
