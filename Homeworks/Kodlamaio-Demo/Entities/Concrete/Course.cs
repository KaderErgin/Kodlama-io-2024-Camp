using KodlamaioDemo.Entities.Abstract;

namespace KodlamaioDemo.Entities.Concrete;

public class Course : IEntity
{   //Id,CategoryId,InstructorId,Name,Price,Description
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public int InstructorId { get; set; }
    public string Name { get; set; }
    public int Price { get; set; }
    public string Description { get; set; }
}
