using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Creating videos
        Video video1 = new Video("Introduction to Programming", "John Doe", 300);
        Video video2 = new Video("Multivariable Calculus", "Jane Smith", 450);
        Video video3 = new Video("Machine Learning Basics", "Bob Johnson", 600);

        // Adding comments to videos
        video1.AddComment("Alice", "Great video! Very informative.");
        video1.AddComment("Charlie", "I didn't understand the last part. Can you explain it again?");
        video1.AddComment("Eve", "Thanks for sharing!");

        video2.AddComment("David", "This helped me a lot with my assignment.");
        video2.AddComment("Frank", "Could you provide more examples of vectors in real life?");
        video2.AddComment("Grace", "Nice presentation!");

        video3.AddComment("Hank", "I'm interested in diving deeper into machine learning. Any recommended resources?");
        video3.AddComment("Ivy", "The content was a bit too fast for beginners.");
        video3.AddComment("Jack", "Good job! Looking forward to more videos on this topic.");

        // Putting videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Displaying information for each video
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
        }
    }
}
