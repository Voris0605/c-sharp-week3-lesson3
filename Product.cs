public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Товар: {Name}, Цена: {Price}");
    }
}

public class Phone : Product
{
    public int Memory { get; set; } // память в ГБ

    public Phone(string name, decimal price, int memory) : base(name, price)
    {
        Memory = memory;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Телефон: {Name}, Цена: {Price}, Память: {Memory} ГБ");
    }
}

public class Car : Product
{
    public int Year { get; set; } // год выпуска

    public Car(string name, decimal price, int year) : base(name, price)
    {
        Year = year;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Автомобиль: {Name}, Цена: {Price}, Год: {Year}");
    }
}