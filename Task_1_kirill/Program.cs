using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Task_1_kirill;

namespace Task1_kirillkolotov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mammal[] arrMammal = new Mammal[] { 
            new Cow("",12,true,1250,5242,9,10),
            new Cow("", 1, false, 1500,5,8, 10),
            new Cow("", 2, false, 1500,3,9, 10),
            new Cow("", 3, false , 10000,6,9, 10),
            new Cow("", 4, false, 50000,90,9, 10)};
            Reptile[] arrReptile= new Reptile[] {
            new Snake("",12,true,1250,5242,true),
            new Snake("",34,true,1250,5242,true),
            new Snake("",56,true,1250,5242,true),
            new Snake("",67,true,1250,5242,true),
            new Snake("",78,true,1250,5242,true)
            };
            Animal[] arrAnimal= new Animal[] { };
        }
        public int Totalcalories(Animal[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i].GetCalories();
            }
            return sum ;
        }
        public int CountMammals(Animal[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Mammal) 
                    count++;
            }
            return count ;
        }
        public void DanceSB(Animal[] arr)
        {
            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i] is Bird)
                {
                    (arr[i] as Bird).Dance(); 
                }
                if (arr[i] is Snake)
                {
                    (arr[i] as Snake).Dance();
                }
            }
        }

        public string fattestHippo(Animal[] arr)
        {
            int highestfat = 0;
            string name = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] is Hippo)
                {
                    if ((arr[i] as Hippo).Getfat() > highestfat)
                    {
                        highestfat = (arr[i] as Hippo).Getfat();
                        name = arr[i].GetName();
                    } 
                }
            }
            return name;
        }
    }
}
