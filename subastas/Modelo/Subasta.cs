using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subastas.Modelo
{
    internal class Subasta
    {
        //ATRIBUTOS
        Articulo Articulo; //COMPOSICIÓN
        int Puja;
        DateTime Incio;
        int Duracion;
        List<Postor> Postores = new List<Postor>(); //AGREGACION

        //CONSTRUCTORES
        public Subasta(Articulo articulo, int puja, DateTime inicio, int duracion)
        {

            ARTICULO = articulo;
            PUJA = puja;
            INICIO = inicio;
            DURACION = duracion;
        }

    //PROPIEDADES (getters && setters)
        public Articulo ARTICULO
        {
            get { return Articulo; }
            set { Articulo = value; }
        }

        public int PUJA
        { 
          get { return Puja; } 
          set 
            {
                if (value > 0)
                {
                    Puja = value;
                }
                else
                {
                    throw new Exception("La puja debe ser mayo a 0");
                }
            } 

        }

        public DateTime INCIO 
        {
            get { return Incio; }
            set
            {
                if(value >= DateTime.Now)
                {
                    Incio = value;
                }
                else
                {
                    throw new Exception("La fecha de incio de una subasta no puede ser anterior ahora mismo");
                }
            }
            
        }

        public int DURACION
        {
            get { return Duracion; }
            set { Duracion = value; }
        }

        public List<Postor> POSTORES
        { 
            get { return POSTORES; }
        }



        public void SuscribirPostor(Postor postor) 
        {
            bool postorEncontrado = false;
            foreach (Postor AUX in POSTORES)
            {
                if(postor.CODIGO_ACCESO == AUX.CODIGO_ACCESO)
                {
                    postorEncontrado = true;
                    //throw new Exception("El postor ya esta en la subasta");
                }
                else
                {
                    Postores.Add(postor);
                    break;
                }
            }
            return postorEncontrado;
        }
    }
}
