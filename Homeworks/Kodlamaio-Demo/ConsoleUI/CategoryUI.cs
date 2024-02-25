using System;
using System.Linq;
using KodlamaioDemo.Business.Abstract;
using KodlamaioDemo.Entities.Concrete;

public class CategoryUI
{
    private readonly ICategoryService _categoryService;
    private int _id = 0;
    private string _name;

    public CategoryUI(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    public void GetAll()
    {
        Console.WriteLine("ID\tName");
        Console.WriteLine("----------------------------------------------");
        foreach (var category in _categoryService.GetAll())
        {
            Console.WriteLine($"{category.Id}\t{category.Name}");
        }
        Console.WriteLine("----------------------------------------------");
    }
    public void Add()
    {
        Console.Write("Kategori Id: ");
        while (!int.TryParse(Console.ReadLine(), out _id))
        {
            Console.WriteLine("Geçersiz bir değer girdiniz tekrar deneyin.");
            Console.Write("Kategori Id: ");
        }

        Console.Write("Kategori Adı: ");
        _name = Console.ReadLine();

        Category category = new Category
        {
            Id = _id,
            Name = _name
        };

        _categoryService.Add(category);
    }

    public void Delete()
    {
        Console.Write("Silmek istediğiniz kategorinin Id değerini girin: ");
        while (!int.TryParse(Console.ReadLine(), out _id))
        {
            Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen tekrar deneyin.");
            Console.Write("Silmek istediğiniz kategorinin Id değerini girin: ");
        }

        _categoryService.Delete(_id);
    }

    public void Update()
    {
        Console.Write("Güncelleme yapmak istediğiniz kategorinin Id değerini girin: ");
        while (!int.TryParse(Console.ReadLine(), out _id))
        {
            Console.WriteLine("Geçersiz bir değer girdiniz. Lütfen tekrar deneyin.");
            Console.Write("Güncelleme yapmak istediğiniz kategorinin Id değerini girin: ");
        }

        Category updateCategory = _categoryService.GetAll().SingleOrDefault(c => c.Id == _id);

        if (updateCategory == null)
        {
            Console.WriteLine("Belirtilen Id'ye sahip bir kategori bulunamadı.");
            return;
        }

        Console.Write("Kategori Adı: ");
        _name = Console.ReadLine();

        updateCategory.Name = _name;
        _categoryService.Update(updateCategory);
    }
}
