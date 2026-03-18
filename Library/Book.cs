namespace Library;

public class Book : IMaterial
{
    
    public string Name { get; }
    public string Year { get; }
    public bool IsAvailable { get; private set; }

    public Book(string bookName, string yearOfPublication)
    {
        Name = bookName;
        Year = yearOfPublication;
        IsAvailable = true;
    }
    
    public void Take()
    {
        if (!IsAvailable)
        {
            Console.WriteLine($"Book is not available");
            return;
        }

        IsAvailable = false;
        Console.WriteLine($"Book {Name} is successfully taken");
    }

    public void Return()
    {
        IsAvailable = true;
        Console.WriteLine($"Book {Name} is returned");
    }

    
    public string GetInfo()
    {
        return $"Book {Name} has {Year} year of publication";
    }
}