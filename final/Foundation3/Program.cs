class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture("The Future of Quantum Computing",
                                      "Join Dr. Elena Martinez, a leading researcher in quantum algorithms, as she explores how quantum computing is reshaping industries from finance to healthcare. This lecture will cover breakthroughs, challenges, and practical applications.",
                                      "March 14, 2026",
                                      "6:30 PM",
                                      "Innovation Hall, 2450 Tech Avenue, Boise, ID",
                                      "Dr. Elena Martinez",
                                      120);
        
        Reception reception = new Reception("Spring Networking Reception",
                                            "A professional networking evening for entrepreneurs, educators, and technologists. Guests will enjoy light refreshments, meet potential collaborators, and hear brief remarks from community leaders. RSVP is required to attend.",
                                            "April 22, 2026",
                                            "5:00 PM",
                                            "Riverside Conference Center, 101 Main Street, Idaho Falls, ID",
                                            "IFevents@gmail.com");
        
        OutdoorGathering outdoorGathering = new OutdoorGathering("Community Picnic & Music in the Park",
                                                                 "Bring your family and friends for a relaxed afternoon of live local music, games, and food trucks. This open-air gathering welcomes everyone, with no attendee limit. Weather conditions will be monitored to ensure safety and comfort.",
                                                                 "May 10, 2026",
                                                                 "12:00 PM",
                                                                 "Porter Park, 105 South 3rd West, Rexburg, ID",
                                                                 "Sunny");
        
        Console.WriteLine("\n\nStandard Info:");
        Console.WriteLine(lecture.GetStandardInfo());
        Console.WriteLine(reception.GetStandardInfo());
        Console.WriteLine(outdoorGathering.GetStandardInfo());

        Console.WriteLine("\n\nFull Detail Info:");
        Console.WriteLine(lecture.GetLectureInfo());
        Console.WriteLine(reception.GetReceptionInfo());
        Console.WriteLine(outdoorGathering.GetOutdoorGatheringInfo());

        Console.WriteLine("\n\nShort Description Info:");
        Console.WriteLine(lecture.GetShortInfo());
        Console.WriteLine(reception.GetShortInfo());
        Console.WriteLine(outdoorGathering.GetShortInfo());
        
    }
}