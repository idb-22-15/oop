using System;

// Класс для представления двумерного вектора
class Vec2
{
    // Автоматически реализуемые свойства для координат x и y
    public int X { get; set; }
    public int Y { get; set; }

    // Конструктор с параметрами для инициализации координат вектора
    public Vec2(int x, int y)
    {
        X = x;
        Y = y;
    }

    // Перегрузка оператора "+" для сложения двух векторов
    public static Vec2 operator +(Vec2 v1, Vec2 v2)
    {
        return new Vec2(v1.X + v2.X, v1.Y + v2.Y);
    }

    // Метод для вывода информации о векторе
    public void Display()
    {
        Console.WriteLine($"({X}, {Y})");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Создание двух векторов
        Vec2 vec1 = new Vec2(3, 4);
        Vec2 vec2 = new Vec2(1, 2);

        // Сложение векторов
        Vec2 sum = vec1 + vec2;
        Console.Write("Сумма векторов: ");
        sum.Display();
    }
}