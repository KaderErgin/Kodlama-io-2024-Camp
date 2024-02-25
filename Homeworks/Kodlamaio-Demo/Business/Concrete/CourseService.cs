using Kodlamaio_Demo.Business.Abstract;
using KodlamaioDemo.DataAccess.Abstract;
using KodlamaioDemo.Entities.Concrete;

namespace Kodlamaio_Demo.Business.Concrete;

public class CourseService : ICourseService
{
    private readonly ICourseDal _courseDal;

    public CourseService(ICourseDal courseDal)
    {
        _courseDal = courseDal;
    }
    public void Add(Course course)
    {
        _courseDal.Add(course);
    }
    public void Delete(int courseId)
    {
        _courseDal.Delete(courseId);
    }
    public List<Course> GetAll()
    {
        return _courseDal.GetAll().ToList();
    }
    public void Update(Course course)
    {
        _courseDal.Update(course);
    }
}
