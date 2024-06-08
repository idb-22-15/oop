using System;

class Program
{
    // Делегат для метода с сигнатурой void (int, string, bool)
    delegate void MyDelegateVoid(int num, string text, bool flag);

    // Делегат для метода с сигнатурой int (int[], double)
    delegate int MyDelegateInt(int[] numbers, double value);

    static void Main(string[] args)
    {
        // Создаем экземпляр делегата для метода void (int, string, bool)
        MyDelegateVoid voidDelegate = new MyDelegateVoid(MyVoidMethod);
        
        // Создаем экземпляр делегата для метода int (int[], double)
        MyDelegateInt intDelegate = new MyDelegateInt(MyIntMethod);

        // Вызываем методы через делегаты
        voidDelegate(10, "Hello", true);
        int result = intDelegate(new int[] { 1, 2, 3 }, 5.5);
        Console.WriteLine($"Результат вызова метода: {result}");
    }

    // Метод, соответствующий сигнатуре void (int, string, bool)
    static void MyVoidMethod(int number, string text, bool flag)
    {
        Console.WriteLine($"Вызван метод MyVoidMethod с параметрами: {number}, {text}, {flag}");
    }

    // Метод, соответствующий сигнатуре int (int[], double)
    static int MyIntMethod(int[] numbers, double value)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum + (int)value;
    }
}