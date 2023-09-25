using System;
using System.Net;
using System.Xml.Linq;
namespace ovning3
{
    internal class Person
    {
        private int age = 12;
        private string fname = "Liam";
        private string lname = "Liamson";
        private double height;
        private double weight;


        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }

        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }



    }


}