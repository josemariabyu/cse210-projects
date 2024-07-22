using System;
using System.Collections.Generic;

class Comment
{
    public string Name { get; set; }
    public string Text { get; set; }

    public Comment(string name, string text)
    {
        Name = name;
        Text = text;
    }

    public override string ToString()
    {
        return $"{Name}: {Text}";
    }
}

class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; } // Length in seconds
    private List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetCommentCount()
    {
        return Comments.Count;
    }

    public override string ToString()
    {
        string videoInfo = $"Title: {Title}\nAuthor: {Author}\nLength: {Length} seconds\n";
        videoInfo += $"Number of comments: {GetCommentCount()}\nComments:\n";
        foreach (var comment in Comments)
        {
            videoInfo += $"  - {comment}\n";
        }
        return videoInfo;
    }
}

class Program
{
    static void Main()
    {
        // Create instances of Video
        Video video1 = new Video("C# Tutorial", "John Doe", 300);
        Video video2 = new Video("Cooking Show", "Jane Smith", 180);
        Video video3 = new Video("Travel Vlog", "Emily Davis", 600);

        // Create instances of Comment and add them to videos
        Comment comment1 = new Comment("Alice", "Great video!");
        Comment comment2 = new Comment("Bob", "Very informative.");
        Comment comment3 = new Comment("Charlie", "Loved it!");
        Comment comment4 = new Comment("Dave", "Can't wait for the next episode.");

        video1.AddComment(comment1);
        video1.AddComment(comment2);

        video2.AddComment(comment3);
        video2.AddComment(comment4);

        video3.AddComment(comment1);
        video3.AddComment(comment3);

        // Store videos in a list
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterate through the list of videos and display their information
        foreach (var video in videos)
        {
            Console.WriteLine(video);
            Console.WriteLine(new string('=', 40));
        }
    }
}


   