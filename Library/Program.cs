using Library;

class Program
{
    static void Main()
    {
        var library = new Library.Library();
        Book b1 = new Book("Kobzar", "1840");
        library.AddMaterial(b1);
        
        Video v1 = new Video("Macarena", "1234", "12:34");
        library.AddMaterial(v1);

        Magazine m1 = new Magazine("Rose", "1932", "12");
        library.AddMaterial(m1);
        
        b1.Take();
        library.ShowAllMaterials();
        b1.Return();
        library.FindByName("Kobzar");
        library.FilterMaterial();
        
    }
}