using Library;

class Program
{
    static void Main()
    {
        var library = new Library.Library();
        Book b1 = new Book("Kobzar", "1840");
        b1.GetInfo();
        Book b2 = new Book("City", "1932");
        b2.GetInfo();
        library.AddMaterial(b1);
        library.AddMaterial(b2);
        library.ShowAllMaterials();
        
        
    }
}