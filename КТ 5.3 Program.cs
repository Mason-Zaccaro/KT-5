public interface IComparable<T>
{
    int CompareTo(T other);
}

public class Student : IComparable<Student>
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Grade { get; set; }

    public Student(string name, int age, double grade)
    {
        Name = name;
        Age = age;
        Grade = grade;
    }

    public int CompareTo(Student other)
    {
        if (other == null) return 1;

        // Сначала сравниваем по имени
        int nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);
        if (nameComparison != 0) return nameComparison;

        // Затем сравниваем по возрасту
        if (Age != other.Age) return Age.CompareTo(other.Age);

        // Наконец, сравниваем по оценке
        return Grade.CompareTo(other.Grade);
    }
}

// Класс Book, реализующий интерфейс IComparable<Book>
public class Book : IComparable<Book>
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }

    public Book(string title, string author, double price)
    {
        Title = title;
        Author = author;
        Price = price;
    }
    
    public int CompareTo(Book other)
    {
        if (other == null) return 1;

        // Сначала сравниваем по автору
        int authorComparison = string.Compare(Author, other.Author, StringComparison.Ordinal);
        if (authorComparison != 0) return authorComparison;

        // Затем сравниваем по названию
        int titleComparison = string.Compare(Title, other.Title, StringComparison.Ordinal);
        if (titleComparison != 0) return titleComparison;

        // Наконец, сравниваем по цене
        return Price.CompareTo(other.Price);
    }
}

// Пример использования
public class Program
{
    public static void Main()
    {
        // Создаем список студентов
        List<Student> students = new List<Student>
        {
            new Student("Alice", 20, 85.5),
            new Student("Bob", 22, 90.0),
            new Student("Alice", 20, 80.0)
        };

        // Сортируем список студентов
        students.Sort();

        // Выводим отсортированный список студентов
        Console.WriteLine("Sorted Students:");
        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
        }

        // Создаем список книг
        List<Book> books = new List<Book>
        {
            new Book("Book1", "AuthorA", 25.0),
            new Book("Book2", "AuthorB", 20.0),
            new Book("Book1", "AuthorA", 30.0)
        };

        // Сортируем список книг
        books.Sort();

        // Выводим отсортированный список книг
        Console.WriteLine("\nSorted Books:");
        foreach (var book in books)
        {
            Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Price: {book.Price}");
        }
    }
}