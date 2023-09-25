using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ovning3
{
    abstract class Animal
    {

       
        public string Habitat = "";
        public string species_family = "";

        public abstract string Sound { get; }


        public abstract string Stats { get; }


    }

    internal class Dog : Animal
    {
      
        public new string Habitat = "varied";
        public new string species_family = "Canine";
        public string goodboyStatus = "Yes";

        public override string Sound => "Woof!";


        public override string Stats => Habitat + " " + species_family + " " + goodboyStatus;



    }

    internal class Worm : Animal
    {
       
        public new string Habitat = "varied";
        public new string species_family = "Wurms";
        public string squiggly = "Yes";

        public override string Sound => "The Worm says: Well, not a lot to be honest";


        public override string Stats => Habitat + " " + species_family + squiggly;
    }
    internal class Wolf : Animal
    {
        
        public new string Habitat = "varied";
        public new string species_family = "Canine";
        public string behavior = "pack animal";


        public override string Sound => "The wolf says: AWOOOOO";


        public override string Stats => Habitat + " " + species_family + " " + behavior;
    }
    internal class Bird : Animal
    {
   
        public new string Habitat = "The Sky?";
        public new string species_family = "Avian";
        public int wingspan = 41;


        public override string Sound => "The Bird says: CHIRP CHIRP";



        public override string Stats => Habitat + " " + species_family + " " + wingspan;




    }

    internal class Horse : Animal
    {

        public new string Habitat = "The Sky?";
        public new string species_family = "Avian";
        public string maxspeed = "64 Km and hour";


        public override string Sound => "The Horse says: NEIGH";



        public override string Stats => Habitat + " " + species_family + " " + maxspeed;




    }

    internal class Shark : Animal
    {

        public new string Habitat = "THE SEA";
        public new string species_family = "Fish?! IDK";
        public string nrofteeth = "TOO MANY";

        public override string Sound => "The Shark says: CHOMP!";

        public override string Stats => Habitat + " " + species_family + " " + nrofteeth;


    }
    internal class Bat : Animal
    {

        public new string Habitat = "varied";
        public new string species_family = "Canine?";
        public string reputation = "Unfair";

        public override string Sound => "The Bat says: flap flap peep!";

        public override string Stats => Habitat + " " + species_family + " " + reputation;


    }

    internal class Rabbit : Animal
    {

        public new string Habitat = "varied";
        public new string species_family = "Hare";
        public string population = "Another one, and another one, and another one.";

        public override string Sound => "The Rabbit says: Tchk peep!";

        public override string Stats => Habitat + " " + species_family + " " + population;


    }

    internal class Hedgehog : Animal
    {
        public new string Habitat = "varied";
        public new string species_family = "Canine";
        public int nrofspikes = 124;
       
        public override string Sound =>  "The Hedgehog says: Tsktsktsk";

        public override string Stats => Habitat + " " + species_family + " " + nrofspikes;


    }
    internal class Flamingo : Bird
    {

        public string FavoriteDiet = "Shrimp";

    }

    internal class Pelican : Bird
    {
        public int maximumGulletCapacity = 40;


    }
    internal class Swan : Bird
    {

        public int maximumGulletCapacity = 40;


    }
    interface IPerson
    {
        void Talk();
    }
    internal class Wolfman : Wolf, IPerson
    {
        
        public string Fangdom = "rabid";

        public override string Stats => Habitat + " " + species_family + " " + Fangdom;

        public void Talk() {

            Console.WriteLine("I no longer say AWOOOO. I Say Hi, like a man. Get it, Wolf, man?");

        }

    }

    internal class Vampire : Bat, IPerson
    {

        public new string reputation = "Earned";
        public string Sassyness = "Critical Levels";

        public override string Sound => "The Rabbit says: Tchk peep!";

        public override string Stats => Habitat + " " + species_family + " " + reputation + " " + Sassyness;

        public void Talk()
        {

            Console.WriteLine("I am a vampire. BLAH!");

        }
    }

    internal class Doberman : Dog
    {

        public string size = "Big";
        public override string Stats => Habitat + " " + species_family + " " + size;

    }

    internal class Chiuahua : Dog
    {

        public string size = "Small";
        public override string Stats => Habitat + " " + species_family + " " + size;


    }

    internal class Mop : Dog
    {

        public string size = "Tiny";
        public override string Stats => Habitat + " " + species_family + " " + size;

    }
}
