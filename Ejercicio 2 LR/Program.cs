using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2_LR
{
    class Program
    {
        static void Main(string[] args)
        {
            string login, password;
            string usuario = "sisadmin";
            string contraseña = "admin3.0";
            string pregunta;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite su usuario");
                login = Console.ReadLine();

                Console.WriteLine("Digite su contraseña");
                password = Console.ReadLine();

                if ((login == usuario) && (password == contraseña))
                {
                    Console.WriteLine($"Bienvenido {login}");
                    break;

                }
                else
                {
                    Console.WriteLine($"Los datos son incorrectos \n{login} {password} no coinciden");

                }



            }

            Console.WriteLine("¿Quieres cambiar tu contraseña? s/n");
            pregunta = Console.ReadLine();
            if (pregunta == "s")
            {
                Console.WriteLine("Digita nueva contrasena");
                contraseña = Console.ReadLine();

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine("Digite su usuario");
                    login = Console.ReadLine();

                    Console.WriteLine("Digite su contrasena");
                    password = Console.ReadLine();

                    if ((login == usuario) && (password == contraseña))
                    {
                        Console.WriteLine("Bienvenido");
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Los datos son incorrectos");
                    }

                }


            }
            else
            {

            }
            Console.ReadLine();



        }
    }
}
