using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Objeto
    {
        public Punto centro { get; set; }
        public IDictionary<string, Parte> listaDeParte { get; set; }

        public Objeto()
        {
            centro= new Punto();
            listaDeParte= new Dictionary<string, Parte>();
        }

        public Objeto(Punto c)
        {
            centro = c;
            listaDeParte = new Dictionary<string, Parte>();
        }

        public void anadir(string clave, Parte valor)
        {
            listaDeParte.Add(clave, valor);
        }

        public void Dibujar()
        {
            foreach (var item in listaDeParte)
            {
                item.Value.Dibujar();
            }
        }
    }
}
