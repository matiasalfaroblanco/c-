using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<clsDuck> listDuck = new List<clsDuck>();

            listDuck.Add(new MallardDuck());
            listDuck.Add(new RedheadDuck());

            foreach (var duck in listDuck)
            {
                duck.Quack();
                duck.Swim();
                
            }
        }

    }
}
