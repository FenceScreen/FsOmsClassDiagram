using System.Collections.Generic;

namespace FsOmsClassDiagram {
  public class Warehouse {
    public int Id { get; set; }
    public string Name { get; set; }
    public ICollection<JobItemType> SupportedItemTypes { get; set; }
  }
}