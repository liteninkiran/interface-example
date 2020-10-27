// C# program to demonstrate working of  
// interface 
using System;

// A simple interface 
interface inter1
{
    // method having only declaration  
    // not definition 
    void display();
}

// A class that implements interface. 
class testClass : inter1
{

    // providing the body part of function 
    public void display()
    {
        Console.WriteLine("Hello World!");
    }

    // Main Method 
    public static void Main_Method()
    {

        // Creating object 
        testClass t = new testClass();

        // calling method 
        t.display();
    }
}