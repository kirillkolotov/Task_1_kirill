using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_kirill
{
    internal class Mammal: Animal
    {
        protected int MilkCalories;
        protected int PregrancyMonths;

        public Mammal(string name, int age, bool isPredetor, int Calories,int milkCalories, int pregrancyMonths)
            : base( name,  age,  isPredetor,  Calories)
        {
            MilkCalories = milkCalories;
            PregrancyMonths = pregrancyMonths;
        }
        
        public void SetMilkCalories(int milkCalories)
        {
            MilkCalories = milkCalories;
        }
        public void SetPregrancyMonths(int pregrancyMonths)
        {
            PregrancyMonths = pregrancyMonths;
        }
        public int GetMilkCalories() {  return MilkCalories; }
        public int GetPregrancyMonths() {  return PregrancyMonths; }

        public int Eat()
        {
            int cal = GetCalories()*3 + GetMilkCalories();
            return cal;
        }

        public override string ToString()
        {
            return base.ToString()+$" Milk Calories: {MilkCalories}, Pregrancy Months: {PregrancyMonths}";
        }
    }
}
