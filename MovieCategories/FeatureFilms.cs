using System;
using System.Collections.Generic;

namespace MovieCategories
{
    class FeatureFilms
    {
        protected static List<Movie> Movies = new List<Movie>();
        public static readonly List<string> Categories = new List<string>() { "Animated", "Sci-fi", "Horror", "Drama", "Fantasy" };

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

        public static void ViewMovies(int categoryIndex)
        {
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
        
       

        

