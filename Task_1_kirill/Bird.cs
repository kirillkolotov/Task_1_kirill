using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_kirill
{
    internal class Bird : Animal, IBird

    {
        protected int FlightAtitude;
        protected int Wingspan;
        public Bird(string name, int age, bool isPredetor, int Calories, int FlightAtitude, int Wingspan):
            base( name, age, isPredetor,  Calories)
        {
            this.FlightAtitude = FlightAtitude;
            this.Wingspan = Wingspan;
        }

        public void SetFlightAtitude(int flightAtitude)
        {
            this.FlightAtitude = flightAtitude;
        }
        public void SetWingspan(int wingspan)
        {
            this.Wingspan = wingspan;
        }
        public int GetFlightAtitude()
        {
            return this.FlightAtitude;
        }
        public int GetWingspan()
        {
            return this.Wingspan;
        }

        public string Sing() 
        { return "tsif tsif shrik shrak bilbilbil lila lalalala "; }
        public string Dance()
        {
            return " im a bird tsif tsif im dancing right now :))) :DDDD";
        }

        public void fly()
        {
            Console.WriteLine("im flying right now"); 
        }

        public void land()
        {
            Console.WriteLine("im landing right now");
        }

        public void glide()
        {
            Console.WriteLine("im gliding right now");
        }
    }
}
