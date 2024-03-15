// Вариант 1

Solution.CompleteTask(new Task1());
Solution.CompleteTask(new Task2());
Solution.CompleteTask(new Task3());

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
  public void Execute()
  {
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
