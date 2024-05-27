using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Creating videos
        Video video1 = new Video
        {
            Title = "Video 1",
            Author = "Author 1",
            LengthInSeconds = 120
        };
        video1.AddComment(new Comment { CommenterName = "User1", Text = "Great video!" });
        video1.AddComment(new Comment { CommenterName = "User2", Text = "I learned a lot from this." });
        videos.Add(video1);

        Video video2 = new Video
        {
            Title = "Video 2",
            Author = "Author 2",
            LengthInSeconds = 180
        };
        video2.AddComment(new Comment { CommenterName = "User3", Text = "Interesting topic." });
        video2.AddComment(new Comment { CommenterName = "User4", Text = "Could be better." });
        videos.Add(video2);

        // Displaying video information
        foreach (Video video in videos)
        {
            video.DisplayInfo();
        }
    }
}