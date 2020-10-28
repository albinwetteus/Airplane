using System;

namespace Airplane
{
    public class Passenger
    {
        public string Name { get;  set; }
        public int Seat { get;  set; }
        public int Age { get;  set; }

       
        public Passenger(string name, int seat, int age)
        {
            Name = name;
            Seat = seat;
            Age = age;
        }
        public void GoToToilet()
        {

        }

        public void OrderArticle()
        {

        }
    }
}