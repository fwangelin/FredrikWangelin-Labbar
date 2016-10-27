using Labb5__MyRepository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5__MyRepository
{
    class UI
    {
        public static void PrintMainMeny()
        {
            Console.Clear();
            Console.WriteLine("1. Pet list menu");
            Console.WriteLine("2. Movie list menu");
            Console.WriteLine("3. Exit");
        }

        public static void PrintPetMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add Pet to list");
            Console.WriteLine("2. Remove Pet to list");
            Console.WriteLine("3. Edit Pet in lists");
            Console.WriteLine("4. Show all Pets in list");
            Console.WriteLine("5. Main Menu");
        }

        public static void PrintMovieMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Add Movie to list");
            Console.WriteLine("2. Remove movie to list");
            Console.WriteLine("3. Edit movie in lists");
            Console.WriteLine("4. Show all movies in list");
            Console.WriteLine("5. Main Menu");
        }

        public static Movie CreateMovie()
        {
            Movie newMovie = new Movie();

            Console.Clear();
            Console.WriteLine("Movie Name:");
            newMovie.MovieName = Console.ReadLine();

            Console.WriteLine("Director of Movie:");
            newMovie.Director = Console.ReadLine();

            Console.WriteLine("Release year:");
            newMovie.ReleaseYear = int.Parse(Console.ReadLine());

            Console.WriteLine("Length of movie:");
            newMovie.Length = float.Parse(Console.ReadLine()); //kolla om detta är rätt, annars kanske gör om till en INT!

            Console.WriteLine("Choose genre: ");
            PrintMovieGenres();
            Console.Write("Choice: ");
            int choice = int.Parse(Console.ReadLine());
            newMovie.Genre = (Movie.GenreCategories)choice;

            return newMovie;
            
        }

        public static Pet CreatePet()
        {
            Pet newPet = new Pet();

            Console.Clear();
            Console.WriteLine("Pet Name:");
            newPet.PetName = Console.ReadLine();

            Console.WriteLine("Age of pet in Pet years:");
            newPet.PetAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Estimated Lifespan:");
            newPet.LifeSpan = int.Parse(Console.ReadLine());

            Console.WriteLine("What type of pet is it: ");
            PrintPetCategories();
            Console.Write("Choice: ");
            int choice = int.Parse(Console.ReadLine());
            newPet.PetGenres = (Pet.PetCategories)choice;

            return newPet;

        }

        public static void EditMovie(Movie movie)
        {
            Console.Clear();
            Console.WriteLine("1. Change Name");
            Console.WriteLine("2. Change Director");
            Console.WriteLine("3. Change Release year");
            Console.WriteLine("4. Change Length");
            Console.WriteLine("5. Change Genre");
            Console.Write("Choice: ");
            var choice = Console.ReadKey(true).Key;

            Console.Clear();
            Console.WriteLine("Movie: {0}, Director: {1}, Year: {2}, Length: {3}, Genre: {4}",
                                movie.MovieName,
                                movie.Director,
                                movie.ReleaseYear,
                                movie.Length,
                                movie.Genre);

            switch (choice)
            {
                case ConsoleKey.D1:
                    Console.Write("New name: ");
                    movie.MovieName = Console.ReadLine();
                    break;

                case ConsoleKey.D2:
                    Console.Write("New Director: ");
                    movie.Director = Console.ReadLine();
                    break;

                case ConsoleKey.D3:
                    Console.Write("New Release year: ");
                    movie.ReleaseYear = int.Parse(Console.ReadLine());
                    break;

                case ConsoleKey.D4:
                    Console.Write("New Length: ");
                    movie.Length = float.Parse(Console.ReadLine());
                    break;

                case ConsoleKey.D5:
                    Console.WriteLine("Genre list:");
                    PrintMovieGenres();
                    Console.Write("New genre: ");
                    movie.Genre = (Movie.GenreCategories)int.Parse(Console.ReadLine());
                    break;
            }
        }

        public static void EditPet(Pet pet)
        {
            Console.Clear();
            Console.WriteLine("1. Change Name");
            Console.WriteLine("2. Change Age");
            Console.WriteLine("3. Change Estimated Lifespan");
            Console.WriteLine("4. Change Type");
            Console.Write("Choice: ");
            var choice = Console.ReadKey(true).Key;

            Console.Clear();
            Console.WriteLine("Name: {0}, Age: {1}, Lifespan: {2}, Type: {3}",
                                pet.PetName,
                                pet.PetAge,
                                pet.LifeSpan,
                                pet.PetGenres);

            switch (choice)
            {
                case ConsoleKey.D1:
                    Console.Write("New name: ");
                    pet.PetName = Console.ReadLine();
                    break;

                case ConsoleKey.D2:
                    Console.Write("New Age: ");
                    pet.PetAge = int.Parse(Console.ReadLine());
                    break;

                case ConsoleKey.D3:
                    Console.Write("New Estimated Lifespan: ");
                    pet.LifeSpan = int.Parse(Console.ReadLine());
                    break;

                case ConsoleKey.D4:
                    Console.WriteLine("Animal type list:");
                    PrintPetCategories();
                    Console.Write("New type: ");
                    pet.PetGenres = (Pet.PetCategories)int.Parse(Console.ReadLine());
                    break;
            }
        }

        private static void PrintMovieGenres()
        {
            foreach (var movieGenre in Enum.GetValues(typeof(Movie.GenreCategories)))
            {
                Console.WriteLine("{0}, {1}", (int)movieGenre, movieGenre);
            }
        }

        private static void PrintPetCategories()
        {
            foreach (var petGenre in Enum.GetValues(typeof(Pet.PetCategories)))
            {
                Console.WriteLine("{0}, {1}", (int)petGenre, petGenre);
            }
        }

        public static int SelectMovie(Movie[] movies)
        {
            PrintMovies(movies);
            Console.Write("Select Movie: ");
            return int.Parse(Console.ReadLine());
        }

        public static int SelectPet(Pet[] pets)
        {
            PrintPets(pets);
            Console.Write("Select Pet: ");
            return int.Parse(Console.ReadLine());
        }

        public static void PrintMovies(Movie[] movies)
        {
            Console.Clear();
            foreach (var movie in movies)
            {
                Console.WriteLine("{0}. Movie: {1}, Director: {2}, Year: {3}, Length: {4}, Genre: {5}",
                                Array.IndexOf(movies, movie) + 1,
                                movie.MovieName,
                                movie.Director,
                                movie.ReleaseYear,
                                movie.Length,
                                movie.Genre);
            }
        }

        public static void PrintPets(Pet[] pets)
        {
            Console.Clear();
            foreach (var pet in pets)
            {
                Console.WriteLine("{0}. Name: {1}, Age: {2}, Lifespan: {3}, Genre: {4}",
                                Array.IndexOf(pets, pet) + 1,
                                pet.PetName,
                                pet.PetAge,
                                pet.LifeSpan,
                                pet.PetGenres);
            }
        }


    }
}
