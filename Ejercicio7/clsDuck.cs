using System;

namespace Ejercicio7
{
    public abstract class clsDuck
    {
        
        // Constructor
        public clsDuck()
        {

        }

        public void Swim()
        {
            Console.WriteLine("I´m Swiming");
        }


        public void Quack()
        {
            Console.WriteLine("I´m quacking");
        }

        public abstract void display();


    }
}