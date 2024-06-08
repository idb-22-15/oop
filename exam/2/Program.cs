using System;

class MyClass
{
    // Приватный метод для вывода сообщения на консоль
    private void PrintMessage(string message)
    {
        Console.WriteLine("Сообщение из приватного метода: " + message);
    }

    // Публичный метод, который вызывает приватный метод
    public void CallPrivateMethod(string message)
    {
        PrintMessage(message); // Вызов приватного метода из публичного метода
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass();
        myObject.CallPrivateMethod("Привет, мир!"); // Вызов публичного метода, который в свою очередь вызывает приватный метод
    }
}