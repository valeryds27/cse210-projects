using System;

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {

        Video v1 = new Video();
        v1._title = "Travel Peru";
        v1._author = "Ana";
        v1._length = 300;

        Video v2 = new Video();
        v2._title = "Cooking Pasta";
        v2._author = "Luis";
        v2._length = 600;

        Video v3 = new Video();
        v3._title = "Workout Routine";
        v3._author = "Maria";
        v3._length = 900;

        v1.AddComment(new Comment("Juan", "Nice video!"));
        v1.AddComment(new Comment("Pedro", "I love Peru!"));
        v1.AddComment(new Comment("Sofia", "Great content"));

        v2.AddComment(new Comment("Carlos", "Looks delicious"));
        v2.AddComment(new Comment("Lucia", "I will try this"));
        v2.AddComment(new Comment("Elena", "Easy recipe!"));

        v3.AddComment(new Comment("Miguel", "Very helpful"));
        v3.AddComment(new Comment("Rosa", "Good routine"));
        v3.AddComment(new Comment("Diego", "I will start today"));

        List<Video> videos = new List<Video> { v1, v2, v3 };

        foreach (Video video in videos)
        {
            video.DisplayVideo();
            Console.WriteLine();
        }
    }
}