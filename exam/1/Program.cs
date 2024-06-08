using System;

// Объявление класса
class MyClass
{
    public int IntegerParam { get; set; } // Автоматически реализуемое свойство для целочисленного параметра
    public string StringParam { get; set; } // Автоматически реализуемое свойство для строкового параметра

    // Конструктор класса
    public MyClass(int integerParam, string stringParam)
    {
        IntegerParam = integerParam;
        StringParam = stringParam;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размер массива: ");
        int arraySize = int.Parse(Console.ReadLine()); // Чтение размера массива с клавиатуры

        MyClass[] myArray = new MyClass[arraySize]; // Создание массива объектов MyClass

        // Заполнение массива произвольными значениями
        Random random = new Random();
        for (int i = 0; i < arraySize; i++)
        {
            int randomInteger = random.Next(100); // Генерация случайного целого числа до 100
            string randomString = "Element " + i; // Создание строки для элемента
            myArray[i] = new MyClass(randomInteger, randomString); // Создание и добавление нового объекта MyClass в массив
        }

        // Вывод значений элементов массива на консоль
        Console.WriteLine("Элементы массива:");
        for (int i = 0; i < arraySize; i++)
        {
            Console.WriteLine($"Элемент {i}: Целое число - {myArray[i].IntegerParam}, Строка - {myArray[i].StringParam}");
        }
    }
}