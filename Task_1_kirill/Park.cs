using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_kirill
{
    internal class Park
    {
        protected Animal[] arr = new Animal[1000];
        protected int currentAnimals; 

        public Park() { Animal[] arr = new Animal[1000]; }
        public string addAnimal(Animal animal)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == null)
                {
                    arr[i] = animal;
                    return "animal was added";
                }
                
            }
            return "there is no space";

        }
        public Animal[] OldPredators()
        {
            Animal[] oldP = new Animal[1000];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].GetAge() > 10 && arr[i].GetisPredetor() == true)
                {
                    oldP[i] = arr[i];
                }
            }

            return oldP;
        }

        public int predatorsRB()
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if ((arr[i] is Bird) && arr[i].GetisPredetor() == true)
                {
                    count++;
                }
                if ((arr[i] is Reptile) && arr[i].GetisPredetor() == true)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
