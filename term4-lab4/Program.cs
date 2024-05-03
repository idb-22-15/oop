using System;
using System.Collections;
using System.Reflection;

class Program
{
  static void Main()
  {
    task0();
    task1();
    task2();
    task4();
    task5();
  }
  static void task0()
  {
    int[] array = { 1, 4, 6, 7, 9 };

    // Создание экземпляра коллекции
    MyCollection collection = new MyCollection(array);

    // Перебор элементов коллекции с помощью IEnumerator
    IEnumerator enumerator = collection.GetEnumerator();
    while (enumerator.MoveNext())
    {
      Console.WriteLine(enumerator.Current);
    }
  }

  static void task1()
  {
    // Получаем тип класса ReflectionExample
    Type type = typeof(ReflectionExample);

    // Выводим имя класса
    Console.WriteLine("Имя класса: " + type.Name);

    // Получаем все публичные методы класса
    MethodInfo[] methods = type.GetMethods();
    Console.WriteLine("Публичные методы:");
    foreach (var method in methods)
    {
      Console.WriteLine(method.Name);
    }

    // Получаем все публичные свойства класса
    PropertyInfo[] properties = type.GetProperties();
    Console.WriteLine("Публичные свойства:");
    foreach (var property in properties)
    {
      Console.WriteLine(property.Name);
    }
  }

  static void task2()
  {
    // Создание объектов через интерфейсные ссылки
    IShape shape1 = new Circle(5);
    IShape shape2 = new Rectangle(4, 6);

    // Вычисление площади для каждой фигуры
    Console.WriteLine("Площадь круга: " + shape1.Area());
    Console.WriteLine("Площадь прямоугольника: " + shape2.Area());
  }

  static void task4()
  {
    // Используем итераторный метод для получения четных чисел
    Console.WriteLine("Четные числа до 10:");
    foreach (var number in NumberGenerator.GetEvenNumbers(10)) // четные числа от 0 до 10
    {
      Console.WriteLine(number);
    }

    // Используем итераторный метод для получения чисел Фибоначчи
    Console.WriteLine("\nЧисла Фибоначчи (первые 10):");
    foreach (var number in NumberGenerator.GetFibonacci(10)) // первые 10 чисел Фибоначчи
    {
      Console.WriteLine(number);
    }
  }

  static void task5()
  {
    Bookstore myBookstore = new Bookstore();

    // Установка значений книг с использованием индексатора
    myBookstore[0] = "Book 1";
    myBookstore[1] = "Book 2";
    myBookstore[2] = "Book 3";

    // Выведет "Invalid index"
    myBookstore[15] = "Book 15";

    // Получение значений книг с использованием индексатора
    Console.WriteLine("Book at index 0: " + myBookstore[0]);
    Console.WriteLine("Book at index 1: " + myBookstore[1]);
    Console.WriteLine("Book at index 2: " + myBookstore[2]);
  }
}


// 0

public class MyCollection : IEnumerable
{
  private int[] data;

  public MyCollection(int[] data)
  {
    this.data = data;
  }

  public IEnumerator GetEnumerator()
  {
    return new MyEnumerator(data);
  }
}


// Класс, реализующий интерфейс IEnumerator
public class MyEnumerator : IEnumerator
{
  private int[] data;
  private int position = -1;

  // Конструктор, принимающий массив данных
  public MyEnumerator(int[] data)
  {
    this.data = data;
  }

  // Реализация свойства Current интерфейса IEnumerator
  public object Current
  {
    get
    {
      if (position == -1 || position >= data.Length)
        throw new InvalidOperationException();
      return data[position];
    }
  }

  public bool MoveNext()
  {
    position++;
    return (position < data.Length);
  }

  public void Reset()
  {
    position = -1;
  }
}


// 1

class ReflectionExample
{
  public void Method1() { }
  public void Method2() { }
  public int Property1 { get; set; }
  public string Property2 { get; set; }
}

// 2


// Определение интерфейса
public interface IShape
{
  double Area(); // Метод для вычисления площади фигуры
}

// Реализация интерфейса в классе Circle
public class Circle : IShape
{
  private double radius;

  public Circle(double radius)
  {
    this.radius = radius;
  }

  // Реализация метода Area() для круга
  public double Area()
  {
    return Math.PI * radius * radius;
  }
}

// Реализация интерфейса в классе Rectangle
public class Rectangle : IShape
{
  private double length;
  private double width;

  public Rectangle(double length, double width)
  {
    this.length = length;
    this.width = width;
  }

  // Реализация метода Area() для прямоугольника
  public double Area()
  {
    return length * width;
  }
}

// 3


// 4


public class NumberGenerator
{
  // Итераторный метод, который возвращает четные числа от 0 до указанного предела
  public static IEnumerable<int> GetEvenNumbers(int max)
  {
    for (int i = 0; i <= max; i += 2) // перебираем все четные числа
    {
      yield return i; // возвращаем число, используем ключевое слово yield
    }
  }

  // Итераторный метод, который возвращает числа Фибоначчи до определенного количества
  public static IEnumerable<int> GetFibonacci(int count)
  {
    int a = 0;
    int b = 1;

    for (int i = 0; i < count; i++) // создаем последовательность чисел Фибоначчи
    {
      yield return a; // возвращаем текущее число Фибоначчи
      int temp = a + b;
      a = b;
      b = temp;
    }
  }
}

// 5



public class Bookstore
{
  private string[] books;

  // Конструктор
  public Bookstore()
  {
    books = new string[10]; // Инициализируем массив для 10 книг
  }

  // Индексатор для доступа к книгам по индексу
  public string this[int index]
  {
    get
    {
      // Проверяем допустимость индекса
      if (index >= 0 && index < books.Length)
      {
        return books[index];
      }
      else
      {
        throw new Exception("lol no");
      }
    }
    set
    {
      // Проверяем допустимость индекса
      if (index >= 0 && index < books.Length)
      {
        books[index] = value;
      }
      else
      {
        Console.WriteLine("Invalid index");
      }
    }
  }
}
