using System;

// Базовый класс
class BaseClass
{
    // Автоматически реализуемые свойства
    public string StringProperty { get; set; }
    public bool BoolProperty { get; set; }

    // Конструктор с параметрами
    public BaseClass(string str, bool b)
    {
        StringProperty = str;
        BoolProperty = b;
    }
}

// Наследник базового класса
class DerivedClass : BaseClass
{
    // Конструктор с параметрами вызывает конструктор базового класса
    public DerivedClass(string str, bool b) : base(str, b)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите размер массива: ");
        int size = int.Parse(Console.ReadLine());

        DerivedClass[] array1 = new DerivedClass[size];
        DerivedClass[] array2 = new DerivedClass[size];

        // Заполнение массивов произвольными значениями
        Random random = new Random();
        for (int i = 0; i < size; i++)
        {
            // Генерация случайной строки и случайного булевого значения
            string str1 = Guid.NewGuid().ToString().Substring(0, 8);
            bool bool1 = random.Next(2) == 0; // true или false

            string str2 = Guid.NewGuid().ToString().Substring(0, 8);
            bool bool2 = random.Next(2) == 0; 

            // Создание объектов класса DerivedClass и добавление в массивы
            array1[i] = new DerivedClass(str1, bool1);
            array2[i] = new DerivedClass(str2, bool2);
        }

        // Вывод информации о чаще встречающемся значении false
        int countFalseArray1 = CountFalse(array1);
        int countFalseArray2 = CountFalse(array2);
        Console.WriteLine($"В массиве 1 значение false встречается {countFalseArray1} раз(а)");
        Console.WriteLine($"В массиве 2 значение false встречается {countFalseArray2} раз(а)");
        Console.WriteLine(countFalseArray1 > countFalseArray2 ? "В массиве 1 чаще встречается значение false." : "В массиве 2 чаще встречается значение false.");
    }

    // Метод для подсчета количества значений false в массиве
    static int CountFalse(DerivedClass[] array)
    {
        int count = 0;
        foreach (var item in array)
        {
            if (!item.BoolProperty)
            {
                count++;
            }
        }
        return count;
    }
}