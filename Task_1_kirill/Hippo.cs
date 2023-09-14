using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_kirill
{
    internal class Hippo: Mammal
    { 
        
            protected int fat;

            public Hippo(string name, int age, bool isPredetor, int Calories, int milkCalories, int pregrancyMonths, int fat)
                : base(name, age, isPredetor, Calories, milkCalories, pregrancyMonths)
            {
                this.fat = fat;
            }
            public void Setfat(int fat)
            {
                this.fat = fat;
            }
            public int Getfat() { return fat; }
            public override string ToString()
            {
                return "Hippo!" + base.ToString() + $"fat={fat}%";
            }
        
    }

}

