using KodlamaioDemo.Entities.Concrete;
namespace KodlamaioDemo.DataAccess.Abstract;

public interface IInstructorDal
{
    List<Instructor> GetAll();
    void Add(Instructor instructor);
    void Delete(int instructorId);
    void Update(Instructor instructor);
}
