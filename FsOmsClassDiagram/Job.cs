using System.Collections.Generic;

namespace FsOmsClassDiagram {
  public class Job {
    public int Id { get; set; }
    public int EstimateId { get; set; }
    public int InvoiceId { get; set; }
    public Terms Terms { get; set; }
    public int NumberOfProofsRemaining { get; set; }
    public ICollection<Contact> Contacts { get; set; }
    public User Designer { get; set; }
    public User SalesRep { get; set; }
    public IEnumerable<JobItem> Items { get; set; }
    public CustomPrintBreif CustomPrintBreif { get; set; }
    public ICollection<Proof> Proos { get; set; }
    public ICollection<Message> Messages { get; set; }
  }
} 