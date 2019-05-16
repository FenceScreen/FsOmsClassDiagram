using System;

namespace FsOmsClassDiagram {
  public class Approval {
    public int Id { get; set; }
    public string ContactDigitalSignature { get; set; }
    public bool Approved { get; set; }
    public string DisaprovalNote { get; set; }
    public Contact ActionTakenBy { get; set; }
    public DateTimeOffset ActionTakenOnDateTime { get; set; }
    public Proof Proof { get; set; }
  }
}