using System.Collections.Generic;

namespace FsOmsClassDiagram {
  public abstract class CheckList {
    public int Id { get; set; }
    public User AuthoreddBy { get; set; }
    public User ApprovedBy { get; set; }
    public ICollection<CheckListQuestion> Questions { get; set; }
  }
}