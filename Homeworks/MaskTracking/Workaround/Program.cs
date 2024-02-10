using Business.Concrete;
using Entities.Concrete;

SelamVer("Kader"); 
SelamVer("Ahmet");
SelamVer("Ayşe");
SelamVer();

int sonuc = Topla(6, 58);
//Diziler(Arrays)
string student1 = "Kader";  
string student2 = "Kerem";
string student3 = "Berkay";

Console.WriteLine(student1);
Console.WriteLine(student2);
Console.WriteLine(student3);

string[] students = new string[3];
students[0] = "Kader";  
students[1] = "Kerem";
students[2] = "Berkay";

students = new string[4];
students[3] = "İlker";

for (int i = 0; i < students.Length; i++)
{
    Console.WriteLine(students[i]);
}

string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Antalya", "Diyarbakır" };
cities2 = cities1;
cities1[0] = "Adana";
Console.WriteLine(cities2[0]);

Person person1 = new Person();
person1.FirstName = "KADER";
person1.LastName = "ERGİN";
person1.DateOfBirthYear = 2000;
person1.NationalIdentity = 1221352586;

Person person2 = new Person();
person2.FirstName = "Murat";

foreach(string city in cities1)
{
    Console.WriteLine(city);
}
 //Mylist
List<string> newCities1 = new List<string> { "Ankara 1", "Istanbul 1", "İzmir 1" };
newCities1.Add("Adana 1");
foreach(var city in newCities1)
{
    Console.WriteLine(city);
}

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);

Console.ReadLine();
static void Variables()
{
    string message = "Merhaba";
    double amount = 100000; 
    int number = 100;
    bool inLogged = false;

    string name = "Kader";
    string surname = "Ergin";
    int birthYear = 2000;
    long tcNo = 12345678910;

    Console.WriteLine(amount * 1.18);
    Console.WriteLine(amount * 1.18);
}
 //Resharper
static void SelamVer(string name = "isimsiz")
{
    Console.WriteLine($"Merhaba {name}");
}

static int Topla(int sayi1 = 5, int sayi2 = 10)
{
    int sonuc = sayi1 + sayi2;
    Console.WriteLine($"Toplam: {sonuc.ToString()}");
    return sonuc;
}
