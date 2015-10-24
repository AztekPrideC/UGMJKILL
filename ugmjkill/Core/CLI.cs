using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ugmjkill.Core
{
    public class CLI
    {
        public void comando(string [] args)
        {
            //ejemplo de algunos comandos falta agregar los demas estos solo son de pruebas
            string comando = args[0];
            string nombreDeLaPagina = "";
            if (comando.ToLower().Equals("newsite"))
            {
                nombreDeLaPagina = args[1];
                //el nombre sera el nombre de la carpeta
                //crea los archivos necesarios
            }
            else if (comando.ToLower().Equals("help"))
            {
                Console.WriteLine("newsite + nombre de la pagina que se va crear");
                Console.WriteLine("openserver / abre un servidor estatico");
                Console.WriteLine("config -user/ el nombre de usuario");
                Console.WriteLine("config -password/ contraseña del usuario");
            }
            else
            {
                Console.WriteLine("\"" + comando + "\" no se reoconoce como un comando ejecutable de ugmjkill ");
            }
            
        }
    }
}
