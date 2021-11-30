using System;
using System.Collections.Generic;
using System.Drawing;

namespace Polarization.Models
{
    class Graph
    {
        public double Zoom { get; set; } = 1;

        public int w;
        public int h;
        public Vector view;
        public Vector origin;
        public Vector scale;
        public ObjectToDraw axis;
        public ObjectToDraw wave;

        public Graph(int w, int h, ObjectToDraw axis, ObjectToDraw wave, Vector view)
        {
            this.w = w;
            this.h = h;
            this.axis = axis;
            this.wave = wave;
            this.view = view;
            updateView();
        }

        private void DrawAxis(Graphics graphics)
        {
            for (int i = 0; i < axis.Data.Length; ++i)
            {
                Polygon pixel = axis.Data[i].project(view).rotate(view).pixel(origin, scale);

                Pen pen = new Pen(Color.Black, 2);
                graphics.DrawLines(pen, pixel.GetPoints());
            }
        }

        public void draw(Graphics graphics)
        {
            DrawAxis(graphics);

            for (int j = 0; j < wave.Data.Length; ++j)
            {
                Polygon pixel2 = wave.Data[j].project(view).rotate(view).pixel(origin, scale);

                Pen pen = new Pen(wave.Colors[j], j == 0 ? 3 : 4);
                graphics.DrawLines(pen, pixel2.GetPoints());
            }
        }

        public void update(double n)
        {
            wave.update(n);
        }

        public void updateView()
        {
            double[] boundingBox = axis.Data[0].rotate(view).boundingBox();
            double min = Math.Min((w - 1) / (boundingBox[3] - boundingBox[0]), (h - 1) / (boundingBox[4] - boundingBox[1]));
            double n = -min;
            double n2 = (boundingBox[0] + boundingBox[3]) / 2.0 - (w - 1) / (2.0 * min);
            double n3 = (boundingBox[1] + boundingBox[4]) / 2.0 - (h - 1) / (2.0 * n);
            scale = new Vector(min / Zoom, n / Zoom, 1.0 / Zoom);
            origin = new Vector(n2 * Zoom, n3 * Zoom, 0.0 * Zoom);
        }
    }
}
