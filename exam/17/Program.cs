class Program
{
  static void Main(string[] args)
  {
    var t = new Thread(() => WaitForUserInput());

    Console.WriteLine("Нажмите Enter");
    t.Start();
    t.Join();

  }

  static void WaitForUserInput()
  {
    while (true)
    {
      if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
      {
        Console.WriteLine("Вы нажали Enter.");
      }
    }
  }
}
