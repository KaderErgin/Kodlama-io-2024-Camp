using KodlamaioDemo.DataAccess.Abstract;
using KodlamaioDemo.Entities.Concrete;

namespace KodlamaioDemo.DataAccess.Concrete;

public class IMCourseDal : ICourseDal
{
    List<Course> _courses;
    public IMCourseDal()
    {
        _courses = new List<Course>
            {
            new Course {Id=1, CategoryId=  1, InstructorId=1, Name ="C#        ",Description=" Sıfırdan yazılım geliştirme öğreniyoruz."},
            new Course {Id=2, CategoryId=  1, InstructorId=1, Name ="Java      ",Description=" 2 ay süren ücretsiz  bir program, sıfırdan yazılım geliştir"},
            new Course {Id=3, CategoryId=  2, InstructorId=2, Name ="Python    ",Description=" Profesyonel bir programla,sıfırdan yazılım geliştir."},
            new Course {Id=4, CategoryId=  1, InstructorId=1, Name ="Temel     ",Description=" Tüm programlama dilleri için temel programlama mantığını."},
            new Course {Id=5, CategoryId=  1, InstructorId=1, Name ="JavaScript",Description=" 1,5 ay sürecek ücretsiz ve profesyonel bir program."}
            };
    }
    public void Add(Course course)
    {
        _courses.Add(course);
    }

    public void Delete(int courseId)
    {
        _courses.Remove(_courses.SingleOrDefault(c => c.Id == courseId));
    }

    public List<Course> GetAll()
    {
        return _courses.ToList();
    }

    public void Update(Course course)
    {
        Course updateCourse = _courses.SingleOrDefault(c => c.Id == course.Id);
        updateCourse.Id = course.Id;
        updateCourse.InstructorId = course.InstructorId;
        updateCourse.Name = course.Name;
        updateCourse.Description = course.Description;
    }
}
