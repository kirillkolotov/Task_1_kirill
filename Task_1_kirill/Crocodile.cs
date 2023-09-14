using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_kirill
{
    internal class Crocodile : Reptile
    {
        protected bool passdoctor;

        public Crocodile(string name, int age, bool isPredetor, int Calories, int tailLenght, bool passdoctor) :
            base(name, age, isPredetor, Calories, tailLenght)
        {
            this.passdoctor = passdoctor;
        }

        public void Setpassdoctor(bool passdoctor)
        {
            this.passdoctor = passdoctor;
        }
        public bool Getpassdoctor()
        {
            return this.passdoctor;
        }
            
        



    }
}
