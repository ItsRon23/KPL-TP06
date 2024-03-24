using System;
using System.Diagnostics.Contracts;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {

        this.id = GenerateRandomId();
        this.title = title;
        this.playCount = 0;
    }

    private int GenerateRandomId()
    {
        Random random = new Random();
        return random.Next(10000, 99999);
    }

    

    public void PrintVideoDetails()
    {
        Console.WriteLine($"Video ID: {id}");
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Play Count: {playCount}");
    }
}