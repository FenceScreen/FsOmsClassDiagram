namespace FsOmsClassDiagram {
  public class Address {
    public int Id { get; set; }
    public int ReferenceId { get; set; }
    public string AddressType { get; set; }
    public string LineOne { get; set; }
    public string LineTwo { get; set; }
    public string LineThree { get; set; }
    public string City { get; set; }
    public string StateProvince { get; set; }
    public string PostalCode { get; set; }
    public string CountryRegion { get; set; }
    public string Note { get; set; }
  }
}