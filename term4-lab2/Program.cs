// See https://aka.ms/new-console-template for more information
using System;

// Вариант 2

/*
Словарь Dictionary<TKey, TValue>
Тип перечислений Enum
Базовые понятия ООП
модификаторы доступа C#
Классы. Элементы класса
Конструктор и финализатор класса
Наследование
*/

/* 
Уравнение состояния идеального газа (уравнение Менделеева-Клапейрона):
𝑝 ∗ 𝑉 =
𝑚
𝑀
∗ 𝑅 ∗ 𝑇,
где p -Давление идеального газа (Па), V – объем (м3
), m – масса (кг), M – молярная масса
(кг/ моль), R – универсальная газовая постоянная (8.31 Дж/(моль * К)), T – температура (К).
Создать абстрактный базовый класс MCE, в котором создать виртуальный метод для
расчета давления – CalculateVolume, принимающий на вход давление и температуру.
Создать класс-наследник от MCE MendeleevClapeyronEquation, в котором необходимо
объявить все переменные уравнения в виде полей класса (по условиям ОбъектноОриентированного Программирования). Создать поле – константу со значением
универсальной газовой постоянной. Создать конструктор, принимающий параметры:
масса, молярная масса. Через конструктор должно происходить присваивание значений
соответствующим полям класса. В методе CalculateVolume должно происходить
присваивание значений полям: Давление, Температура; а также производиться
соответствующий расчет значения полю Объем. Метод должен вернуть значение объема.
Создать класс MendeleevClapeyronEquationUsing, который должен являться наследником
класса MendeleevClapeyronEquation. В классе MendeleevClapeyronEquationUsing создать
свойство AmountOfSubstance, которое будет возвращать значение физической величины
«Количество вещества (моль)» (внести соответствующие изменения в модификаторы
доступа). Количество вещества рассчитывается как отношение массы к молярной массе
вещества.
Создать представителя класса MendeleevClapeyronEquationUsing в Main. Рассчитать и
вывести значение объема, используя метод CalculateVolume. Вывести значение Количества
вещества. 
*/

#region "This Is MCE"
public abstract class MCE
{
  public abstract double CalculateVolume(double pressure, double temperatureInKelvins);
}
#endregion

public class MendeleevClapeyronEquation : MCE
{
  protected double Pressure;
  protected double Volume;
  protected double TemperatureInKelvins;
  protected double Mass;
  protected double MolarMass;
  protected const double GasConstant = 8.31; // универсальная газовая постоянная

  public MendeleevClapeyronEquation(double mass, double molarMass)
  {
    Mass = mass;
    MolarMass = molarMass;
  }

  public override double CalculateVolume(double pressure, double temperature)
  {
    Pressure = pressure;
    TemperatureInKelvins = temperature;

    Volume = (Mass / MolarMass) * GasConstant * TemperatureInKelvins / Pressure;

    return Volume;
  }
}

public class MendeleevClapeyronEquationUsing : MendeleevClapeyronEquation
{
  public MendeleevClapeyronEquationUsing(double mass, double molarMass) : base(mass, molarMass) { }

  public double AmountOfSubstance
  {
    get { return Mass / MolarMass; }
  }
}

public class Program
{
    static void Main()
    {
        MendeleevClapeyronEquationUsing equation = new MendeleevClapeyronEquationUsing(0.1, 0.02); // Пример значений массы и молярной массы

        double pressure = 1000; 
        double temperatureInKelvins = 300; 

        double volume = equation.CalculateVolume(pressure, temperatureInKelvins);
        double amountOfSubstance = equation.AmountOfSubstance;

        Console.WriteLine("Объем: " + volume + " м3");
        Console.WriteLine("Количество вещества: " + amountOfSubstance + " моль");
    }
}


/*

Словарь Dictionary<TKey, TValue>: Это структура данных в C#, представляющая коллекцию пар ключ-значение, где каждый ключ должен быть уникальным. Методы Add, Remove, ContainsKey позволяют добавлять, удалять и проверять наличие элементов по ключу.

Тип перечислений Enum: Перечисление (Enum) - это тип данных, который состоит из набора именованных констант. Они обеспечивают более читабельный код и предоставляют возможность работы с ограниченным набором значений.

Базовые понятия ООП: ООП (объектно-ориентированное программирование) - это подход к разработке программного обеспечения, основанный на концепциях объектов и классов. Основные принципы ООП включают в себя инкапсуляцию, наследование и полиморфизм.

Модификаторы доступа в C#: Модификаторы доступа управляют видимостью членов класса. Они могут быть public, private, protected, internal или их комбинации. public делает член доступным из любого места кода, private - только из того же класса и т.д.

Классы и элементы класса: Классы - это шаблоны для создания объектов, которые содержат свойства (переменные-члены) и методы (функции-члены). Элементы класса могут включать поля, свойства, методы, события и индексаторы.

Конструктор и финализатор класса: Конструктор - это метод класса, вызываемый при создании нового объекта. Финализатор (деструктор) - метод, вызываемый при уничтожении объекта (обычно используется для освобождения ресурсов). В C# конструктор имеет то же имя, что и класс, а финализатор - тильду (~), за которой следует имя класса.

Наследование: Наследование позволяет создавать новый класс на основе существующего, заимствуя его свойства и методы. Он способствует повторному использованию кода и иерархии объектов. В C# класс может наследовать только один другой класс, но может реализовывать несколько интерфейсов.

Это основные концепции, которые помогут вам лучше понять и использовать C# в ваших проектах. Если у вас есть какие-либо вопросы по отдельным темам или вам нужно более подробное объяснение, не стесняйтесь спрашивать!

*/