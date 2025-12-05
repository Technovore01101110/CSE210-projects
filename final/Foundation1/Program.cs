using System;

class Program
{
    static void Main(string[] args)
    {
        string SPLITTER = "-------------------------------------";

        // Data Set-up Section.
        Video catVideo = new Video("The Funniest Cat Videos Ever",
                                   "Daily Dose of Internet",
                                   "Hello everyone, this is YOUR Daily Dose of Internet. In this video, I show you the best cat videos from the past 10 years.",
                                   1230);
        Video churchMusicVideo = new Video("This Little Light of Mine",
                                           "The Church of Jesus Christ of Latter-Day Saints",
                                           "\"This Little Light of Mine\" is a thoughtful new arrangement by Emma Murdock with a peaceful setting reflecting on the focus of letting Jesus' light shine through us. ",
                                           198);
        Video cseNewsVideo = new Video("CSE Events - Fall 2025 Week 11",
                                       "BYU-I CSE Department",
                                       "Interview Lead: Joe Johnson, Tech Lead: Joe Johnson, Please Come Home for Christmas by Eagles",
                                       73);

        catVideo.AddComment("Cat Guy", "Did that cat do a barrel roll!?");
        catVideo.AddComment("Con222", "That was an amazing save!");
        catVideo.AddComment("Bento280", "NOOOO! Not el gato!");

        churchMusicVideo.AddComment("Steve", "This was such a wonderful production of this song.");
        churchMusicVideo.AddComment("James223", "I am so glad they added this song to the Hymn book.");
        churchMusicVideo.AddComment("IamDisciple22", "Another one added to my amazing music collection.");

        cseNewsVideo.AddComment("Technovore13", "I am so excited for a break.");
        cseNewsVideo.AddComment("VirtualCat12", "I wish it could be longer.");
        cseNewsVideo.AddComment("OGhacker1010", "Lets GOOO EAGLES!!!");

        List<Video> Videos = new List<Video>();
        Videos.Add(catVideo);
        Videos.Add(churchMusicVideo);
        Videos.Add(cseNewsVideo);

        // Printing Section.
        foreach (Video currentVideo in Videos)
        {
            Console.WriteLine(SPLITTER);

            Console.WriteLine($"Title: {currentVideo.GetTitle()}");
            Console.WriteLine($"By \"{currentVideo.GetAuthor()}\"");
            Console.WriteLine($"Description: {currentVideo.GetDescription()}");
            Console.WriteLine($"Video Length: {currentVideo.GetTimeLength()} seconds");
            Console.WriteLine($"\n{currentVideo.TotalComments()} Comments:\n");
            currentVideo.DisplayComments();

            Console.WriteLine(SPLITTER);
        }
    }
}