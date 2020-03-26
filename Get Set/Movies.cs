using System;
using System.Collections.Generic;
using System.Text;

namespace Get_Set
{
    class Movies
    {
        public string title;
        public string director;
        private string rating; //Can only be accessed within this class

        public Movies(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            Rating = aRating; //Constructor. Now it's set to the method below
        }

        public string Rating
        {
            get => rating;  //Allows us to get the rating attribute
            set
            { //Allows us to modify the rating, or set it
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R" || value == "NR")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            } //Allows us to modify the rating
        }
    }
}
