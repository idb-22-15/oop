//1. Ссылки на объекты
//2. Виртульные члены класса
//3. Механизмы разделения кода
//4. Механизмы запрета наследования и переопределения
//5. Абстрактные классы и элементы класса


class Program
{
  static void Main()
  {
    task1();
    task2();
    task3();
    task4();
    task5();
  }

  static void task1()
  {

    Person person = new Person();

    // Получение ссылки на объект
    Person reference = person;

    // Использование ссылки для доступа к полям и методам объекта

    Console.WriteLine(reference.Name);
    reference.Name = "qw";
    Console.WriteLine(person.Name);

  }

  static void task2()
  {
    MyClass m = new MyClass();
    MyClass o = new OtherClass();
    m.doSomething();
    o.doSomething();
  }

  static void task3()
  {
    var p = new MyPartial();
    p.hello();
    p.world();
  }

  static void task4()
  {
    var s = new MySealed();
    s.sealedHello();
  }

  static void task5()
  {
    Animal dog = new Dog();
    Animal cat = new Cat();

    dog.MakeSound();
    cat.MakeSound();
    dog.Sleep();
    cat.Sleep();
  }
}

// 1
class Person
{
  public string Name = "ppp";
}


// 2

class MyClass
{
  public virtual void doSomething()
  {
    Console.WriteLine("virtual Hello");
  }
}

class OtherClass : MyClass
{
  public override void doSomething()
  {
    Console.WriteLine("override World");
  }
}

// 3

partial class MyPartial
{
  public void hello()
  {
    Console.WriteLine("partial Hello");

  }
}

partial class MyPartial
{
  public void world()
  {
    Console.WriteLine("partial World");
  }
}


// 4

sealed class MySealed
{
  public void sealedHello()
  {
    Console.WriteLine("sealed Hello");
  }
}

class NotSealed
{
  public virtual void doSomething()
  {
    Console.WriteLine("not seeled virtual Hello");
  }
}

class WithSealedMethod : NotSealed
{
  public sealed override void doSomething()
  {
    Console.WriteLine("sealed override World");
  }
}

//class SealedError : WithSealedMethod {
//  public sealed override void doSomething() {
//    Console.WriteLine("error");
//  }
//}

// 5


public abstract class Animal
{
  // Абстрактный метод, представляющий голос животного
  public abstract void MakeSound();

  // Обычный метод
  public void Sleep()
  {
    Console.WriteLine("Zzz");
  }
}

public class Dog : Animal
{
  // Реализация абстрактного метода MakeSound для собаки
  public override void MakeSound()
  {
    Console.WriteLine("Woof");
  }
}

public class Cat : Animal
{
  // Реализация абстрактного метода MakeSound для кошки
  public override void MakeSound()
  {
    Console.WriteLine("Meow");
  }
}

