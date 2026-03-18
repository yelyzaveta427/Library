namespace Library;

public class Library
{
    private List<IMaterial> materials = new List<IMaterial>();

    public void AddMaterial(IMaterial material)
    {
        materials.Add(material);
    }

    public void ShowAllMaterials()
    {
        foreach (var b in materials)
        {
            Console.WriteLine(b.GetInfo());
        }
    }

    public void FindByName(string n)
    {
        List<IMaterial> result = new List<IMaterial>();
        foreach (var m in materials)
        {
            if (n == m.Name)
            {
                result.Add(m);
                Console.WriteLine($"Material {m.Name} if found");
            }
            
        }
    }

    public void FilterMaterial()
    {
        foreach (var m in materials)
        {
            if (m is Book || m is Video)
            {
                Console.WriteLine($"Material is filtered. We have now {m.Name}");
            }
        }
    }
}