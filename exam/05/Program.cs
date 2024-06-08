using System;

// Базовый класс с виртуальным и абстрактным методами
abstract class BaseClass
{
    // Абстрактный метод
    public abstract void AbstractMethod();

    // Виртуальный метод
    public virtual void VirtualMethod()
    {
        Console.WriteLine("Вызван виртуальный метод из базового класса");
    }
}

// Наследник от базового класса
class DerivedClass : BaseClass
{
    // Переопределение абстрактного метода
    public override void AbstractMethod()
    {
        Console.WriteLine("Вызван переопределенный абстрактный метод из класса-наследника");
    }

    // Переопределение виртуального метода
    public override void VirtualMethod()
    {
        Console.WriteLine("Вызван переопределенный виртуальный метод из класса-наследника");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание объекта класса-наследника
        DerivedClass derived = new DerivedClass();

        // Вызов переопределенных методов
        derived.AbstractMethod();
        derived.VirtualMethod();
    }
}