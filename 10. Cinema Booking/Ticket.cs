using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cinema_Booking
{
    internal class Ticket : Movie
    {
        public string Seat { get; set; }
        public decimal Price { get; set; }

        public Ticket(string title, string genre, string seat, decimal price) : base(title, genre)
        {
            Seat = seat;
            Price = price;
        }

        public override string ShowDetails()
        {
            return base.ShowDetails() + $"Seat: {Seat}\nPrice: {Price}";
        }
    }
}
