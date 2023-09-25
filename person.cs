using System;

public class Person
{

    private int age;
    private string fName;
    private string lName;
    private int height;
    private int weight;

    public int age   // property
    {
        get { return name; }   // get method
        set { name = value; }  // set method
    }

    public string fName   // property
    {
        get { return name; }   // get method
        set { name = value; }  // set method
    }

    public string lName   // property
    {
        get { return name; }   // get method
        set { name = value; }  // set method
    }

    public int height   // property
    {
        get { return name; }   // get method
        set { name = value; }  // set method
    }
    public int height   // property
    {
        get { return name; }   // get method
        set { name = value; }  // set method
    }


    class Program
    {
        static void Main(string[] args)
        {
            Person myObj = new Person();
            myObj.Name = "Liam";
            Console.WriteLine(myObj.Name);
        }
    }

}
