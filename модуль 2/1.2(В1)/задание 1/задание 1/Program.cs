using System;
class Student
{
    public string FirstName { get; set; } // добавил свойство имени
    public string LastName { get; set; } // добавил свойство фамилии
    public int Age { get; set; } // добавил свойство возраста
    public double AverageGrade { get; set; } // добавил свойство среднего балла

    // сделал конструктор для создания студента
    public Student(string firstName, string lastName, int age, double averageGrade)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        AverageGrade = averageGrade;
    }
    // написал метод для вывода информации о студенте
    public void PrintInfo()
    {
        Console.WriteLine($"Студент: {LastName} {FirstName}, Возраст: {Age}, Средний балл: {AverageGrade}");
    }
}
class P
{
    static void Main()
    {
        try
        {
            // создал несколько студентов
            Student s1 = new Student("Иван", "Иванов", 20, 4.5);
            Student s2 = new Student("Анна", "Петрова", 19, 4.8);
            Student s3 = new Student("Сергей", "Сидоров", 21, 3.9);

            // вывел информацию о каждом студенте
            Console.WriteLine("Список студентов:");
            s1.PrintInfo();
            s2.PrintInfo();
            s3.PrintInfo();
        }
        catch
        {
            Console.WriteLine("Ошибка!");
        }
    }
}

