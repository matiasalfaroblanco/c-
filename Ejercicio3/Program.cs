using System;
using Modulo1.Ejercicio3.Utils;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            signUpUser caso =  new signUpUser();

        }

    }
        public class SignUpUserUseCase
        {
            public static signUpUser()
            {
                Name name = new Name("Pepe");
                Status status = new Status(Status.ACTIVED_STATUS);
                User user = new User(name, status);
                Console.WriteLine(user);
                return user;
            } 
        }
   
}
