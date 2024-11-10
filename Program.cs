using System.Security.Cryptography.X509Certificates;

// creating a new object from the initial sample
var trackingSystem = new Homework();

//creating a new object from different styled class
var trackingSystem1 = new Homework1(
    "Inventory Tracking System",
    "Stock Control",
    70
);

//setting fields
trackingSystem.Id = Guid.NewGuid();
//id propery is set as private in class so it gives error
trackingSystem.Title = "Inventory Tracking System";
trackingSystem.Summary = "Stock Control";
trackingSystem.Level = 70;

//print out
Console.WriteLine("{0} (L:{2})\n\t{1}",trackingSystem.Title,trackingSystem.Summary,trackingSystem.Level);
//{0} is a placeholder for trackingSystem,like %d in java. it maps the variables.

//we will define homework again with a different style

class Homework1 {
    // set is private so we can not initialize values outside of class
    public Guid Id { get; private set; }
    public string Title { get; private set; }
    public string Summary { get; private set; }
    public short Level { get; private set; }
    public Homework1(string title, string summary,short level)
    {
        //this is a primary contructor
        Id = Id;
        Title = title;
        Summary = summary;
        Level = level;
    } 
}

// this is an initial sample. it has default behaviours that can be overwritten
class Homework {
    
    Guid _id;
    //we will use setter to set id outside of class
    public void SetID(){
        _id = Guid.NewGuid();
    }

    public Guid Id(){
        return _id;
    }
    public String ? Title;
    // title and summary are string which is located in heap. they can be nullable. to define them as nullable, we use "?"
    public String ? Summary;
    public short Level;

    // override a method to create a Console.WriteLine like function specialized for this class
    public override string ToString()
    {
        return $"{Id}:{Title}(L:{Level})\n\t{Summary}";
    }
}

// keeping a class with only one spesific task is a good practice so we can add another class instead of override
//keep in mind that we can override methods in classes only when the result is dependent on the class and nothing else
class PrintEntity {
    public static string ToString(Homework work){
        return $"{work.Id}:{work.Title}(L:{work.Level})\n\t{work.Summary}";
    }
}