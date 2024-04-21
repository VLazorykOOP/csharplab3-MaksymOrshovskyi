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
//_____________________________________________________task 2

using System;
using System.Collections.Generic;

// Базовий клас Person
class Person
{
    // Захищені поля, які характерні для кожної персони
    protected string name;
    protected int age;

    // Конструктор класу
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Метод для виведення інформації про об'єкт
    public virtual void Show()
    {
        Console.WriteLine($"Ім'я: {name}, Вік: {age}");
    }
}

// Похідний клас для службовця
class Employee : Person
{
    // Додаткове поле для службовця
    protected string department;

    // Конструктор класу
    public Employee(string name, int age, string department) : base(name, age)
    {
        this.department = department;
    }

    // Перевизначений метод для виведення інформації про об'єкт
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Відділ: {department}");
    }
}

// Похідний клас для робітника
class Worker : Person
{
    // Додаткове поле для робітника
    protected string position;

    // Конструктор класу
    public Worker(string name, int age, string position) : base(name, age)
    {
        this.position = position;
    }

    // Перевизначений метод для виведення інформації про об'єкт
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Посада: {position}");
    }
}

// Похідний клас для інженера
class Engineer : Person
{
    // Додаткове поле для інженера
    protected string specialization;

    // Конструктор класу
    public Engineer(string name, int age, string specialization) : base(name, age)
    {
        this.specialization = specialization;
    }

    // Перевизначений метод для виведення інформації про об'єкт
    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Спеціалізація: {specialization}");
    }
}

class Program
{
    static void Main()
    {
        // Створення масиву персон
        List<Person> people = new List<Person>();

        // Наповнення масиву різними об'єктами похідних класів
        people.Add(new Employee("Іван", 30, "Відділ продажу"));
        people.Add(new Worker("Петро", 35, "Електрик"));
        people.Add(new Engineer("Марія", 28, "Інформаційні технології"));

        // Виведення масиву впорядкованого за іменем
        Console.WriteLine("Масив персон впорядкований за іменем:");
        people.Sort((x, y) => String.Compare(x.GetType().Name, y.GetType().Name));
        foreach (var person in people)
        {
            person.Show();
            Console.WriteLine();
        }
    }
}



}
