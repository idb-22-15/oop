
interface IO
{
  string Read();
  void Write(string str);
  void Log();
}

class MyIO : IO
{
  public string Read()
  {
    return "world";
  }
  public void Write(string str)
  {
    Console.WriteLine("hello " + str);
  }
  public void Log()
  {
    Console.WriteLine("log");
  }
}

class Program
{
  static void Main(string[] args)
  {
    // Создание экземпляра класса MyClass
    MyIO myIo = new MyIO();

    // Использование интерфейсной ссылки для вызова методов
    IO io = myIo;
    string s = io.Read();
    io.Write(s);
    io.Log();

  }
}