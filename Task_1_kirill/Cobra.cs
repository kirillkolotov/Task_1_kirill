using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_kirill
{
    internal class Cobra: Snake
    {
        protected int capuchonWidth;

        public Cobra(string name, int age, bool isPredetor, int Calories, int tailLenght, bool isVenomus, int capuchonWidth) 
            :base(name, age, isPredetor, Calories, tailLenght,isVenomus)
        {
            this.capuchonWidth = capuchonWidth;
        }
        public void SetcapuchonWidth(int capuchonWidth)
        {
            this.capuchonWidth = capuchonWidth;
        }
        public int GetcapuchonWidth()
        {
            return this.capuchonWidth;
        }
    }
}
