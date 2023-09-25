

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace ovning3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            PersonHandler handler = new PersonHandler();
            var newPerson = handler.CreatePerson(14, "Julian", "Jefferson", 12, 12);

            int age = newPerson.Age;
            int lettercount = newPerson.Fname.Length;
            int lettercount2 = newPerson.Lname.Length;

            if (lettercount < 3 || lettercount > 10 || lettercount2 > 10 || lettercount2 > 10)
            {
                throw new ArgumentException(String.Format("Incorrect number of letters in name"));
            }
             if( age <= 0 )



            {
                throw new ArgumentException(String.Format("Age is too low"));
            }

            Console.WriteLine(newPerson.Fname);
            Console.WriteLine(newPerson.Lname); 
                
            UserError[] usererrors = new UserError[] { new NumericalInputError(), new TextInputError(), new GeneralError(), new UserInputError(), new SwagInputError()};

          
                
           

            foreach (UserError usererror in usererrors)
        {
            
            usererror.UEMessage();
        }

            Console.ReadKey();

                Animal[] animals = new Animal[] { new Hedgehog(), new Dog(), new Bird(),new Horse(), new Wolf(), new Worm(), new Wolfman()};
            List<Animal> animalsList = new(animals)
            {
                new Rabbit(),
                new Bat(),
                new Shark(),
                new Vampire()
            };
            Dog[] dogs = new Dog[] { };
            List<Dog> dogsList = new(dogs)
            {
                new Doberman(),
                new Chiuahua(),
                new Mop()
                //new Horse(), F: Den kan inte läggas till då den e derived från Animal, inte Dog. 
                //10. F: Vilken typ måste listan vara för att alla klasser skall kunna lagras tillsammans: Animal
            };
            animalsList.AddRange(dogsList);



            foreach (Animal animal in animalsList)
            {
                Console.ReadKey();
                Console.WriteLine($"The {animal.GetType().Name} goes {animal.Sound}");


                if (animal.GetType().BaseType == typeof(Dog))
                {

                    Console.WriteLine($"This is the stats canines: {animal.Stats}");
                }
                //17.F: Varför inte? Jag kommer inte åt canines då den ör derivded från dog. Eftersom den är derived från dog, så räknas dog som den nya Basklassen för hundarna. 
                else {


                    Console.WriteLine($"This is the stats fora all animals: {animal.Stats}");
                }

             




                if (animal.GetType().GetInterfaces().Contains(typeof(IPerson)))
                {
                    ((IPerson)animal).Talk();
                }
            }
           


        }


    }

}