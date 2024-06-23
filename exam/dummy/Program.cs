
class Dummy<T>
{
  private T value;
  private readonly object obj = new();
  public Dummy(T value)
  {
    this.value = value;
  }

  T Value()
  {
    lock (obj)
    {
      return value;
    }
  }
}

class Program
{
  public static void Main(string[] args)
  {

  }
}


