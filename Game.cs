using OpenTK;
using OpenTK.Graphics;
using OpenTK.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Graphics.OpenGL;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ConsoleApp1
{
    public class Game: GameWindow
    {
        private Escenario escenario2;
        public Game(int width, int height, string title) : base(width, height, GraphicsMode.Default, title)
        {
            escenario2 = new Escenario();
            crearT();

        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            GL.ClearColor(Color4.Black);
            GL.Enable(EnableCap.DepthTest);
        }

        protected override void OnRenderFrame(FrameEventArgs e)
        {
            base.OnRenderFrame(e);

            GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);

            GL.Rotate(1, 0.0, 0.1, 0.1);

            escenario2.Dibujar();

            Context.SwapBuffers();
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            GL.Viewport(0, 0, Width, Height);
        }

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            KeyboardState input = Keyboard.GetState();

            if (input.IsKeyDown(Key.Escape))
            {
                Exit();
            }
        }

        public void crearT()
        {
            //arriba
            //Punto a = new Punto(-0.3f, 0.4f, 0.0f);
            //Punto b = new Punto(-0.3f, 0.2f, 0.0f);
            //Punto c = new Punto(0.3f, 0.2f, 0.0f);
            //Punto d = new Punto(0.3f, 0.4f, 0.0f);

            //Punto a1 = new Punto(-0.3f, 0.4f, 0.2f);
            //Punto b1 = new Punto(-0.3f, 0.2f, 0.2f);
            //Punto c1 = new Punto(0.3f, 0.2f, 0.2f);
            //Punto d1 = new Punto(0.3f, 0.4f, 0.2f);

            ////abajo
            //Punto f = new Punto(-0.1f, 0.2f, 0.0f);
            //Punto g = new Punto(-0.1f, -0.3f, 0.0f);
            //Punto h = new Punto(0.1f, -0.3f, 0.0f);
            //Punto i = new Punto(0.1f, 0.2f, 0.0f);

            //Punto f1 = new Punto(-0.1f, 0.2f, 0.2f);
            //Punto g1 = new Punto(-0.1f, -0.3f, 0.2f);
            //Punto h1 = new Punto(0.1f, -0.3f, 0.2f);
            //Punto i1 = new Punto(0.1f, 0.2f, 0.2f);

            //Polígono frente = new Polígono();
            //frente.anadirPunto("Punto1", a);
            //frente.anadirPunto("Punto2", b);
            //frente.anadirPunto("Punto3", c);
            //frente.anadirPunto("Punto4", d);


            //Polígono atras = new Polígono();
            //atras.anadirPunto("Punto5", a1);
            //atras.anadirPunto("Punto6", b1);
            //atras.anadirPunto("Punto7", c1);
            //atras.anadirPunto("Punto8", d1);

            //Polígono izquierda = new Polígono();
            //izquierda.anadirPunto("Punto9", a1);
            //izquierda.anadirPunto("Punto10", b1);
            //izquierda.anadirPunto("Punto11", b);
            //izquierda.anadirPunto("Punto12", a);

            //Polígono derecha = new Polígono();
            //derecha.anadirPunto("Punto13", d1);
            //derecha.anadirPunto("Punto14", c1);
            //derecha.anadirPunto("Punto15", c);
            //derecha.anadirPunto("Punto16", d);

            //Polígono frente2 = new Polígono();
            //frente2.anadirPunto("P1", f);
            //frente2.anadirPunto("P2", g);
            //frente2.anadirPunto("P3", h);
            //frente2.anadirPunto("P4", i);

            //Polígono atras2 = new Polígono();
            //atras2.anadirPunto("P5", f1);
            //atras2.anadirPunto("P6", g1);
            //atras2.anadirPunto("P7", h1);
            //atras2.anadirPunto("P8", i1);

            //Polígono izquierda2 = new Polígono();
            //izquierda2.anadirPunto("P9", f);
            //izquierda2.anadirPunto("P10", g);
            //izquierda2.anadirPunto("P11", g1);
            //izquierda2.anadirPunto("P12", f1);

            //Polígono derecha2 = new Polígono();
            //derecha2.anadirPunto("P1", i);
            //derecha2.anadirPunto("P2", h);
            //derecha2.anadirPunto("P3", h1);
            //derecha2.anadirPunto("P4", i1);

            //Parte parte1 = new Parte();
            //parte1.anadirPoligono("c1", frente);
            //parte1.anadirPoligono("c2", atras);
            //parte1.anadirPoligono("c3", izquierda);
            //parte1.anadirPoligono("c4", derecha);

            //Parte parte2 = new Parte();
            //parte2.anadirPoligono("c1", frente2);
            //parte2.anadirPoligono("c2", atras2);
            //parte2.anadirPoligono("c3", izquierda2);
            //parte2.anadirPoligono("c4", derecha2);
            //parte2.Dibujar();

            //Objeto objeto1 = new Objeto();
            //objeto1.anadir("Parte1", parte1);
            //objeto1.anadir("Parte2", parte2);
            ////objeto1.Dibujar();

            //string guardar = JsonSerializer.Serialize(objeto1);
            //Console.WriteLine(guardar);
            //File.WriteAllText(@"figura3d.json", guardar);

            Objeto objeto= new Objeto();
            string Json = File.ReadAllText("figura3d.json");
            objeto=JsonSerializer.Deserialize<Objeto>(Json);
            escenario2.anadir("objeto", objeto);


            //anadir.("Objeto1", objeto1);
        }
    }
}
