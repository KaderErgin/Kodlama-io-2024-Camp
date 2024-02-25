using KodlamaioDemo.Entities.Concrete;

namespace Kodlamaio_Demo.Business.Abstract;

public interface ICourseService
{
    List<Course> GetAll();
    void Add(Course course);
    void Update(Course course);
    void Delete(int courseId);
}
