using System;
interface IDrawable
{
    void Draw(); // метод для вывода информации
}
class Circle : IDrawable
{
    double r;
    public Circle(double r) { this.r = r; }
    public void Draw() { Console.WriteLine($"Круг с радиусом {r}"); }
}
class Rectangle : IDrawable
{
    double w, h;
    public Rectangle(double w, double h) { this.w = w; this.h = h; }
    public void Draw() { Console.WriteLine($"Прямоугольник {w}x{h}"); }
}
class Triangle : IDrawable
{
    double a, b, c;
    public Triangle(double a, double b, double c) { this.a = a; this.b = b; this.c = c; }
    public void Draw() { Console.WriteLine($"Треугольник со сторонами {a}, {b}, {c}"); }
}
class P
{
    static void Main()
    {
        try
        {
            // создаём массив объектов типа IDrawable
            IDrawable[] shapes = new IDrawable[3];
            shapes[0] = new Circle(5);
            shapes[1] = new Rectangle(4, 6);
            shapes[2] = new Triangle(3, 4, 5);

            Console.WriteLine("Фигуры:");
            foreach (IDrawable shape in shapes) shape.Draw(); // вызываем Draw() для каждой фигуры
        }
        catch
        {
            Console.WriteLine("Ошибка!");
        }
    }
}