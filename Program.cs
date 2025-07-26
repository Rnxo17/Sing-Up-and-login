using System;

namespace Review
{
    class Program
    {
        static void Main(string[] args)
        {
            //Comienza siempre con el registro, le pide al usuario email o un nombre de usuario
            Console.WriteLine("Let's start with the sign-up.\nEnter your email or username:");
            string registerEmail = Console.ReadLine();
            //Le pide al usuario una contraseña
            Console.WriteLine("Enter your password:");
            string password = Console.ReadLine();
            //Comienza con el inicio de sesion, le vuelve a pedir el email o nombre de usuario con el que se registro
            Console.WriteLine("Let's start with the login.\nEnter your email or username:");
            string loginEmail = Console.ReadLine();
            //Evalua si el email o nombre de usuario del registro es el mismo que con el que ingreso en el inicio de sesion y hay un .ToLower para que sea siempre con minuscula
            if (loginEmail.ToLower() == registerEmail.ToLower())
            {
                //Le pide la contraseña con el que se registro
                Console.WriteLine("Enter your password:");
                string passwordLogin = Console.ReadLine();
                //Evalua si la contraseña del inicio de sesion es la misma que con la que se registro
                if (password == passwordLogin)
                {
                    Console.WriteLine("Access granted");
                }
                else
                {
                    Console.WriteLine("The password is wrong, try again");
                }
            }
            else
            {
                Console.WriteLine("The email or username is wrong, try again");
            }
        }
    }
}
