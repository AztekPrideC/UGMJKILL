using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UGMJKill.Core.Lib
{
    class GeneradorDeTemplates
    {
        public void createTemplate(string etiqueta, string[] metacomandos) 
        {
            //ejemplo de header
            string cuerpo = "<" + etiqueta + ">+\r\n";
            for (int i = 0; i < metacomandos.Length; i++)
            {
                cuerpo += metacomandos[i] + "\r\n";
            }
            cuerpo+= "</" + etiqueta + ">";
        }
    }
}
