using System;
using System.Collections.Generic;

namespace MovieCategories
{
    class Movie
    {
        public static readonly List<string> categories = new List<string>() { "Animated", "Sci-fi", "Horror", "Drama", "Fantasy" };
        private int releaseDate;
        public int ReleaseDate
        {
            get { return releaseDate; }
            set { releaseDate = ReleaseDate; }
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { title = Title; }
        }

        private string category;
        public string Category
        {
            get { return category; }
            set { Category = Category.ToLower(); }
        }

        public Movie(string Category, string Title, int ReleaseDate)
        {
            releaseDate = ReleaseDate;
            category = Category.ToLower();
            title = Title;
        }
    }
}
