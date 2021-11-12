using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;

/*
 * Outline: 
 * NameSpaces
 * Classes
 * 
 * 
 */
// NameSpaces

//Namespaces are heavily used in C# programming in two ways. First, .NET uses namespaces to organize its many classes, as follows:
//System is a namespace and Console is a class in that namespace. The using keyword can be used so that the complete name isn't required

// declaring your own namespaces can help you control the scope of class and method names in larger programming projects.
// Use the namespace keyword to declare a namespace, as in the

namespace TypeSystem{ // namespace defination
    
    // class must be public 
    public static class Program{ // custom data type insort

        public static void Main(){// c# main Method
            Car car = new Car("MyCar", 2); // declaring Class
            Console.WriteLine(car.ToString());

            
        }

        // swaping using generics
        static void Swap<T>(T val1, T val2){
            T temp = val1;
            val1 = val2;
            val2 = temp;
        }

    }

    // classes
    public class Car{

        // Constructor that takes no arguments
        public Car(){
            carName = "";
            id = 0;
        }

        // Constructor that takes arguments
        public Car(string carName,int id){
            this.carName = carName;
            this.id = id;
        }

        // Method that overrides the base class (System.Object) implementation.
        public override string ToString(){
            return carName + " : " + id;
        }

        // Vars
        public string carName; // public method
        public int id { get; private set; } // setter & Getter

    }

    // Records
    /*
     * When to use records
       Consider using a record in place of a class or struct in the following scenarios:

       You want to define a data model that depends on value equality.
       You want to define a type for which objects are immutable.
     */
     // Generic 
     
    
}
