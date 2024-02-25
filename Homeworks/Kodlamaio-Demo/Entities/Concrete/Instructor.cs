using KodlamaioDemo.Entities.Abstract;

namespace KodlamaioDemo.Entities.Concrete;

public class Instructor : IEntity
{   //Id,FirstName,LastName,EMail
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}
