using RestaurantApp.Models;

Customer customer1 = new()
{
    Name = "Ярослав Губарик"
};

Customer customer2 = new()
{
    Name = "Анастасія Сурженко"
};

Dish dish1 = new()
{
    Name = "Борщ",
    Category = "Перші страви",
    Price = 120.50
};

Dish dish2 = new()
{
    Name = "Стейк",
    Category = "Основні страви",
    Price = 350.00
};

Console.WriteLine("Відвідувачі ресторану:");
Console.WriteLine($"- {customer1.Name}");
Console.WriteLine($"- {customer2.Name}");

Console.WriteLine("\nМеню:");
Console.WriteLine($"{dish1.Name} ({dish1.Category}) - {dish1.Price} грн");
Console.WriteLine($"{dish2.Name} ({dish2.Category}) - {dish2.Price} грн");