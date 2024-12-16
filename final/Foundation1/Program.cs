using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Innovative Product Launch 2024", "TechCorp", 420);
        video1.AddComment(new Comment("Alice", "Exciting launch! Can't wait to try it."));
        video1.AddComment(new Comment("Bob", "Great presentation, well done."));
        video1.AddComment(new Comment("Charlie", "Looking forward to more details."));
        videos.Add(video1);

        Video video2 = new Video("How to Use SmartWidget Pro", "GadgetGuru", 600);
        video2.AddComment(new Comment("Dave", "Very informative tutorial."));
        video2.AddComment(new Comment("Eve", "Helped me set up my device."));
        video2.AddComment(new Comment("Frank", "Thanks for the clear instructions."));
        videos.Add(video2);

        Video video3 = new Video("Unboxing the New GearMaster 3000", "ReviewHub", 350);
        video3.AddComment(new Comment("Grace", "Can't wait to get mine!"));
        video3.AddComment(new Comment("Heidi", "Looks amazing."));
        video3.AddComment(new Comment("Ivan", "Great review, very helpful."));
        videos.Add(video3);

        Video video4 = new Video("Behind the Scenes: Making of SuperGadget", "TechCorp", 800);
        video4.AddComment(new Comment("Judy", "Loved the insights into the production process."));
        video4.AddComment(new Comment("Karl", "Amazing to see the effort put into this."));
        video4.AddComment(new Comment("Laura", "Great content, keep it up!"));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            video.Display();

            foreach (Comment comment in video._comments)
            {
                comment.Display();
            }
            Console.WriteLine();
        }
    }
}
