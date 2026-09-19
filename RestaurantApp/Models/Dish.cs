namespace RestaurantApp.Models;

public class Dish
{
    private string _name;
    private string _category;
    private double _price;

    public string Name 
    { 
        get { return _name; }
        set 
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Назва страви не може бути порожньою!");
            _name = value;
        }
    }

    public string Category 
    { 
        get { return _category; }
        set 
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Категорія не може бути порожньою!");
            _category = value;
        }
    }

    public double Price 
    { 
        get { return _price; }
        set 
        {
            // Валідація: ціна повинна бути додатною
            if (value <= 0)
                throw new ArgumentException("Ціна страви повинна бути більшою за нуль!");
            _price = value;
        }
    }

    // Властивість стану. get - публічний (читати можуть всі), set - приватний (змінювати тільки всередині класу)
    public bool IsAvailable { get; private set; }

    public Dish(string name, string category, double price)
    {
        Name = name;
        Category = category;
        Price = price;
        IsAvailable = true; // При створенні страва автоматично доступна
    }

    // Методи керування станом
    public void MakeAvailable()
    {
        IsAvailable = true;
    }

    public void MakeUnavailable()
    {
        IsAvailable = false;
    }
}