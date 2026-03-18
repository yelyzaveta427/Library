namespace Library;

public class Magazine : IMaterial
{
    public string Name { get; }
    public string Year { get; }
    public bool IsAvailable { get; }
    
    public string IssueNumber { get; }
    
    public Magazine(string magazineName, string yearOfPublication, string issueNumber)
    {
        Name = magazineName;
        Year = yearOfPublication;
        IssueNumber = issueNumber;
    }
    public string GetInfo () => $"{Name} has {Year} of publication and issue number {IssueNumber}";
}