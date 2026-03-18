namespace Library;

public class Library
{
    private List<Book> materials = new List<Book>();

    public void AddMaterial(Book b)
    {
        materials.Add(b);
    }

    public void ShowAllMaterials()
    {
        foreach (var b in materials)
        {
            Console.WriteLine(b.GetInfo());
        }
    }

    
}