using System;

class Program
{
    static void Main()
    {
        SayaTubeVideo video = null;

        try
        {
            video = new SayaTubeVideo("Tutorial Design By Contract - Aaron Joseph");
            for (int i = 0; i < 10000000; i++)
            {
                video.IncreasePlayCount(1);
            }
        }
        catch (Exception tes)
        {
            Console.WriteLine("Error: " + tes.Message);
        }
        finally
        {
            if (video != null)
            {
                video.PrintVideoDetails();
            }
        }
    }
}