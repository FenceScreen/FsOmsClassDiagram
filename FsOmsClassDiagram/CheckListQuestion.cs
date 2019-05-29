namespace FsOmsClassDiagram {
  public class CheckListQuestion {
    public int Id { get; set; }
    public string QuestionText { get; set; }
    public bool IsComplete { get; set; }
    public CheckList CheckList { get; set; }
  }
}