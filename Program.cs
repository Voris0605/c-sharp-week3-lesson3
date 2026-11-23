Shop shop = new Shop();

Phone phone1 = new Phone("iPhone 15", 999, 128);
Phone phone2 = new Phone("Samsung S24", 899, 256);
Car car1 = new Car("Toyota Camry", 25000, 2022);
Car car2 = new Car("BMW X5", 60000, 2023);

// Добавляем товары
shop.AddProduct(phone1);
shop.AddProduct(phone2);
shop.AddProduct(car1);
shop.AddProduct(car2);

Console.WriteLine("Список товаров:");
shop.PrintProductList();

// Добавляем новый товар
Console.WriteLine("\nДобавляем новый товар:");
shop.AddProduct(new Phone("Xiaomi 14", 700, 256));

// Выводим список
Console.WriteLine("\nСписок после добавления:");
shop.PrintProductList();

// Удаляем один продукт
Console.WriteLine("\nУдаляем BMW X5:");
shop.RemoveProduct(car2);

Console.WriteLine("\nСписок после удаления:");
shop.PrintProductList();
