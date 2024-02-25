using Kodlamaio_Demo.Business.Concrete;
using KodlamaioDemo.Business.Concrete;
using KodlamaioDemo.DataAccess.Concrete;

InstructorUI instructorOperation = new InstructorUI(new InstructorService(new IMInstructorDal()));
CategoryUI categoryOperation = new CategoryUI(new CategoryService(new IMCategoryDal()));
CourseUI courseOperation = new CourseUI(new CourseService(new IMCourseDal()));
int select;

do
{
    DisplayMenu();
    select = GetUserInput();

    switch (select)
    {
        case 1:
            InstructorTransactions(instructorOperation);
            break;
        case 2:
            CategoryTransactions(categoryOperation);
            break;
        case 3:
            CourseTransactions(courseOperation);
            break;
        case 4:
            Console.WriteLine("\nProgram çıkış\n");
            break;
        default:
            Console.WriteLine("\nHatalı seçim yaptınız tekrar deneyin\n");
            break;
    }

    if (select != 4)
    {
        Console.Write(" Ana menüye geri dönmek için 'Enter' tuşa basın");
        Console.ReadLine();
        Console.Clear();
    }

} while (select != 4);

static void DisplayMenu()
{
    Console.WriteLine("--------------MENU--------------\n");

    Console.WriteLine("1 - Eğitmen İşlemi");
    Console.WriteLine("2 - Kategori İşlemi");
    Console.WriteLine("3 - Kurs İşlemi");

    Console.WriteLine("4 - ÇIKIŞ");

    Console.WriteLine("-----------------------------------\n");
    Console.Write("İşlem yapmak istediğiniz kategoriyi seçin:");
}

static int GetUserInput()
{
    int input;
    while (!int.TryParse(Console.ReadLine(), out input))
    {
        Console.WriteLine("\n Hatalı giriş yaptınız bir sayı girişi yapın\n");
    }
    return input;
}

static void InstructorTransactions(InstructorUI instructorOperation)
{
    Console.WriteLine();
    instructorOperation.GetAll();
    Console.WriteLine();

    Console.WriteLine("1 - Ekle");
    Console.WriteLine("2 - Güncelle");
    Console.WriteLine("3 - Sil");

    Console.WriteLine("4 - Geri");
    Console.Write("Yapmak istediğiniz işlemi seçin: ");
    int operation = GetUserInput();

    switch (operation)
    {
        case 1:
            Console.WriteLine();
            instructorOperation.Add();
            break;
        case 2:
            Console.WriteLine();
            instructorOperation.Update();
            break;
        case 3:
            Console.WriteLine();
            instructorOperation.Delete();
            break;
        case 4:
            break;
        default:
            Console.WriteLine("\nHatalı giriş tekrar deneyin.\n");
            break;
    }
}

static void CategoryTransactions(CategoryUI categoryOperation)
{
    Console.WriteLine();
    categoryOperation.GetAll();
    Console.WriteLine();

    Console.WriteLine("1 - Ekle");
    Console.WriteLine("2 - Güncelle");
    Console.WriteLine("3 - Sil");
    Console.WriteLine("4 - Geri");

    Console.Write("Yapmak istediğiniz işlemi seçin: ");
    int operation = GetUserInput();

    switch (operation)
    {
        case 1:
            Console.WriteLine();
            categoryOperation.Add();
            break;
        case 2:
            Console.WriteLine();
            categoryOperation.Update();
            break;
        case 3:
            Console.WriteLine();
            categoryOperation.Delete();
            break;
        case 4:
            break;
        default:
            Console.WriteLine("\nHatalı seçim yaptınız tekrar deneyin.\n");
            break;
    }
}

static void CourseTransactions(CourseUI courseOperation)
{
    Console.WriteLine();
    courseOperation.GetAll();
    Console.WriteLine();
    Console.WriteLine("1 - Ekle");
    Console.WriteLine("2 - Güncelle");
    Console.WriteLine("3 - Sil");
    Console.WriteLine("4 - Geri");
    Console.Write("Yapmak istediğiniz işlemi seçin: ");
    int operation = GetUserInput();

    switch (operation)
    {
        case 1:
            Console.WriteLine();
            courseOperation.Add();
            break;
        case 2:
            Console.WriteLine();
            courseOperation.Update();
            break;
        case 3:
            Console.WriteLine();
            courseOperation.Delete();
            break;
        case 4:
            break;
        default:
            Console.WriteLine("\nHatalı seçim yaptınız tekrar deneyin.\n");
            break;
    }
}