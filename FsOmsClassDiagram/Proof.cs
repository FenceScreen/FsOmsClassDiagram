using System.Collections.Generic;
using System.Linq;

namespace FsOmsClassDiagram {
  public class Proof {
    public int Id { get; set; }
    public int RevisionNumber { get; set; }
    public bool Approved => Panels.All(x => x.Approval != null);
    public ProofCheckList ProofCheckList { get; set; }
    public IEnumerable<Panel> Panels { get; set; }
    public ICollection<Message> Messages { get; set; }
  }
}