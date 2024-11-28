using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Animal
    {
        public string name;
        public string sound;
        public static int numOfAnimals = 0;
        public const string SHELTER = "Home For Animal";
        public readonly int idNum;
        //inialisation.
       
        public Animal() : this("No Name", "No Sound") { }
        public Animal(string name):this(name,"No Sound") { }
     
        public Animal(string name, string sound)
        {
            SetName(name);
            Sound = sound;
            NumOfAnimals = 1;
            Random rnd = new Random();
            idNum = rnd.Next(1, 56444);
        }

        // method overloading 
        // You can have the getters and setters
        // generated for you like this and also
        // set the default value
        public string Owner { get; set; } = "No Owner";


        public void MakeSound()
        {
            Console.WriteLine("{0} says {1}", name, sound);
        }

        public void SetName(string name)
        {
            if (!name.Any(char.IsDigit))
            {
                this.name = name;
            }
            else
            {
                this.name = "noname";
                Console.WriteLine("Name can't contain numbers");
            }
        }
        public string GetName()
        {
            return name;
        }
        public string Sound
        {
            get { return sound; }
            set
            {
                if (value.Length > 10)
                {
                    sound = "No Sound";
                    Console.WriteLine("sound is too long");
                }
                else
                {
                    sound = value;
                }
            }

        }
        public static int NumOfAnimals
        {
            get { return numOfAnimals; }
            set => numOfAnimals += value;
        }
    }
}
