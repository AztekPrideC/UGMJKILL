using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ugmjkill.Core
{
    public class Manager
    {
        public void  crearArbol(bool crear)
        {
            string cPagina = "Pagina";
            string cTemplate = "Pagina\\Template";
            string cCSS = "Pagina\\CSS";
            string cPosts = "Pagina\\POSTS";

            // generar junto al .exe

            if (crear == true)
            {
                System.IO.Directory.CreateDirectory(cPagina);
                System.IO.Directory.CreateDirectory(cTemplate);
                System.IO.Directory.CreateDirectory(cCSS);
                System.IO.Directory.CreateDirectory(cPosts);

                var tHeater = "Pagina\\Template\\Heater.tpl";
                var tMainContent = "Pagina\\Template\\MainContent.tpl";
                var tFooter = "Pagina\\Template\\Footer.tpl";

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
        }
    }
}
