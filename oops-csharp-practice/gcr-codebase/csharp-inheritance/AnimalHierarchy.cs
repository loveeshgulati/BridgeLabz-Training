using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeLabz_Training.OOPS.inheritance
{
        class AnimalHeirarchySounds
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Animal makes a sound");
            }
        }
        class Dog : AnimalHeirarchySounds
        {
            public override void MakeSound()
            {
                Console.WriteLine("Dog barks");
            }
        }
        class Cat : AnimalHeirarchySounds
        {
            public override void MakeSound()
            {
                Console.WriteLine("Cat meows");
            }
        }

        class Bird : AnimalHeirarchySounds

        {
            public override void MakeSound()
            {
                Console.WriteLine("Bird Chirps");
            }
            public static void Main(string[] args)
            {
                AnimalHeirarchySounds animal1 = new Dog();
                AnimalHeirarchySounds animal2 = new Cat();
                AnimalHeirarchySounds animal3 = new Bird();
                animal1.MakeSound();
            Console.WriteLine();
                animal2.MakeSound();
            Console.WriteLine();
                animal3.MakeSound();
            Console.WriteLine();
            }
        }
}

