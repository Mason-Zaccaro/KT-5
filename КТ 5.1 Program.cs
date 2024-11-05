public interface IAnimal
{
    string Name { get; set; }
    void MakeSound();
}

public class Dog : IAnimal
{
    public string Name { get; set; }

    public Dog(string name)
    {
        Name = name;
    }

    public void MakeSound()
    {
        Console.WriteLine($"{Name} говорит: Гав");
    }
}

public class Cat : IAnimal
{
    public string Name { get; set; }

    public Cat(string name)
    {
        Name = name;
    }

    public void MakeSound()
    {
        Console.WriteLine($"{Name} говорит: Не ешь меня!");
    }
}

public class Program
{
    public static void Main()
    {
        IAnimal dog = new Dog("Бобик");
        IAnimal cat = new Cat("Барсик");

        dog.MakeSound();
        cat.MakeSound();
    }
}