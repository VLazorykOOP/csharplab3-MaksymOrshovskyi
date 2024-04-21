using System;

class Triangle
{
    // Захищені поля класу
    protected int a;
    protected int b;
    protected int c;
    protected int color;

    // Конструктор класу Triangle
    public Triangle(int sideA, int sideB, int sideC, int triangleColor)
    {
        a = sideA;
        b = sideB;
        c = sideC;
        color = triangleColor;
    }

    // Методи для виведення довжин сторін трикутника
    public void DisplaySides()
    {
        Console.WriteLine($"Сторони трикутника: {a}, {b}, {c}");
    }

    // Метод для розрахунку периметра трикутника
    public int CalculatePerimeter()
    {
        return a + b + c;
    }

    // Метод для розрахунку площі трикутника за формулою Герона
    public double CalculateArea()
    {
        double p = CalculatePerimeter() / 2.0;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    // Властивості
    public int SideA
    {
        get { return a; }
        set { if (value > 0) a = value; }
    }

    public int SideB
    {
        get { return b; }
        set { if (value > 0) b = value; }
    }

    public int SideC
    {
        get { return c; }
        set { if (value > 0) c = value; }
    }

    public int Color
    {
        get { return color; }
    }
}

class Program
{
    static void Main()
    {
        // Створення екземпляру класу Triangle
        Triangle triangle1 = new Triangle(3, 4, 5, 1);

        // Виведення довжин сторін трикутника
        triangle1.DisplaySides();

        // Розрахунок та виведення периметру
        int perimeter = triangle1.CalculatePerimeter();
        Console.WriteLine($"Периметр трикутника: {perimeter}");

        // Розрахунок та виведення площі
        double area = triangle1.CalculateArea();
        Console.WriteLine($"Площа трикутника: {area}");

        // Приклад отримання коліру трикутника
        Console.WriteLine($"Колір трикутника: {triangle1.Color}");
    }
}
