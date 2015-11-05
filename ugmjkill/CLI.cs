using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ugmjkill.Core
{
    public class CLI
    {
        
        public static void Main(string[] args)
        {

            string comando = args[0];
            string nombreDeLaPagina = "";
            switch (comando.ToLower())
            {
                case "-help":
                case "help":
                case "--help":
                    Console.WriteLine("         [newsite] or [-newsite] ");
                    Console.WriteLine("         [newsite] or [-newsite] + [-name] ");
                    Console.WriteLine("         [openserver] abre un servidor estatico");
                    Console.WriteLine("         [config] [-all]");
                    Console.WriteLine("         [config] [-name] el nombre de la pagina");
                    Console.WriteLine("         [config] [-user] el nombre de usuario");
                    Console.WriteLine("         [config] [-password] contraseña del usuario");
                    break;
                case "config":
                    switch (args[1])
                    {
                        case "-all":
                        case "all":
                            Console.WriteLine("Ingrese el nombre de la pagina");
                            nombreDeLaPagina = Console.ReadLine();
                            break;
                        case "-name":
                            Console.WriteLine("Ingrese el nombre de la pagina");
                            nombreDeLaPagina = Console.ReadLine();
                            break;

                        default:
                            break;
                    }
                    break;


                case "newsite":
                case "-newsite":
                    switch (args[1])
                    {
                        case "-name":
                            Console.WriteLine("Ingrese el nombre de la pagina");
                            nombreDeLaPagina = Console.ReadLine();
                            Console.WriteLine("Se ha creado con exito en la ruta predeterminada");

                            break;

                        default:
                            if (args[1] == null)
                            {
                                Console.WriteLine("Se ha creado con exito en la ruta predeterminada");
                            }
                            else
                            {
                                Console.WriteLine("esta seguro que desea llamar asi " + "\"" + args[1] + "\"");
                                string respuesta = Console.ReadLine();
                                switch (respuesta.ToLower())
                                {
                                    case "si":
                                    case "yes":
                                        nombreDeLaPagina = args[1];
                                        Console.WriteLine("Se ha creado con exito en la ruta predeterminada");
                                        break;
                                    case "no":
                                    default:
                                        Console.WriteLine("Se ha creado con exito en la ruta predeterminada con el nombre por default");
                                        break;
                                }
                            }
                            break;
                    }

                    break;

                default:
                    string argumentoCompleto = "";
                    for (int i = 0; i < args.Length; i++)
                    {
                        argumentoCompleto += args[i] + " ";
                    }
                    Console.WriteLine("\"" + argumentoCompleto + "\" no se reoconoce como un comando ejecutable de ugmjkill ");
                    break;
            }
            
            
        }
    }
}
