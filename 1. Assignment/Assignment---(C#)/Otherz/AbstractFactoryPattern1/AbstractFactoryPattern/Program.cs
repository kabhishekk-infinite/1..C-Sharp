using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {


        public interface IAnimal        //'IAnimal' An interface with a Speak method that returns a string.
        {
            string Speak();
        }

        //Concrete classes that implement the IAnimal interface
        public class Dog : IAnimal
        {
            public string Speak()
            {
                return "Woof!";
            }
        }

        public class Cat : IAnimal
        {
            public string Speak()
            {
                return "Meow!";
            }
        }

        public class Shark : IAnimal
        {
            public string Speak()
            {
                return "Dun dun...";
            }
        }

        public class Octopus : IAnimal
        {
            public string Speak()
            {
                return "Bloop bloop!";
            }
        }

        public class AnimalFactory          //A class with a static method CreateAnimalFactory
        {
            public static IAnimalFactory CreateAnimalFactory(string factoryType)
            {
                if (factoryType.Equals("Land"))
                {
                    return new LandAnimalFactory();
                }
                else if (factoryType.Equals("Sea"))
                {
                    return new SeaAnimalFactory();
                }
                else
                {
                    throw new ArgumentException("Invalid factory type");
                }
            }
        }

        public interface IAnimalFactory         //An interface with a GetAnimal method 
        {
            IAnimal GetAnimal(string animalType);
        }

        public class LandAnimalFactory : IAnimalFactory             //Implements IAnimalFactory and creates instances of Dog or Cat based on the input.
        {
            public IAnimal GetAnimal(string animalType)
            {
                if (animalType.Equals("Dog"))
                {
                    return new Dog();
                }
                else if (animalType.Equals("Cat"))
                {
                    return new Cat();
                }
                else
                {
                    throw new ArgumentException("Invalid animal type");
                }
            }
        }

        public class SeaAnimalFactory : IAnimalFactory             //Implements IAnimalFactory and creates instances of Shark or Octopus based on the input.
        {
            public IAnimal GetAnimal(string animalType)
            {
                if (animalType.Equals("Shark"))
                {
                    return new Shark();
                }
                else if (animalType.Equals("Octopus"))
                {
                    return new Octopus();
                }
                else
                {
                    throw new ArgumentException("Invalid animal type");
                }
            }
        }

        public class AbstractFactoryPattern                 //Contains the Main method
        {
            static void Main(string[] args)
            {
                IAnimal animal = null;
                IAnimalFactory animalFactory = null;

                string sound = null;

                Console.WriteLine("Enter the Factory Type Land/Sea:");              //User to choose a factory type (Land/Sea)
                string factoryType = Console.ReadLine();
                animalFactory = AnimalFactory.CreateAnimalFactory(factoryType);
                Console.WriteLine();

                if (factoryType.Equals("Land"))
                {
                    Console.WriteLine("Enter Dog/cat :");
                    string reqAnimal = Console.ReadLine();

                    animal = animalFactory.GetAnimal(reqAnimal);
                    Console.WriteLine("The Chosen Animal is  : {0}", animal.GetType().Name);

                    sound = animal.Speak();
                    Console.WriteLine($" The Factory is  : {animalFactory}, and the Animal is  : {animal} producing" +
                        $"the sound   : {sound}");
                }
                else if (factoryType.Equals("Sea"))
                {
                    Console.WriteLine("Enter Shark/Octopus :");
                    string reqAnimal = Console.ReadLine();
                    animal = animalFactory.GetAnimal(reqAnimal);
                    Console.WriteLine("The Chosen Animal is  : {0}", animal.GetType().Name);

                    sound = animal.Speak();
                    Console.WriteLine($" The Factory is :  {animalFactory}, and the Animal is : {animal} Producing" +
                        $"the sound : {sound}");
                }
                else
                    Console.WriteLine("Please choose correct animal");

                Console.Read();
            }
        }
    }
}
