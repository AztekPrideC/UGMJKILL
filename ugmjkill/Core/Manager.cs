using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ugmjkill.Core
{
    public class Manager
    {
        public static bool crearArbol(bool crear)
        {
            string cPagina = @"C:\Users\Public\Pagina";
            string cTemplate = @"C:\Users\Public\Pagina\Template";
            string cCSS = @"C:\Users\Public\Pagina\CSS";
            string cPosts = @"C:\Users\Public\Pagina\POSTS";

            // generar junto al .exe

            if (crear == true)
            {
                System.IO.Directory.CreateDirectory(cPagina);
                System.IO.Directory.CreateDirectory(cTemplate);
                System.IO.Directory.CreateDirectory(cCSS);
                System.IO.Directory.CreateDirectory(cPosts);

                var tHeater = "C:\\Users\\Public\\Pagina\\Template\\Heater.html";
                var tMainContent = "C:\\Users\\Public\\Pagina\\Template\\MainContent.html";
                var tFooter = "C:\\Users\\Public\\Pagina\\Template\\Footer.html";

                // crear el fichero
                using (var fileStream = System.IO.File.Create(tHeater))
                {
                    var texto = new UTF8Encoding(true).GetBytes("Heater");
                    fileStream.Write(texto, 0, texto.Length);
                    fileStream.Flush();
                } using (var fileStream = System.IO.File.Create(tMainContent))
                {
                    var texto = new UTF8Encoding(true).GetBytes("MContent");
                    fileStream.Write(texto, 0, texto.Length);
                    fileStream.Flush();
                } using (var fileStream = System.IO.File.Create(tFooter))
                {
                    var texto = new UTF8Encoding(true).GetBytes("Footer");
                    fileStream.Write(texto, 0, texto.Length);
                    fileStream.Flush();
                }
            }

            return false;
        }
    }
}
