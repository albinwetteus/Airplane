using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Airplane
{
    class Airplane
    {
        int AmountOfSeats { get; set; }
        bool IsBoarded { get; set; }
        bool InAir { get; set; }

        public Seat[] Seats { get; set; }
        public Passenger[] Passengers { get; set; }
        public CrewMember[] Crew { get; set; }

        public Airplane(int amountOfSeats)
        {
            AmountOfSeats = amountOfSeats;
            Seats = new Seat[AmountOfSeats];
            Passengers = new Passenger[AmountOfSeats];
            for (int i = 0; i < Seats.Length; i++)
            {
                Seats[i] = new Seat { SeatId = i };
            }
        }

        public void TakeOff()
        {

        }
        public void Land()
        {

        }
        public void ShowAvailableSeats()
        {
            var availableSeats = from s in Seats
                                 where s.IsAvailable == true
                                 select s;
            foreach (var item in availableSeats)
            {
                Console.WriteLine(item.SeatId);
            }
        }
        public void BoardAirplane()
        {
            IsBoarded = true;
            Console.WriteLine("Plane is now boarded");
        }

    }
}
