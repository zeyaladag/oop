// creating a new object from the initial sample
var trackingSystem = new Homework();

//setting fields
trackingSystem.Id = Guid.NewGuid();
trackingSystem.Title = "Inventory Tracking System";
trackingSystem.Summary = "Stock Control";
trackingSystem.Level = 70;

//print out
Console.WriteLine("{0} (L:{2})\n\t{1}",trackingSystem.Title,trackingSystem.Summary,trackingSystem.Level);
//{0} is a placeholder for trackingSystem,like %d in java. it maps the variables.

// this is an initial sample. it has default behaviours that can be overwritten
class Homework {
    public Guid Id;
    public String Title;
    public String Summary;
    public short Level;

}