using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_kirill
{
    internal class Snake: Reptile
    {
        protected bool isVenomus;

        public Snake(string name, int age, bool isPredetor, int Calories, int tailLenght, bool isVenomus) :
            base(name, age, isPredetor, Calories, tailLenght)
        {
            this.isVenomus = isVenomus;
        }
        public void SetisVenomus(bool isVenomus)
        {
            this.isVenomus = isVenomus;
        }
        public bool Getpassdoctor()
        {
            return this.isVenomus;
        }

        public string Dance()
        {
            return " im a snake sssssssssss im dancing right now :))) :DDDD";
        }
    }
}
