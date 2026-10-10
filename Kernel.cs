using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading;
using Sys = Cosmos.System;

namespace Cosmoscircles
{
    class graf
    {
        public static Canvas canvas;
        public static Bitmap bitmap;

        public static void Points(int x, int y)
        {


            Pen p = new Pen(Color.FromArgb(0, 0, 0));
            canvas.DrawPoint(p, x, y);





        }

        public static void starts()
        {


            canvas = FullScreenCanvas.GetFullScreenCanvas();
            Sys.MouseManager.ScreenWidth = (uint)1023;
            Sys.MouseManager.ScreenHeight = (uint)798;



        }
        public static void displays()
        {

            canvas.Display();


        }
        public static void cls(Color c)
        {


            canvas.Clear(c);

        }

    }


    public class Kernel : Sys.Kernel
    {
        static int x = 0; static int y = 0;
        protected override void BeforeRun()
        {
            Console.WriteLine("Cosmos booted successfully. Type a line of text to get it echoed back.");
        }

        protected override void Run()
        {
            while (true)
            {
                graf.starts();
                graf.canvas.Clear(Color.White);
                while (true)
                {
                    Thread.Sleep(10);

                    tests.mainLoop();



                    ;

                }
            }


        }
    }





    class tests



    {

        static int x = 512, w = 7, r = 40, y = 400;
        public static void mainLoop()
        {
            //


            Pen p = new Pen(Color.Black, 3);
            graf.canvas.Clear(Color.White);


            graf.canvas.DrawCircle(p, new Sys.Graphics.Point(x, y), r);
            r = r + 1;
            if (r > 190)
            {
                r = 0;
                
            }
            graf.displays();


        }

    }






}
