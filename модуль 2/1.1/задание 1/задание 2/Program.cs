using System;
class Shape
{
    public virtual double Area() { return 0; } // площадь по умолчанию
    public virtual double Perimeter() { return 0; } // периметр по умолчанию
}
class Circle : Shape
{
    private double r; // радиус
    public Circle(double r) { this.r = r; }
    public override double Area() { return Math.PI * r * r; } // площадь круга
    public override double Perimeter() { return 2 * Math.PI * r; } // периметр круга
}
class Rectangle : Shape
{
    private double w, h; // ширина и высота
    public Rectangle(double w, double h) { this.w = w; this.h = h; }
    public override double Area() { return w * h; } // площадь прямоугольника
    public override double Perimeter() { return 2 * (w + h); } // периметр прямоугольника
}
class P
{
    static void Main()
    {
        try
        {
            Console.Write("Введите радиус круга: ");
            double r = double.Parse(Console.ReadLine());
            Circle c = new Circle(r);
            Console.Write("Введите ширину прямоугольника: ");
            double w = double.Parse(Console.ReadLine());
            Console.Write("Введите высоту прямоугольника: ");
            double h = double.Parse(Console.ReadLine());
            Rectangle rect = new Rectangle(w, h);
            Console.WriteLine($"\nКруг (радиус {r}):");
            Console.WriteLine($"Площадь: {c.Area():F2}");
            Console.WriteLine($"Периметр: {c.Perimeter():F2}");
            Console.WriteLine($"\nПрямоугольник ({w} x {h}):");
            Console.WriteLine($"Площадь: {rect.Area():F2}");
            Console.WriteLine($"Периметр: {rect.Perimeter():F2}");
        }
        catch
        {
            Console.WriteLine("Ошибка ввода!");
        }
    }
}