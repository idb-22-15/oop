// Вариант 1

/* 
Описание языка C#
Типы данных языка C#
Структуры данных
Using. Инструкции и директивы
Директива #region
Тип данных Object. Упаковка и распаковка [Boxing-Unboxing]
Тип данных Struct
Массивы
Список List<T>
*/


Solution.CompleteTask(new Task1());
// Solution.CompleteTask(new Task2());
// Solution.CompleteTask(new Task3());

class Solution
{
  public static void CompleteTask(ITask task)
  {
    task.Execute();

  }
}

interface ITask
{
  void Execute();
}


class Task1 : ITask
{
  public void MyWrite(object obj)
  {
    Console.WriteLine(obj);
  }
  public void Execute()
  {
    object obj = 20;
    int x = (string)obj;
    Console.WriteLine(x);

    Console.WriteLine("Введите элементы массива через пробел:");
    string input = Console.ReadLine();

    string[] inputArray = input.Split(' ');

    List<int> arr = new List<int>();

    foreach (string num in inputArray)
    {
      arr.Add(int.Parse(num));
    }
    if (arr.Count < 15) throw new Exception("Должно быть не менее 15 элементов");


    int sumOfPositive = arr.Where(n => n > 0).Sum();

    Console.WriteLine("Сумма положительных элементов массива: " + sumOfPositive);
  }
}

class Task2 : ITask
{
  public void Execute()
  {
    Console.WriteLine("Введите матрицу 5x6");
    const int rows = 5;
    const int cols = 6;
    List<List<int>> matrix = new List<List<int>>();
    readMatrix(matrix, rows, cols);
    // fillMatrix(matrix, rows, cols);
    printMatrix(matrix);

    List<int> maxPositiveArray = matrix.Select(row => row.Max()).Where(n => n > 0).ToList();
    Console.Write("Полученный массив максимальных положительных элементов: ");
    maxPositiveArray.ForEach(n => Console.Write(n + " "));
  }

  void fillMatrix(List<List<int>> matrix, int rows, int cols)
  {

    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
      List<int> row = new List<int>();
      for (int j = 0; j < cols; j++)
      {
        row.Add(random.Next(-100, 101));
      }
      matrix.Add(row);
    }
  }

  void printMatrix(List<List<int>> matrix)
  {
    matrix.ForEach(row =>
    {
      Console.WriteLine();
      row.ForEach(n => Console.Write(n + "\t"));
    });
    Console.WriteLine();
  }

  void readMatrix(List<List<int>> matrix, int rows, int cols)
  {
    while (matrix.Count != rows)
    {
      List<int> row = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
      if (row.Count != cols) throw new Exception("Неверно задана матрица");
      matrix.Add(row);
    }
  }
}

class Task3 : ITask
{
  class Purchase
  {
    public readonly string Product;
    public readonly uint Price;
    public Purchase(string product, uint price)
    {
      Product = product;
      Price = price;
    }
  }
  public void Execute()
  {

    List<Purchase> purchases = new List<Purchase>();
    Console.WriteLine("Введите список покупок в виде: <название> <цена>");

    string input = Console.ReadLine();
    while (input != "")
    {
      string[] parts = input.Split(' ');

      Purchase newPurchase = new Purchase
      (
        parts[0],
        uint.Parse(parts[1])
      );

      purchases.Add(newPurchase);

      input = Console.ReadLine();
    }

    Console.WriteLine("Покупки с ценой не менее 1000: ");

    List<Purchase> min1000 = purchases.Where(p => p.Price >= 1000).ToList();
    min1000.ForEach(p => Console.WriteLine("Название: " + p.Product + ", Цена: " + p.Price));
  }


}

/*

Описание языка C#:
C# (C Sharp) - это современный объектно-ориентированный язык программирования, разработанный компанией Microsoft. Он широко используется для создания разнообразных типов приложений, включая веб-приложения, мобильные приложения, игры, приложения для Windows и многие другие.

Типы значений (Value Types):

Целочисленные типы: int, long, short, byte, sbyte, uint, ulong, ushort, char.
Типы с плавающей точкой: float, double, decimal.
Логический тип: bool.
Перечисления (enum).
Структуры (struct).
Ссылочные типы (Reference Types):

Классы (class).
Интерфейсы (interface).
Массивы.
Строки (string).
Делегаты (delegate).
Другие типы:

Тип object: базовый тип для всех других типов в C#.
powerful features like inheritance, polymorphism, and encapsulation.
Пользовательские типы:

Пользовательские типы данных, созданные программистом с использованием ключевого слова struct или class.


Типы данных языка C#:
Целочисленные типы (Integral Types):

byte, short, int, long
Вещественные типы (Floating-point Types):

float, double
Логический тип (Boolean Type):

bool
Символьный тип (Character Type):

char
Строковый тип (String Type):

string
Типы для работы с временем (DateTime Types):

DateTime, TimeSpan
Перечислимые типы (Enum Types):

enum
Nullable-типы (Nullable Types):

<type>?
Структуры данных:
Структуры данных в C# представляют собой пользовательские типы данных, которые могут содержать различные типы полей. Они могут содержать методы, конструкторы, свойства и события.

Using. Инструкции и директивы:
using в C# используется для обеспечения правильного управления ресурсами, таких как файлы, сетевые соединения и другие объекты, которые требуют освобождения после использования.

Директива #region:
#region в C# используется для организации кода в логические блоки, которые можно сворачивать и разворачивать в среде разработки для удобства навигации и чтения кода.

Тип данных Object. Упаковка и распаковка [Boxing-Unboxing]:
Object является базовым типом для всех других типов в C#. Упаковка (boxing) и распаковка (unboxing) используются для преобразования значимых типов в ссылочные типы и обратно.

Тип данных Struct:
struct в C# используется для создания пользовательских значимых типов данных, которые обычно используются для представления простых объектов с несколькими полями.

Массивы:
Массивы в C# представляют упорядоченные коллекции элементов одного типа. Они могут быть одномерными, многомерными или зубчатыми.

Список List<T>:
List<T> представляет динамический массив, который может изменять свой размер по мере необходимости. Он предоставляет удобные методы для добавления, удаления и доступа к элементам списка.

Это основные концепции и элементы языка C# и структур данных, которые могут быть использованы для разработки различных типов приложений.

*/