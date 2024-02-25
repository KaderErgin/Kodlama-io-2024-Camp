using KodlamaioDemo.DataAccess.Abstract;
using KodlamaioDemo.Entities.Concrete;

namespace KodlamaioDemo.DataAccess.Concrete;

public class IMInstructorDal : IInstructorDal
{
    List<Instructor> _instructors;
    public IMInstructorDal()
    {
        _instructors = new List<Instructor>
            {
                new Instructor{Id=1, FirstName="Engin     ", LastName="Demiroğ  ", Email="engin_demirog.gmail.com"},
                new Instructor{Id=2, FirstName="Halit Enes", LastName="Kalaycı  ", Email="halit_kalayci@gmail.com"},
                new Instructor{Id=3, FirstName="Ahmet     ", LastName="Çetinkaya", Email="ahmet_cetinkaya@gmail.com"},
            };
    }

    public void Add(Instructor instructor)
    {
        _instructors.Add(instructor);
    }

    public void Delete(int instructorId)
    {
        Instructor deleteToInstructor = _instructors.SingleOrDefault(i => i.Id == instructorId);
        _instructors.Remove(deleteToInstructor);
    }
    public List<Instructor> GetAll()
    {
        return _instructors.ToList();
    }
    public void Update(Instructor instructor)
    {
        Instructor updateToInstructor = _instructors.SingleOrDefault(i => i.Id == instructor.Id);
        updateToInstructor.FirstName = instructor.FirstName;
        updateToInstructor.LastName = instructor.LastName;
        updateToInstructor.Email = instructor.Email;
    }
}
