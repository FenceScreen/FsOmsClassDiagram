namespace FsOmsClassDiagram {
  public class Credentials {
    public string Username { get; set; }
    public string PasswordHash { get; set; }
    public string PasswordSalt { get; set; }
    public Role Role { get; set; }
  }
}