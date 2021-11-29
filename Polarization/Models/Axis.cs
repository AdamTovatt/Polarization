﻿using System.Drawing;

namespace Polarization.Models
{
    class Axis : ObjectToDraw
    {
        public Color[] Colors { get; set; }

        public double[] bb;
        public Polygon[] p;
        public Color[] c;


        public Axis(double[] bb)
        {
            this.bb = new double[6];
            this.p = new Polygon[1];
            this.c = new Color[1];
            this.bb = bb;
            this.c[0] = Color.Black;
            this.update();
        }

        public Color[] color()
        {
            return this.c;
        }

        public Polygon[] data()
        {
            return this.p;
        }

        public void update()
        {
            this.p[0] = new Polygon(new Vector[] { new Vector(this.bb[0], 0.0, 0.0), new Vector(this.bb[3], 0.0, 0.0), new Vector(0.0, 0.0, 0.0), new Vector(0.0, this.bb[1], 0.0), new Vector(0.0, this.bb[4], 0.0), new Vector(0.0, 0.0, 0.0), new Vector(0.0, 0.0, this.bb[2]), new Vector(0.0, 0.0, this.bb[5]) });
        }

        public void update(double n)
        {
        }
    }
}
