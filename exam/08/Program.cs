using System;

// Объявление класса, принимающего два параметра (целочисленный и строковый)
class MyClass
{
    // Автоматически реализуемые свойства для целочисленного и строкового параметров
    public int IntParameter { get; set; }
    public string StringParameter { get; set; }

    // Конструктор с двумя параметрами
    public MyClass(int intValue, string stringValue)
    {
        IntParameter = intValue;
        StringParameter = stringValue;
    }
}

// Объявление обобщенного класса с ограничением на тип данных
class GenericClass<T> where T : MyClass
{
    // Метод, который принимает экземпляр класса MyClass или его наследника
    public void DisplayType()
    {
        Console.WriteLine($"Тип данных: {typeof(T).Name}");
    }
}

// Класс-наследник от MyClass
class MyDerivedClass : MyClass
{
    // Конструктор, вызывающий конструктор базового класса
    public MyDerivedClass(int intValue, string stringValue) : base(intValue, stringValue)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание экземпляра класса MyClass и передача его в качестве аргумента для GenericClass
        MyClass myObject = new MyClass(10, "Пример");
        GenericClass<MyClass> genericObject = new GenericClass<MyClass>();
        genericObject.DisplayType(); // Вывод: Тип данных: MyClass

        // Также можно использовать класс-наследник в качестве типа данных для GenericClass
        MyDerivedClass derivedObject = new MyDerivedClass(20, "Наследник");
        GenericClass<MyDerivedClass> derivedGenericObject = new GenericClass<MyDerivedClass>();
        derivedGenericObject.DisplayType(); // Вывод: Тип данных: MyDerivedClass
    }
}

