using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_kirill
{
    internal class Cow:Mammal
    {
        protected int milking_num;

        public Cow(string name, int age, bool isPredetor, int Calories,int milkCalories, int pregrancyMonths,int milking_num) 
            : base(name, age, isPredetor, Calories,milkCalories,pregrancyMonths)
        {
            this.milking_num = milking_num;
        }
        public void Setmilking_num(int milking_num)
        {
            this.milking_num = milking_num;
        }
        public int Getmilking_num() { return milking_num; }

        public int Eat()
        {
            int cal = (GetCalories() * 3 + GetMilkCalories())/4;
            return cal;
        }

        public override string ToString()
        {
            return "Cow!"+base.ToString() + $"{milking_num}";
        }
    }
}
