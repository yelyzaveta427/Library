namespace Library;

public class Book
{
    private string BookName { get; set; }
    private string YearOfPublication { get; set; }

    public Book(string bookName, string yearOfPublication)
    {
        BookName = bookName;
        YearOfPublication = yearOfPublication;
    }

    public string GetInfo() => $"Book {BookName} has {YearOfPublication} year of publication";
}