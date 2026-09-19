namespace RestaurantApp.Models;

public class Customer
{
    private string _name; // Приховане поле

    public string Name 
    { 
        get { return _name; }
        set 
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Ім'я відвідувача не може бути порожнім!");
            
            _name = value;
        }
    }

    // Конструктор для зручного створення об'єкта
    public Customer(string name)
    {
        Name = name; 
    }
}