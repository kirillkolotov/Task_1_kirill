using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1_kirill
{
    internal class Animal
    {
        protected string name;
        protected int age;
        protected bool isPredetor;
        protected int Calories; 

        public Animal(string name, int age, bool isPredetor, int Calories)
        {
            this.name = name;
            this.age = age;
            this.isPredetor = isPredetor;
            this.Calories = Calories;
        }

        public void SetName(string name) { this.name = name;}
        public void SetAge(int age) {  this.age = age;}
        public void SetCalories(int Calories) {  this.Calories = Calories;}
        public void SetisPredetor(bool isPredetor) { this.isPredetor = isPredetor;}

        public string GetName() { return this.name;}   
        public int GetAge() { return this.age;} 
        public bool GetisPredetor() { return this.isPredetor;}
        public int GetCalories() { return this.Calories;}

        public int Eat()
        {
            int Cal = GetCalories() * 3;
            return Cal;
        }

        public override string ToString()
        {
            return $"name: {name}, age: {age}, {Calories}kcl {isPredetor}";
        }
    }
}
