using KodlamaioDemo.Entities.Concrete;
namespace KodlamaioDemo.DataAccess.Abstract;

public interface ICourseDal
{
    List<Course> GetAll();
    void Add(Course course);
    void Update(Course course);
    void Delete(int courseId);
}
