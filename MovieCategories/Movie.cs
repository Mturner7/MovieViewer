using System;

namespace MovieCategories
{
    class Movie : FeatureFilms
    {
        private int releaseDate;
        public int ReleaseDate
        {
            get { return releaseDate; }
            set
            {
                if (ReleaseDate < 0)
                {
                    releaseDate = 2000;
                }
                else releaseDate = ReleaseDate;
            }
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
            set { category = Category.Substring(0,1).ToUpper() + Category.Substring(1).ToLower(); }
        }

        public Movie(string Category, string Title, int ReleaseDate)
        {
            releaseDate = ReleaseDate;
            category = Category.Substring(0, 1).ToUpper() + Category.Substring(1).ToLower();
            title = Title;
            Movies.Add(this);
        }
    }
}