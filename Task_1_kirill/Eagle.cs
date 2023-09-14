using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_kirill
{
    internal class Eagle : Bird
    {
         protected string favoritefood;

        public Eagle(string name, int age, bool isPredetor, int Calories, int FlightAtitude, int Wingspan , string favoritefood)
            :base(name, age, isPredetor, Calories , FlightAtitude, Wingspan)
        {
            this.favoritefood = favoritefood;
        }
        public void Setfavoritefood(string favoritefood)
        {
            this.favoritefood = favoritefood;
        }
        public string Getfavoritefood()
        {
            return this.favoritefood;
        }
    }
}
