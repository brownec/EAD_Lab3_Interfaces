// Cliff Browne - X00014810
// EAD lab 3 Interfaces
using System;

/* You are required to redesign the solution you came up with for Lab 1 to use an interface. 
 * Rather than having a ThreeDShape superclass and a Sphere subclass you should define a 
 * IHasVolume interface and make the Sphere class implement it */

namespace Shape
{
/* The program will have one interface and one class: IHasVolume interface
1.	The interface should have a method which calculates the volume of an item */
    public interface IHasVolume
    {
        // public & abstract method to calculate volume of an item
        double CalcVolume();
    }
    
/* Sphere class
1.	The Sphere class should implement the HasVolume interface. */
    public class Sphere : System.Object, IHasVolume
    {
        // 2.	The class should have field and matching read-write property for the radius of the sphere.
        private double radius;
        // 3.	Implement appropriate constructors for the class.
        public Sphere(double radius)
        {
            Radius = radius;
        }
        public Sphere()
            : this(0)
        {

        }
        // 4.	Implement appropriate properties for the class. (Getter and Setter)
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                if (value >= 0)
                {
                    radius = value;
                }
                else
                {
                    throw new ApplicationException("Radius must be positive!");
                }
            }
        }

        /* 5.	Implement a method to calculate the volume of the sphere i.e. PI * radius * radius * radius. 
                This method is required since the class implements the IHasVolume interface. */
        public virtual double CalcVolume()
        {
            return Math.PI * Radius * Radius;
        }

        // 6.	Override the ToString() method inherited from Object, make it display information about the sphere.
        public override string ToString()
        {
            return "A Sphere of radius: " + radius.ToString();
        }
    }
}

    // 7.	Test the class.
    class Program
    {
        public static void Main()
        {
            // 8.	Make a collection of spheres and call various methods.
            //Shape.IHasVolume[] collection = new Shape.Sphere(), new Shape.Sphere(10);
            Shape.IHasVolume[] collection = new Shape.Sphere().Shape.Sphere(10);  
            /* Call the method to calculate the volume of a sphere polymorphically 
                * via a reference of type IHasVolume. */
            foreach(Shape.IHasVolume s in collection)
            {
                // Display details of the sphere object.
                Console.WriteLine(s + " volume: " + s.CalcVolume());
            }
        }
    }

