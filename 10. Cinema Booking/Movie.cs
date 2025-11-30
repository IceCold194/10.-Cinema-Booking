using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cinema_Booking
{
    internal class Movie
    {
        public string Title { get; set; }
        public string Genre { get; set; }

        public Movie (string title, string genre    )
        {
            Title = title;
            Genre = genre;
        }

        public virtual string ShowDetails()
        {
            return $"Movie: {Title}\nGenre: {Genre}";
        }
    }
}
