//This is an example of operator overloading. 
using System;
class Cuboid
{
    double l; //These l,b,h are three datamembers of class Cuboid
    double b;
    double h;

    Cuboid(double l, double b, double h)//creating and calling the paramatirized constructor)
    {
        this.l = l; //Parameterized constructor is initializing the value of l,b,h of the specific object using this keyword
        this.b = b;
        this.h = h;
        Console.WriteLine("Calling the paramaterized Constructor");

    }
    public Cuboid()//creating and calling the default constructor for c3 object
    {
        Console.WriteLine("Calling the default constructor");
    }
    public double Volume()
    {
        return l * b * h;
    }
    public double TSA()
    {
        return 2 * (l * b + b * h + h * l);
    }

    public void Display()
    {
        Console.WriteLine("The length is " + l);
        Console.WriteLine("The breath is " + b);
        Console.WriteLine("The height is " + h);

    }




    public static Cuboid operator + (Cuboid d1, Cuboid d2) //operator overloading
    {
        Cuboid d = new Cuboid();//creating a new object named d which stores the added value of the datamembers l,b,h 
        d.l = d1.l + d2.l;
        d.b = d1.b + d2.b;            //ask not working on f11,not understand,how polymorphism====
        d.h = d1.h + d2.h;
        return d;//returing the value to c3
    }

    public static void Main(string[] args)
    {

        //taking value from user
        Console.WriteLine("Enter the value of l");
        double l = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value of b");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value of h");
        double h = Convert.ToDouble(Console.ReadLine());
        Cuboid c1 = new Cuboid(l, b, h);//creating the new object c1 paramatarized
        c1.Display();
        Console.WriteLine("Volume of first cuboid is " + c1.Volume());
        Console.WriteLine("TSA of the first cuboid is " + c1.TSA());


        //pred defined valu not taking from user 
        Cuboid c2 = new Cuboid(10, 20, 30);//creating the new object c2 paramatazied 
        c2.Display();
        Console.WriteLine("Volume of first cuboid is " + c2.Volume());
        Console.WriteLine("TSA of the first cuboid is " + c2.TSA());




        //C3=user taking + pre deined value
        Cuboid c3 = new Cuboid();//creating the new object c3 default constructor
        c3 = c1 + c2;//storing the sum of the two object c1+c2/storing the value of the operated object d returned from operator overloading to c3.Now the value of l,b,h of objects c1 and c2 are added to each other.
        c3.Display();//Will display the new added l,b,h of the new object 
        Console.WriteLine("Volume of the third cuboid(l,b,h as the sum of the other two cuboids) is " + c3.Volume());//Will return and print the TSA of the newly added l,b,h of the new object
        Console.WriteLine("TSA of the third cuboid(l,b,h as the sum of the other two cuboids) is " + c3.TSA());//Will return and print the TSA of the newly added l,b,h of the new object
    }







}
