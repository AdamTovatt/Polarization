﻿using System;
using System.Collections.Generic;
using System.Drawing;

namespace Polarization.Models
{
    class Graph
    {
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
            this.updateView();
        }

        public void draw(Graphics graphics)
        {
            for (int i = 0; i < this.axis.data().Length; ++i)
            {
                Polygon pixel = this.axis.data()[i].project(this.view).rotate(this.view).pixel(this.origin, this.scale);

                Pen pen = new Pen(Color.Black, 2);
                graphics.DrawPolygon(pen, pixel.GetPoints());
            }
            for (int j = 0; j < this.wave.data().Length; ++j)
            {
                Polygon pixel2 = this.wave.data()[j].project(this.view).rotate(this.view).pixel(this.origin, this.scale);

                Pen pen = new Pen(wave.Colors[j], 3);
                graphics.DrawPolygon(pen, pixel2.GetPoints());
            }
        }

        public void update()
        {
            this.axis.update();
            this.wave.update();
            this.updateView();
        }

        public void update(double n)
        {
            this.wave.update(n);
        }

        public void updateView()
        {
            double[] boundingBox = this.axis.data()[0].rotate(this.view).boundingBox();
            double min = Math.Min((this.w - 1) / (boundingBox[3] - boundingBox[0]), (this.h - 1) / (boundingBox[4] - boundingBox[1]));
            double n = -min;
            double n2 = (boundingBox[0] + boundingBox[3]) / 2.0 - (this.w - 1) / (2.0 * min);
            double n3 = (boundingBox[1] + boundingBox[4]) / 2.0 - (this.h - 1) / (2.0 * n);
            this.scale = new Vector(min, n, 1.0);
            this.origin = new Vector(n2, n3, 0.0);
        }
    }
}
