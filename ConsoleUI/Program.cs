using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */
            var coupe = new Car();
            coupe.Make = "Benz";
            coupe.Model = "C63";
            coupe.Year = "2014";
            coupe.HasTrunk = true;

            var honda = new MotorCycle();
            honda.Make = "Honda";
            honda.Model = "CBR650R";
            honda.Year = "2006";
            honda.HasSideCart = true;

            Vehicle porshe = new Car();
            porshe.Make = "Porshe";
            porshe.Model = "Macan";
            porshe.Year = "2012";


            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */
            var vehicles = new List<Vehicle>() { coupe, honda, porshe };

            // Call each of the drive methods for one car and one motorcycle
            foreach (var vehicle in vehicles) 
            {
                Console.WriteLine($"Make: {vehicle.Make}\nModel\n {vehicle.Model}\nYear: {vehicle.Year}");
                vehicle.DriveVirtual();
                vehicle.DriveAbstract();
            }

            #endregion            
            Console.ReadLine();
        }
    }
}
