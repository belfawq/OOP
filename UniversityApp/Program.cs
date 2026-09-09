using OOP.Models;

Student student1 = new()
{
    Name = "Іван Петренко",
    Group = "КН1-Б25" 
};

Student student2 = new()
{
    Name = "Олена Коваль",
    Group = "КН-22"
};

Subject subject1 = new()
{
    Name = "Об'єктно орієнтоване програмування",
    Hours = 210
};

Subject subject2 = new()
{
    Name = "Бази даних",
    Hours = 180
};

Console.WriteLine("Студенти: ");
Console.WriteLine($"{student1.Name}, група {student1.Group}");
Console.WriteLine($"{student2.Name}, група {student2.Group}");

Console.WriteLine("\nДисципліни:");
Console.WriteLine($"{subject1.Name} - {subject1.Hours} год.");
Console.WriteLine($"{subject2.Name} - {subject2.Hours} год.");