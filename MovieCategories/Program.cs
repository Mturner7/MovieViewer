using System;
using System.Collections.Generic;

namespace MovieCategories
{
    class Program
    {
        public static List<Movie> movies = new List<Movie>() 
        {
            new Movie("Drama", "Me and the Boys: redemption", 2002),
            new Movie("sci-fi", "Star Wars Episode III", 2003),
            new Movie("Animated", "Sonic the hedghehog", 2020),
            new Movie("Fantasy", "Lord of the rings", 2001),
            new Movie("Sci-fi", "Tron: Legacy", 2010),
            new Movie("Horror", "Friday the 13th", 1987),
            new Movie("Sci-fi", "Transformers", 2007),
            new Movie("Horror", "Willy's Wonderland", 2020),
            new Movie("Drama", "The sad man", 2021),
            new Movie("Animated", "The sad woman", 1956),
            new Movie("Fantasy", "The masked man", 1943)
        };

        private static bool ContinuePrompt(string msg)
        {
            string input = "";
            while (input != "n" && input != "y")
            {
                Console.Write($"\n{msg} (y/n): ");
                input = Console.ReadLine().ToLower();
            }
            if (input == "n") return false;
            return true;
        }

        private static void promptUser()
        {
            int index;
            string input;

            Console.Write("Which category are you interested in? (enter a category # or name): ");
            input = Console.ReadLine();

            if (Movie.categories.Contains(input))
            {
                viewCategory(0, input);
                return;
            }

            Int32.TryParse(input, out index);
            --index;

            if (index > Movie.categories.Count - 1 || index < 0)
            {
                Console.WriteLine("\nThat is not a valid category. Please try again next time.");
                return;
            }
            else viewCategory(index, "");
        }


        public static void viewCategories()
        {
            Console.Clear();
            Console.WriteLine($"There are {movies.Count} movies in our database.\n");
            for (int i = 0; i < Movie.categories.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Movie.categories[i]}");
            }
            Console.WriteLine();
        }

        public static void viewCategory(int index, string input)
        {
            if (input.Length > 0) index = Movie.categories.IndexOf(input);

            string category = Movie.categories[index];
            string seperator = new string('=', 50);

            Console.Clear();
            Console.WriteLine($"Movies in the {category} category:\n");
            Console.WriteLine($"{ "Title", -30} { "Release Date", 5} \n{seperator}");

            foreach(Movie movie in movies)
            {
                if (movie.Category == category.ToLower())
                {
                    Console.WriteLine($"{movie.Title,-30} \t {movie.ReleaseDate,5}");
                }
            }
            Console.WriteLine(seperator);
        }

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                viewCategories();
                promptUser();
                running = ContinuePrompt("Would you like to view a different category?");
            }
            Console.WriteLine("\nThank you for using this software!\n");
        }
    }
}
