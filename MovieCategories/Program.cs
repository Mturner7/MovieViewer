using System;
using System.Collections.Generic;

namespace MovieCategories
{
    class Program
    {
        private static bool UserContinues(string msg)
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

        private static void PromptUser()
        {
            int index; //index of category user wants to view
            string input;

            Console.Write("Which category are you interested in? (enter a category # or name): ");
            input = Console.ReadLine();

            if (!Int32.TryParse(input, out index) && FeatureFilms.Categories.Contains(input))
            {
                index = FeatureFilms.Categories.IndexOf(input);
            }

            else if (index < 1 || index > FeatureFilms.Categories.Count)
            {
                Console.WriteLine("That's not a valid category, please try again.");
                return;
            }
            else --index;

            FeatureFilms.ViewMovies(index);
        }

        static void Main(string[] args)
        {
            Movie movie = new Movie("Drama", "Me and the Boys: redemption", 2002);
            movie = new Movie("sci-fi", "Star Wars Episode III", 2003);
            movie = new Movie("animated", "Sonic the hedghehog", 2020);
            movie = new Movie("fantasy", "Lord of the rings", 2001);
            movie = new Movie("sci-fi", "Tron: Legacy", 2010);
            movie = new Movie("Horror", "Friday the 13th", 1987);
            movie = new Movie("Sci-fi", "Transformers", 2007);
            movie = new Movie("Horror", "Willy's Wonderland", 2020);
            movie = new Movie("Drama", "The sad man", 2021);
            movie = new Movie("Animated", "The sad woman", 1956);
            movie = new Movie("Fantasy", "The masked man", 1943);

            bool running = true;
            while (running)
            {
                FeatureFilms.ViewCategories();
                PromptUser();
                running = UserContinues("Would you like to view a different category?");
            }
            Console.WriteLine("\nThank you for using this software!\n");
        }
    }
}
