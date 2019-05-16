using System.Collections.Generic;

namespace FsOmsClassDiagram {
  public class Panel {
    public int Id { get; set; }
    public string  Width { get; set; }
    public string Height { get; set; }
    public string Dimentions => $"{Width}x{Height}";
    public int GrommetSpacing { get; set; }
    public string FilePath { get; set; }
    public string Description { get; set; }
    public Approval Approval { get; set; }
    public ICollection<FinishingOption> FinishingOptions { get; set; }
    public Proof Proof { get; set; }
  }
}