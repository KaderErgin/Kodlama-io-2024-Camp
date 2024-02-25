using KodlamaioDemo.Entities.Concrete;

namespace Kodlamaio_Demo.Business.Abstract;

public interface IInstructorService
{
    List<Instructor> GetAll();
    void Add(Instructor instructor);
    void Update(Instructor instructor);
    void Delete(int instructorId);

}
