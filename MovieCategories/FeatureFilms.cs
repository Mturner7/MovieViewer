using System;
using System.Collections.Generic;

namespace MovieCategories
{
    class FeatureFilms
    {
        protected static List<Movie> Movies = new List<Movie>();
        protected static List<string> Categories = new List<string>() { "Animated", "Sci-fi", "Horror", "Drama", "Fantasy" };

        public static void ViewCategories()
        {
            Console.Clear();
            Console.WriteLine($"There are {Movies.Count} movies in our database.\n");

            for (int i = 0; i < Categories.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Categories[i]}");
            }
            Console.WriteLine();
        }

        private static int ValidateCategory(string input)
        {
            int categoryIndex = -1;
     
            if (!Int32.TryParse(input, out categoryIndex) && Categories.Contains(input))
            {
                return Categories.IndexOf(input);
            }

            else if (categoryIndex < 1 || categoryIndex > Categories.Count)
            {
                return -1;
            }

            --categoryIndex;
            return categoryIndex;
        }

        public static void ViewMovies(string input)
        {
            int categoryIndex = ValidateCategory(input);
            if (categoryIndex == -1)
            {
                Console.WriteLine("\nThat's not a valid category, please try again.");
                return;
            }

            string category = Categories[categoryIndex];
            string seperator = new string('=', 50);

            Console.Clear();
            Console.WriteLine($"Movies in the {category} category:\n");
            Console.WriteLine($"{ "Title",-30} { "Release Date",5} \n{seperator}");

            foreach (Movie movie in Movies)
            {
                if (movie.Category == category)
                {
                    Console.WriteLine($"{movie.Title,-30} \t {movie.ReleaseDate,5}");
                }
            }
            Console.WriteLine(seperator);
        }
    }
}

