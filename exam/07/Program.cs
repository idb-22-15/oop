using System;

// Объявление обобщенного класса
class GenericClass<T>
{
    // Метод, выводящий название типа данных
    public void DisplayTypeName()
    {
        Console.WriteLine($"Тип данных: {typeof(T).Name}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание экземпляра обобщенного класса с типом данных string
        GenericClass<string> stringInstance = new GenericClass<string>();
        stringInstance.DisplayTypeName(); // Вывод: Тип данных: String

        // Создание экземпляра обобщенного класса с типом данных int
        GenericClass<int> intInstance = new GenericClass<int>();
        intInstance.DisplayTypeName(); // Вывод: Тип данных: Int32

        // Создание экземпляра обобщенного класса с типом данных double
        GenericClass<double> doubleInstance = new GenericClass<double>();
        doubleInstance.DisplayTypeName(); // Вывод: Тип данных: Double
    }
}