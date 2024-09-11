using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using OpenTK.Audio.OpenAL;

namespace ConsoleApp1
{
    internal class Polígono
    {
        public Punto centroPol { get; set; }
        public IDictionary<string, Punto> ListaDePuntos { get; set; }

        public Polígono()
        {
            centroPol=new Punto();
            ListaDePuntos = new Dictionary<string, Punto>();
        }

        public Polígono(Punto c)
        {
            centroPol = c;
            ListaDePuntos = new Dictionary<string, Punto>();
        }

        public Polígono(Dictionary<string, Punto> listaPunt)
        {
            centroPol = new Punto();
            ListaDePuntos = listaPunt;
        }

        public void anadirPunto(string clave, Punto valor)
        {
            ListaDePuntos.Add(clave, valor);
        }

        public void Dibujar()
        {
            GL.Begin(PrimitiveType.LineLoop);
            foreach (var item in ListaDePuntos)
            {
                GL.Vertex3(item.Value.x+centroPol.x, item.Value.y+ centroPol.y, item.Value.z+ centroPol.z);
                //Console.WriteLine(item.Key);
            }
            GL.End();
            GL.Flush();
        }
    }
}
