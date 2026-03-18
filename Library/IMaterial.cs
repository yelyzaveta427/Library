namespace Library;

public interface IMaterial
{
    string Name { get; }
    string Year { get; }
    bool IsAvailable { get; }
    string GetInfo();
}