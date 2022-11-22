using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fountation
{
    internal class Inheritance
    {
        public static void yes()
        {
            Animal animal = new Animal();
            animal.Name = "Cat";
            Animal animal2 = new Animal(17, "Dog", false);
            animal2.Speak();

            Mammal human = new Mammal("Bob", 75, true, true, false);
            human.Speak();

            Animal human2 = new Mammal("Greg", 38, true, true, false);
            human2.Speak();
        }

        class Animal
        {
            public int lifespan;
            public string Name;
            public bool IsNocturnal;

            public Animal() { }

            public Animal(int lifespan, string name, bool isNocturnal)
            {
                this.lifespan = lifespan;
                Name = name;
                IsNocturnal = isNocturnal;
            }

            public void Speak()
            {
                Console.WriteLine(Name + " speaks (Animal Class)");
            }
        }

        class Mammal : Animal
        {
            public bool IsCarnivor { get; set; }
            public bool LivesOnLand { get; set; }

            public Mammal(string name, int lifespan, bool isCarnivor, bool livesOnLand, bool isNocturnal = false) : base(lifespan, name, isNocturnal)
            {
                this.IsCarnivor = isCarnivor;
                this.LivesOnLand = livesOnLand;
            }
            public void Speak()
            {
                Console.WriteLine(Name + " speaks (Mammal class)");
            }
        }

        class Fish : Animal
        {
            public bool CanSpeak { get; set; }

            public Fish(string name, int lifespan, bool canSpeak, bool isNocturnal = false) : base(lifespan, name, isNocturnal)
            {
                CanSpeak = canSpeak;
            }

            public void Speak()
            {
                if(CanSpeak)
                {
                    Console.WriteLine(Name + " speaks (fish class)");
                }
                else
                {
                    base.Speak();
                    Console.WriteLine(Name + " produces bubbles (fish class)");
                }
            }
        }
    }
}
