using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Parte
    {
        public Punto centro { get; set; }
        public IDictionary<string, Polígono> listaDePoligono { get; set; }

        public Parte()
        {
            centro=new Punto();
            listaDePoligono = new Dictionary<string, Polígono>();
        }

        public Parte(Punto c)
        {
            centro = c;
            listaDePoligono = new Dictionary<string, Polígono>();
        }

        public void anadirPoligono(string clave, Polígono valor)
        {
            listaDePoligono.Add(clave, valor);
        }

        public void Dibujar()
        {
            foreach (var item in listaDePoligono)
            {
                item.Value.Dibujar();
            }
        }
    }
}
