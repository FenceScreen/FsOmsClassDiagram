using System.Collections.Generic;

namespace FsOmsClassDiagram {
  public class Panel {
    public int Id { get; set; }
    public int  WidthFeet { get; set; }
    public int WidthInches { get; set; }
    public int HeightFeet { get; set; }
    public int HeightInches { get; set; }
    public string Dimensions => $"{WidthFeet}'-{WidthInches}\" x {HeightFeet}'-{HeightInches}\"";
    public int GrommetSpacing { get; set; }
    public string FilePath { get; set; }
    public string Description { get; set; }
    public Approval Approval { get; set; }
    public ICollection<FinishingOption> FinishingOptions { get; set; }
    public Proof Proof { get; set; }
  }
}