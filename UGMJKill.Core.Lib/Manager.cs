using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGMJKill.Core.Lib
{
    public static class Manager
    {
        public static void  crearArbol()
        {
            string cPagina = "Pagina";
            string cTemplate = "Pagina\\Template";
            string cCSS = "Pagina\\CSS";
            string cPosts = "Pagina\\POSTS";

            // generar junto al .exe

            if (true)
            {
                System.IO.Directory.CreateDirectory(cPagina);
                System.IO.Directory.CreateDirectory(cTemplate);
                System.IO.Directory.CreateDirectory(cCSS);
                System.IO.Directory.CreateDirectory(cPosts);

                var config = "Pagina\\config.file";
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
                } using (var fileStream = System.IO.File.Create(config)) 
                {
                    var texto = new UTF8Encoding(true).GetBytes("confing\r\n@namesite=UGMJKILL\r\n@user=UGM\r\n@userfacebook=UGM");
                    fileStream.Write(texto, 0, texto.Length);
                    fileStream.Flush();

                }
            }
        }
    }
}
