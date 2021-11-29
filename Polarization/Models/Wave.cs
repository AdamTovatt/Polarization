using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polarization.Models
{
    class Wave : ObjectToDraw
    {
        public Color[] Colors { get; set; }

        public int N;
        public int M;
        public double t;
        public double[] bb;
        public double[] a;
        public Vector[] e;
        public Vector[] n;
        public double[] k;
        public double[] w;
        public double[] d;
        public double rmin;
        public double rmax;
        public Polygon[] p;
        public Color[] c;

        public Wave(Color primaryColor, Color secondaryColor, double n, Vector vector, Vector vector2, double n2, double n3, double n4, double[] bb)
        {
            Colors = new Color[2];
            Colors[0] = primaryColor;
            Colors[1] = secondaryColor;

            this.N = 200;
            this.a = new double[2];
            this.e = new Vector[2];
            this.n = new Vector[2];
            this.k = new double[2];
            this.w = new double[2];
            this.d = new double[2];
            this.p = new Polygon[2];
            this.t = 0.0;
            this.M = 1;
            this.a[0] = n;
            this.e[0] = vector.normalize();
            this.n[0] = vector2.normalize();
            this.k[0] = 6.283185307179586 / n2;
            this.w[0] = 6.283185307179586 * n3;
            this.d[0] = n4;
            this.bb = bb;
            this.update();
        }

        public void add(Wave wave)
        {
            for (int i = 0; i < wave.M; ++i)
            {
                this.a[this.M + i] = wave.a[i];
                this.e[this.M + i] = wave.e[i];
                this.n[this.M + i] = wave.n[i];
                this.k[this.M + i] = wave.k[i];
                this.w[this.M + i] = wave.w[i];
                this.d[this.M + i] = wave.d[i];
            }
            this.M += wave.M;
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
            this.rmin = Math.Min(this.bb[0] / this.n[0].x, this.bb[3] / this.n[0].x);
            this.rmin = Math.Max(this.rmin, Math.Min(this.bb[1] / this.n[0].y, this.bb[4] / this.n[0].y));
            this.rmin = Math.Max(this.rmin, Math.Min(this.bb[2] / this.n[0].z, this.bb[5] / this.n[0].z));
            this.rmax = Math.Max(this.bb[0] / this.n[0].x, this.bb[3] / this.n[0].x);
            this.rmax = Math.Min(this.rmax, Math.Max(this.bb[1] / this.n[0].y, this.bb[4] / this.n[0].y));
            this.rmax = Math.Min(this.rmax, Math.Max(this.bb[2] / this.n[0].z, this.bb[5] / this.n[0].z));
            this.update(0.0);
        }

        public void update(double n)
        {
            this.t += n;
            Vector[] array = new Vector[this.N];
            for (int i = 0; i < this.N; ++i)
            {
                Vector scale = this.n[0].scale(i * (this.rmax - this.rmin) / (this.N - 1) + this.rmin);
                array[i] = scale;
                for (int j = 0; j < this.M; ++j)
                {
                    array[i] = array[i].add(this.e[j].scale(this.a[j] * Math.Cos(this.k[j] * this.n[j].mult(scale) - this.w[j] * this.t + this.d[j])));
                }
            }
            this.p[0] = new Polygon(array);
            Vector[] array2 = new Vector[5];
            Vector vector = new Vector(0.0, 0.0, 0.0);
            array2[1] = (array2[0] = vector);
            for (int k = 0; k < this.M; ++k)
            {
                array2[1] = array2[1].add(this.e[k].scale(this.a[k] * Math.Cos(this.k[k] * this.n[k].mult(vector) - this.w[k] * this.t + this.d[k])));
            }
            Vector subtract = array2[1].subtract(vector);
            Vector scale2 = subtract.prod(this.n[0]).subtract(subtract).scale(0.2);
            Vector prod = scale2.prod(this.n[0]);
            array2[2] = array2[1].add(scale2);
            array2[3] = array2[1];
            array2[4] = array2[1].add(prod);
            this.p[1] = new Polygon(array2);
        }
    }
}
