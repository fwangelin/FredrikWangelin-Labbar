using ConsoleApplication1.RunTime;
using System;
using System.Collections.Generic;
using ConsoleApplication1.Tickets;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class EventManager
    {
        public List<Cinema> MoviesRunning { get; set; }
        public List<Concerts> ConcertsRunning { get; set; }
        public List<Festivals> FestivalsRunning { get; set; }
        public List<MovieTicket> BookedMovies { get; set; }
        public List<ConcertTicket> BookedConcerts { get; set; }
        public List<FestivalTicket> BookedFestivals { get; set; }
        public string Person { get; set; }

        public EventManager()
        {
            BookedMovies = new List<MovieTicket>();
            BookedFestivals = new List<FestivalTicket>();
            BookedConcerts = new List<ConcertTicket>();


            MoviesRunning = new List<Cinema>()
            {
            new Cinema { NameOfEvent = "Fast and the furious 90", DateOfEvent = "2016-12-20", PlaceOfEvent = "SF Sigtuna", MovieCategory = "Horrible stuff" },
            new Cinema { NameOfEvent = "UP 600 times remastered", DateOfEvent = "2017-01-12", PlaceOfEvent = "SF Sergel",  MovieCategory = "Animated to look real" },
            new Cinema { NameOfEvent = "Sällskapsresan 7",        DateOfEvent = "2017-01-19", PlaceOfEvent = "SF MOS",     MovieCategory = "Buskis" },
            new Cinema { NameOfEvent = "Hello World",             DateOfEvent = "2017-02-23", PlaceOfEvent = "SF Sigtuna", MovieCategory = "Documentary" },
            new Cinema { NameOfEvent = "Fast and the furious 91", DateOfEvent = "2017-02-24", PlaceOfEvent = "SF Gävle",   MovieCategory = "Horrible stuff" },
            };

            ConcertsRunning = new List<Concerts>()
            {
            new Concerts { NameOfEvent = "Rolling Stones - Revived again",           DateOfEvent = "2017-06-06", PlaceOfEvent = "Ullevi - Göteborg",   WillConcertBeOutside = "Outside" },
            new Concerts { NameOfEvent = "THe Hives - HIVes",                        DateOfEvent = "2017-06-15", PlaceOfEvent = "Slussen - Stockholm", WillConcertBeOutside = "inside" },
            new Concerts { NameOfEvent = "Kings Of Leon - So Christian",             DateOfEvent = "2017-07-29", PlaceOfEvent = "Dalhalla - Rättvik",  WillConcertBeOutside = "Outside" },
            new Concerts { NameOfEvent = "Lasse Stefanz - Vi lägger nog aldrig av",  DateOfEvent = "2017-07-30", PlaceOfEvent = "Kiruna Busstation",   WillConcertBeOutside = "Inside" },
            new Concerts { NameOfEvent = "Drake - I make shitty music",              DateOfEvent = "2017-08-24", PlaceOfEvent = "Globen - Stockholm",  WillConcertBeOutside = "Inside" },
            };

            FestivalsRunning = new List<Festivals>()
            {
            new Festivals { NameOfEvent = "Sweden Rock",         DateOfEvent = "2017-07-02", PlaceOfEvent = "Värnamo",        TopBandPlaying = "Metallica" },
            new Festivals { NameOfEvent = "Rock in Rio",         DateOfEvent = "2017-07-09", PlaceOfEvent = "Rio De Janeiro", TopBandPlaying = "Iron Maiden" },
            new Festivals { NameOfEvent = "Hultsfredfestivalen", DateOfEvent = "2017-07-14", PlaceOfEvent = "Hultsfred",      TopBandPlaying = "Kings Of Leon" },
            new Festivals { NameOfEvent = "Neon och Techno",     DateOfEvent = "2017-07-20", PlaceOfEvent = "Märsta",         TopBandPlaying = "Techno-Viking" },
            new Festivals { NameOfEvent = "PRO-Party",           DateOfEvent = "2017-07-30", PlaceOfEvent = "PRO Kiruna",     TopBandPlaying = "Lasse Stefanz" },
            };
        }

        public void PrintConcertInfoToConsole()
        {
            Console.Clear();
            Console.WriteLine("Event Info:");
            Console.WriteLine();
            int i = 1;
            foreach (var concert in ConcertsRunning)
            {
                Console.WriteLine(i + ". " + concert.IntroductionOfEvents()); i++;
            }

        }
        public void PrintFestivalInfoToConsole()
        {
            Console.Clear();
            Console.WriteLine("Event Info:");
            Console.WriteLine();
            int i = 1;
            foreach (var festival in FestivalsRunning)
            {
                Console.WriteLine(i + ". " + festival.IntroductionOfEvents()); i++;
            }

        }
        public void PrintMoviesInfoToConsole()
        {
            Console.Clear();
            Console.WriteLine("Event Info:");
            Console.WriteLine();
            int i = 1;
            foreach (var movie in MoviesRunning)
            {
                Console.WriteLine(i + ". " + movie.IntroductionOfEvents()); i++;
            }

        }

        public void BookConcert()
        {
            PrintShortListOfConcert();

            Console.Write("Select Concert: ");
            int selectConcert = int.Parse(Console.ReadLine());

            Console.Write("Your name: ");
            string customerName = Console.ReadLine();

            ConcertTicket newConcertTicket = new ConcertTicket
            {
                Concert = ConcertsRunning[selectConcert - 1],
                Person = customerName
            };

            BookedConcerts.Add(newConcertTicket);
        }
        public void PrintShortListOfConcert()
        {
            int i = 1;
            foreach (var shortListOfConcert in ConcertsRunning)
            {
                Console.WriteLine(i + ". " + shortListOfConcert.NameOfEvent); i++;
            }
        }

        public void BookFestivals()
        {
            PrintShortListOfFestival();

            Console.Write("Select Festival: ");
            int selectFestival = int.Parse(Console.ReadLine());

            Console.Write("Your name: ");
            string customerName = Console.ReadLine();

            FestivalTicket newFestivalTicket = new FestivalTicket
            {
                Festival = FestivalsRunning[selectFestival - 1],
                Person = customerName
            };

            BookedFestivals.Add(newFestivalTicket);
        }
        public void PrintShortListOfFestival()
        {
            int i = 1;
            foreach (var shortListOfFestival in FestivalsRunning)
            {
                Console.WriteLine(i + ". " + shortListOfFestival.NameOfEvent); i++;
            }
        }

        public void BookMovies()
        {
            PrintShortListOfMovies();

            Console.Write("Select Movie: ");
            int selectMovie = int.Parse(Console.ReadLine());

            Console.Write("Your name: ");
            string customerName = Console.ReadLine();

            MovieTicket newMovieTicket = new MovieTicket
            {
                Movie = MoviesRunning[selectMovie - 1],
                Person = customerName
            };

            BookedMovies.Add(newMovieTicket);
        }
        public void PrintShortListOfMovies()
        {
            int i = 1;
            foreach (var shortListOfMovies in MoviesRunning)
            {
                Console.WriteLine(i + ". " + shortListOfMovies.NameOfEvent); i++;
            }
        }

        public void PrintBookingsToConsole()
        {

            Console.WriteLine("Your Bookings:");
            Console.WriteLine();
            foreach (var bookings in BookedConcerts)
            {
                Console.WriteLine(bookings.ToString());
            }
            foreach (var bookings in BookedFestivals)
            {
                Console.WriteLine(bookings.ToString());
            }
            foreach (var bookings in BookedMovies)
            {
               Console.WriteLine(bookings.ToString());
            }
            Console.ReadLine();
        }




    }
}
