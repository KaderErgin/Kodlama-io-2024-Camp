using System;
using System.Linq;
using Kodlamaio_Demo.Business.Abstract;
using KodlamaioDemo.Entities.Concrete;

public class InstructorUI
{
    private readonly IInstructorService _instructorService;
    private int _id = 0;
    private string _firstName, _lastName, _email;

    public InstructorUI(IInstructorService instructorService)
    {
        _instructorService = instructorService;
    }
    public void GetAll()
    {
        Console.WriteLine("ID\tAd\tSoyad\t\tE-Mail");
        Console.WriteLine("--------------------------------------------------------------------");
        foreach (var instructor in _instructorService.GetAll())
        {
            Console.WriteLine($"{instructor.Id}\t{instructor.FirstName}\t{instructor.LastName}\t{instructor.Email}");
        }
        Console.WriteLine("--------------------------------------------------------------------");
    }
    public void Delete()
    {
        Console.Write("Silmek istediğiniz eğitmenin Id değerini girin: ");
        while (!int.TryParse(Console.ReadLine(), out _id))
        {
            Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen tekrar deneyin.");
            Console.Write("Silmek istediğiniz eğitmenin Id değerini girin: ");
        }
        _instructorService.Delete(_id);
    }
    public void Add()
    {
        Console.Write("Eğitmen Id: ");
        while (!int.TryParse(Console.ReadLine(), out _id))
        {
            Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen tekrar deneyin.");
            Console.Write("Eğitmen Id: ");
        }
        Console.Write("Eğitmen Ad: ");
        _firstName = Console.ReadLine();
        Console.Write("Eğitmen Soyad: ");
        _lastName = Console.ReadLine();
        Console.Write("Eğitmen E-Mail: ");
        _email = Console.ReadLine();

        Instructor newInstructor = new Instructor
        {
            Id = _id,
            FirstName = _firstName,
            LastName = _lastName,
            Email = _email
        };
        _instructorService.Add(newInstructor);
        Console.WriteLine();
    }

    public void Update()
    {
        Console.Write("\nGüncelleme yapmak istediğiniz eğitmenin Id değerini girin: ");
        while (!int.TryParse(Console.ReadLine(), out _id))
        {
            Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen tekrar deneyin.");
            Console.Write("\nGüncelleme yapmak istediğiniz eğitmenin Id değerini girin: ");
        }
        Instructor result = _instructorService.GetAll().FirstOrDefault(x => x.Id == _id);

        if (result == null)
        {
            Console.WriteLine("Belirtilen Id'ye sahip bir eğitmen bulunamadı.");
            return;
        }

        Console.Write("Eğitmen Adı: ");
        _firstName = Console.ReadLine();
        Console.Write("Eğitmen Soyadı: ");
        _lastName = Console.ReadLine();
        Console.Write("Eğitmen E-Mail: ");
        _email = Console.ReadLine();

        result.FirstName = _firstName;
        result.LastName = _lastName;
        result.Email = _email;
        _instructorService.Update(result);
        Console.WriteLine();
    }
}


