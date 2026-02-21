using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Lecture historyLecture = new Lecture(
            "George Washington History", 
            "An evening exploring how George Washington was prepared to become the first US president and how he changed America", 
            new DateOnly(2026, 6, 15), 
            new TimeOnly(19, 0), // 7pm
            new Address("7821 Innovation Way", "Salt Lake City", "UT", "USA"), 
            "Dr. Adam Olivant", 
            250
        );

        Reception jazzGala = new Reception(
            "Midnight Jazz with Duke Silver", 
            "A black-tie evening featuring the mysterious 'Duke Silver' and seasonal appetizers.", 
            new DateOnly(2026, 8, 22), 
            new TimeOnly(20, 30), // 8:30pm
            new Address("8323 Alpine Drive", "Provo", "UT", "USA"), 
            "RSVP by August 1st via email: rsvp@jazzgala.com"
        );

        OutdoorGathering solarEclipse = new OutdoorGathering(
            "2026 Eclipse Viewing", 
            "We're gonna go to the shadow of the moon and take some pictures! It'll be real early though.", 
            new DateOnly(2026, 10, 12), 
            new TimeOnly(4, 0), // 4am
            new Address("65 S 1st East", "Rexburg", "ID", "USA"), 
            "Partly cloudy, but 100% chance of cosmic awe!"
        );

        List<Event> events = new List<Event> {historyLecture, jazzGala, solarEclipse};

        foreach (Event ev in events)
        {
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            
            ev.DisplayStandardDetails();
            Console.WriteLine();

            // this is the one that is event type specific!!
            ev.DisplayFullDetails();
            Console.WriteLine();

            ev.DisplayShortDetails();
            
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }
    }
}