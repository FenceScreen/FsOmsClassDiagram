namespace FsOmsClassDiagram {
  public class JobItem {
    public int Id { get; set; }
    public string Description { get; set; }
    public Job Job { get; set; }
    public JobItemType JobItemType { get; set; }
    public Warehouse Warehouse { get; set; }
    public ItemState ItemState { get; set; }
  }


  //Warehouse to full fillment center
}