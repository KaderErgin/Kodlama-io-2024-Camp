using Kodlamaio_Demo.Business.Abstract;
using KodlamaioDemo.DataAccess.Abstract;
using KodlamaioDemo.Entities.Concrete;

namespace Kodlamaio_Demo.Business.Concrete;

public class InstructorService : IInstructorService
{
    private readonly IInstructorDal _instructorDal;

    public InstructorService(IInstructorDal instructorDal)
    {
        _instructorDal = instructorDal;
    }
    public void Add(Instructor instructor)
    {
        _instructorDal.Add(instructor);
    }
    public void Delete(int instructorId)
    {
        _instructorDal.Delete(instructorId);
    }
    public List<Instructor> GetAll()
    {
        return _instructorDal.GetAll();
    }
    public void Update(Instructor instructor)
    {
        _instructorDal.Update(instructor);
    }
}
