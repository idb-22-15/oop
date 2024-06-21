
using System;

namespace EventExample
{
  // Определение класса с событием
  class EventPublisher
  {
    private Action<int> _myEvent;

    // Определение события с заданной сигнатурой: void (int)
    public event Action<int>? MyEvent
    {
      add
      {
        Console.WriteLine("Подписка");
        _myEvent += value;
      }
      remove
      {
        Console.WriteLine("Отписка");
        _myEvent -= value;
      }
    }

    // Метод для вызова события
    public void RaiseEvent(int value)
    {
      _myEvent?.Invoke(value);
    }
  }

  class Program
  {
    // Метод, подходящий под сигнатуру события
    static void EventHandler(int value)
    {
      Console.WriteLine($"Событие вызвано с параметром: {value}");
    }

    static void Main(string[] args)
    {
      EventPublisher publisher = new EventPublisher();

      // Подписка метода на событие
      publisher.MyEvent += EventHandler;

      // Вызов события
      publisher.RaiseEvent(100);

      // Отписка метода от события
      publisher.MyEvent -= EventHandler;
    }
  }
}