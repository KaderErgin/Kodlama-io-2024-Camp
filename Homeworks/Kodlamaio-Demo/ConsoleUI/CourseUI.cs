using System;
using System.Linq;
using Kodlamaio_Demo.Business.Abstract;
using KodlamaioDemo.Entities.Concrete;

public class CourseUI
{
    private readonly ICourseService _courseService;
    private int _id, _insructorId, _categoryId, _price;
    private string _name, _description;

    public CourseUI(ICourseService courseService)
    {
        _courseService = courseService;
    }

    public void GetAll()
    {
        Console.WriteLine("ID\tAd\t\tKategori\tEğitmen\tAçıklama\tKurs Açıklaması");
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
        foreach (var course in _courseService.GetAll())
        {
            Console.WriteLine($"{course.Id}\t{course.Name}\t\t{course.CategoryId}\t\t{course.InstructorId}\t\t{course.Description}");
        }
        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
    }

    public void Add()
    {
        Console.Write("\nKurs Id: ");
        while (!int.TryParse(Console.ReadLine(), out _id))
        {
            Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen tekrar deneyin.");
            Console.Write("Kurs Id: ");
        }

        Console.Write("Kategori Id: ");
        while (!int.TryParse(Console.ReadLine(), out _categoryId))
        {
            Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen tekrar deneyin.");
            Console.Write("Kategori Id: ");
        }

        Console.Write("Eğitmen Id: ");
        while (!int.TryParse(Console.ReadLine(), out _insructorId))
        {
            Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen tekrar deneyin.");
            Console.Write("Eğitmen Id: ");
        }

        Console.Write("Kurs Adı: ");
        _name = Console.ReadLine();

        Console.Write("Kurs Açıklaması: ");
        _description = Console.ReadLine();

        Course addCourse = new Course
        {
            Id = _id,
            InstructorId = _insructorId,
            CategoryId = _categoryId,
            Name = _name,
            Price = _price,
            Description = _description
        };

        _courseService.Add(addCourse);
    }

    public void Update()
    {
        Console.Write("\nGüncelleme yapmak istediğiniz kursun Id değerini girin: ");
        while (!int.TryParse(Console.ReadLine(), out _id))
        {
            Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen tekrar deneyin.");
            Console.Write("\nGüncelleme yapmak istediğiniz kursun Id değerini girin: ");
        }

        Course updateCourse = _courseService.GetAll().FirstOrDefault(c => c.Id == _id);

        if (updateCourse == null)
        {
            Console.WriteLine("Belirtilen Id'ye sahip bir kurs bulunamadı.");
            return;
        }

        Console.Write("Eğitmen Id: ");
        while (!int.TryParse(Console.ReadLine(), out _insructorId))
        {
            Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen tekrar deneyin.");
            Console.Write("Eğitmen Id: ");
        }

        Console.Write("Kategori Id: ");
        while (!int.TryParse(Console.ReadLine(), out _categoryId))
        {
            Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen tekrar deneyin.");
            Console.Write("Kategori Id: ");
        }

        Console.Write("Kurs Adı: ");
        _name = Console.ReadLine();

        Console.Write("Kurs Açıklaması: ");
        _description = Console.ReadLine();

        updateCourse.InstructorId = _insructorId;
        updateCourse.CategoryId = _categoryId;
        updateCourse.Name = _name;
        updateCourse.Price = _price;
        updateCourse.Description = _description;

        _courseService.Update(updateCourse);
    }

    public void Delete()
    {
        Console.Write("\nSilmek istediğiniz kursun Id değerini girin: ");
        while (!int.TryParse(Console.ReadLine(), out _id))
        {
            Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen tekrar deneyin.");
            Console.Write("\nSilmek istediğiniz kursun Id değerini girin: ");
        }

        Course deleteCourse = _courseService.GetAll().FirstOrDefault(c => c.Id == _id);

        if (deleteCourse == null)
        {
            Console.WriteLine("Belirtilen Id'ye sahip bir kurs bulunamadı.");
            return;
        }

        _courseService.Delete(_id);
    }
}

