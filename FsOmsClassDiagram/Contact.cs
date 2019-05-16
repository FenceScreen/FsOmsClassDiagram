using System.Collections.Generic;

namespace FsOmsClassDiagram {
  public class Contact : Customer {
    public int PhoneNumber { get; set; }
    public ICollection<Job> Jobs { get; set; }
  }
}