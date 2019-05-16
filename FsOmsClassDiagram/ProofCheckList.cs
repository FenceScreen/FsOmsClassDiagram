namespace FsOmsClassDiagram {
  public class ProofCheckList {
    public bool QuestionOne { get; set; }
    public bool QuestionTwo { get; set; }
    public bool QuestionThree { get; set; }
    public User DesignerAuthoreddBy { get; set; }
    public User DesignerApprovedBy { get; set; }
    public Proof Proof { get; set; }
  }
}