using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ovning3
{

    internal class PersonHandler : Person 
    {

        public void SetAge(Person pers, int age)
        {
            this.Age = pers.Age;
        }
        public void SetFirstName(Person pers, string fname)
        {
            this.Fname = pers.Fname;
        }
        public void SetLastName(Person pers, string lname)
        {
            this.Lname = pers.Lname;
        }
        public void SetHeight(Person pers, double height)
        {
            this.Height = pers.Height;
        }
        public void SetWeight(Person pers, double weight)
        {
            this.Weight = pers.Height;
        }

        public Person CreatePerson(int age, string fname,string lname, double height, double weight)
        {

            this.Age = age;
            this.Fname = fname;
            this.Lname = lname;  
            this.Height = height;
            this.Weight = weight;
            return this;
        }


    }


}