using OpenTK.Graphics.OpenGL;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Punto
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }

        public Punto()
        {
            x = 0.0f;
            y = 0.0f;
            z = 0.0f;
        }

        public Punto(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }


    }
}
