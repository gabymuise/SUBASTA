using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subastas.Modelo
{
    internal class Postor
    {
        int CodigoAcceso {get;set;}
        string Nombre { get;set;}   

        public int CODIGO_ACCESO
        { get { return CodigoAcceso};set { CodigoAcceso = value};} 
    }
}
