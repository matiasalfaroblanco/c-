using System;
using Modulo1.Ejercicio3.Utils;


namespace Modulo1.Ejercicio3
{
    public class SignUpUserUseCase
    {
        public static User signUpUser()
        {
            Name name = new Name("Pepe");
            Status status = new Status(Status.ACTIVED_STATUS);
            User user = new User(name, status);
            Console.WriteLine(user);
            return user;
        } 
    }
}