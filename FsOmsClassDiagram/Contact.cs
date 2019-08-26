using System.Collections.Generic;

namespace FsOmsClassDiagram {
  public class Contact : User {
    public string JobTitle { get; set; }
    public string WorkPhone { get; set; }
    public string WorkFax { get; set; }
    public string MobilePhone { get; set; }
    public string AlternateEmail { get; set; }
    public bool Primary { get; set; }
    public bool ReceiveJobEmails { get; set; }
    public bool ReceiveMarketingEmails { get; set; }
    public string Note { get; set; }
  }
}