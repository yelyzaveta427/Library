namespace Library;

public class Video : IMaterial
{
    public string Name { get; }
    public string Year { get; }
    public bool IsAvailable { get; }
    
    public string Duration { get; }

    public Video(string videoName, string yearOfPublication, string duration)
    {
        Name = videoName;
        Year = yearOfPublication;
        Duration = duration;
    }
    public string GetInfo() => $"{Name} has {Year} of publication and {Duration} of video";
}