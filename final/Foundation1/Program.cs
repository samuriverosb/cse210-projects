using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> listVideos = new List<Video>();

        Video _video1 = new Video("Fantastic Journey", "PewDiePie", 600);
	    Comments _comment1Video1 = new Comments("Samu", "Awesome video man");
	    Comments _comment2Video1 = new Comments("Andi", "Awesome!");
	    Comments _comment3Video1 = new Comments("Rich", "I didn't like it");
	    _video1.SetComments(_comment1Video1);
        _video1.SetComments(_comment2Video1);
        _video1.SetComments(_comment3Video1);

	    Video _video2 = new Video("Movie Trailer", "WatchMojo", 120);
	    Comments _comment1Video2 = new Comments("Samu", "Awful");
	    Comments _comment2Video2 = new Comments("Andi", "Bad movie");
	    Comments _comment3Video2 = new Comments("Rich", "kinda like it");
        _video2.SetComments(_comment1Video2);
        _video2.SetComments(_comment2Video2);
        _video2.SetComments(_comment3Video2);

	    Video _video3 = new Video("Goodbye world", "Technoblade1", 563);
	    Comments _comment1Video3 = new Comments("Samu", "You'll be remembered");
	    Comments _comment2Video3 = new Comments("Andi", "I miss you techno");
	    Comments _comment3Video3 = new Comments("Rich", "RIP");
        _video3.SetComments(_comment1Video3);
        _video3.SetComments(_comment2Video3);
        _video3.SetComments(_comment3Video3);

        listVideos.Add(_video1);
        listVideos.Add(_video2);
        listVideos.Add(_video3);

        Console.Clear();
        foreach(Video video in listVideos)
        {
            video.DisplayVideo();
        }
    }
}