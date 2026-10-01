using System;
class Shape
{
    // сделал базовый класс для всех фигур
    public virtual double Area() { return 0; } // виртуальный — можно переопределить
    public virtual double Perimeter() { return 0; }
}
class Circle : Shape
{
    double r; // добавил поле радиуса
    public Circle(double r) { this.r = r; }
    public override double Area() { return Math.PI * r * r; } // написал формулу площади круга // переопределил!
    public override double Perimeter() { return 2 * Math.PI * r; } // написал формулу периметра круга
}
class Rectangle : Shape
{
    double w, h; // добавил поля ширины и высоты
    public Rectangle(double w, double h) { this.w = w; this.h = h; }
    public override double Area() { return w * h; } // написал формулу площади прямоугольника
    public override double Perimeter() { return 2 * (w + h); } // написал формулу периметра прямоугольника
}
class Triangle : Shape
{
    double a, b, c; // добавил поля сторон треугольника
    public Triangle(double a, double b, double c) { this.a = a; this.b = b; this.c = c; }
    public override double Area()
    {
        // написал формулу Герона для площади треугольника
        double p = (a + b + c) / 2;
        return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }
    public override double Perimeter() { return a + b + c; } // написал формулу периметра треугольника
}
class P
{
    static void Main()
    {
        try
        {
            // создал объекты всех трёх фигур
            Circle c = new Circle(5);
            Rectangle r = new Rectangle(4, 6);
            Triangle t = new Triangle(3, 4, 5);
            // вывел площади и периметры каждой фигуры
            Console.WriteLine($"Круг (R=5): площадь={c.Area():F2}, периметр={c.Perimeter():F2}");
            Console.WriteLine($"Прямоугольник (4x6): площадь={r.Area():F2}, периметр={r.Perimeter():F2}");
            Console.WriteLine($"Треугольник (3,4,5): площадь={t.Area():F2}, периметр={t.Perimeter():F2}");
        }
        catch
        {
            Console.WriteLine("Ошибка!");
        }
    }
}