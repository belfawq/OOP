using System;
using RestaurantApp.Models;

try 
{
    // 1. Створення об'єктів через конструктор
    Customer customer1 = new Customer("Ярослав Губарик");
    Customer customer2 = new Customer("Анастасія Сурженко");

    Dish dish1 = new Dish("Борщ український", "Перші страви", 120.50);
    Dish dish2 = new Dish("Стейк із лосося", "Основні страви", 350.00);

    Console.WriteLine("--- Меню ресторану ---");
    Console.WriteLine($"{dish1.Name} - {dish1.Price} грн. Доступно: {dish1.IsAvailable}");
    Console.WriteLine($"{dish2.Name} - {dish2.Price} грн. Доступно: {dish2.IsAvailable}");

    // 2. Демонстрація керування станом
    Console.WriteLine("\n[Увага] Закінчився лосось на кухні!");
    dish2.MakeUnavailable();
    Console.WriteLine($"{dish2.Name} - доступно: {dish2.IsAvailable}");

    // 3. Демонстрація валідації (викличе виняток)
    Console.WriteLine("\n[Тест] Спроба змінити ціну борщу на від'ємну...");
    dish1.Price = -50; 
    
    // Рядок нижче ніколи не виконається, бо програма виб'є помилку на рядку вище
    Console.WriteLine("Цей текст не виведеться"); 
}
catch (ArgumentException ex)
{
    // Відловлюємо нашу помилку і гарно виводимо в консоль
    Console.WriteLine($"\nПОМИЛКА ВАЛІДАЦІЇ: {ex.Message}");
}