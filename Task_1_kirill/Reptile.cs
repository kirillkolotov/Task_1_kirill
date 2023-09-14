using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_kirill
{
    internal class Reptile: Animal, IReptile
    {
        protected int TailLenght;
        
        public Reptile(string name, int age, bool isPredetor, int Calories , int tailLenght):
            base( name, age,  isPredetor,  Calories)
        {
            this.TailLenght = tailLenght;
        }

        public void SetTailLenght(int TailLenght)
        {
            this.TailLenght = TailLenght;
        }
        public int GetTailLenght()
        {
            return this.TailLenght;
        }

        public void crawling()
        {
            Console.WriteLine("im crawling now "); 
        }

        public void defence()
        {
            Console.WriteLine("im defending now "); 
        }

        public void checktemp()
        {
            Console.WriteLine("im checking my temperature now ");
        }
    }
}
