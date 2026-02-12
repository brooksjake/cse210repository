using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Video> vids = [
            new Video("Mark Rober", "Something Scientific", 32),
            new Video("Mr Beast", "Big Money", 47),
            new Video("Demolition Ranch", "Shooting Stuff", 23),
            new Video("3blue1brown", "Mathy Fun", 39)
        ];
        
        vids[0]._comments.AddRange(
            new Comment("jason", "boo yeah"),
            new Comment("adam", "unrelated comment"),
            new Comment("john", "what the heck does pushing p mean?")
        );
        
        vids[1]._comments.AddRange(
            new Comment("olivia", "how do i unsubscribe"),
            new Comment("broyeah", "f in the chat bois"),
            new Comment("duderr", "ooof")
        );
        
        vids[2]._comments.AddRange(
            new Comment("kevin", "this guy is cool"),
            new Comment("brisquit", "this vid did not satisfy my hunger"),
            new Comment("breadroll", "come to texas roadhouse")
        );
        
        vids[3]._comments.AddRange(
            new Comment("hungers", "i need a donut"),
            new Comment("sandy", "this reminds me of home"),
            new Comment("spongebob", "hahaha")
        );
        
        foreach(Video v in vids)
        {
            v.Display();
        }
        
    }
}