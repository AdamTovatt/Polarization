using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polarization.Models
{
    class Polygon
    {
        Vector[] r;

        public Polygon(Vector[] r)
        {
            this.r = r;
        }

        public double[] boundingBox()
        {
            double[] array = { Math.Exp(1000.0), Math.Exp(1000.0), Math.Exp(1000.0), -Math.Exp(1000.0), -Math.Exp(1000.0), -Math.Exp(1000.0) };
            for (int i = 0; i < this.r.Length; ++i)
            {
                array[0] = Math.Min(array[0], this.r[i].x);
                array[1] = Math.Min(array[1], this.r[i].y);
                array[2] = Math.Min(array[2], this.r[i].z);
                array[3] = Math.Max(array[3], this.r[i].x);
                array[4] = Math.Max(array[4], this.r[i].y);
                array[5] = Math.Max(array[5], this.r[i].z);
            }
            return array;
        }

        public int[] intx()
        {
            int[] array = new int[this.r.Length];
            for (int i = 0; i < this.r.Length; ++i)
            {
                array[i] = (int)this.r[i].x;
            }
            return array;
        }

        public int[] inty()
        {
            int[] array = new int[this.r.Length];
            for (int i = 0; i < this.r.Length; ++i)
            {
                array[i] = (int)this.r[i].y;
            }
            return array;
        }

        public int[] intz()
        {
            int[] array = new int[this.r.Length];
            for (int i = 0; i < this.r.Length; ++i)
            {
                array[i] = (int)this.r[i].z;
            }
            return array;
        }

        public int length()
        {
            return this.r.Length;
        }

        public Polygon pixel(Vector vector, Vector vector2)
        {
            Vector[] array = new Vector[this.r.Length];
            for (int i = 0; i < this.r.Length; ++i)
            {
                array[i] = this.r[i].subtract(vector);
                array[i] = new Vector((double)Math.Round(array[i].x * vector2.x), (double)Math.Round(array[i].y * vector2.y), (double)Math.Round(array[i].z * vector2.z));
            }
            return new Polygon(array);
        }

        public Polygon project(Vector vector)
        {
            Vector[] array = new Vector[this.r.Length];
            Vector normalize = vector.normalize();
            double abs = vector.abs();
            for (int i = 0; i < this.r.Length; ++i)
            {
                double mult = this.r[i].mult(normalize);
                array[i] = this.r[i].subtract(normalize.scale(mult)).scale(1.0 / (1.0 - mult / abs));
            }
            return new Polygon(array);
        }

        public Polygon rotate(Vector vector)
        {
            Vector[] array = new Vector[this.r.Length];
            Vector normalize = vector.normalize();
            Vector normalize2 = normalize.subtract(Vector.UnitY.scale(normalize.mult(Vector.UnitY))).normalize();
            Vector vector2;
            if (normalize2.abs() != 0.0)
            {
                vector2 = Vector.UnitY.prod(normalize2);
            }
            else
            {
                vector2 = Vector.UnitX;
            }
            Vector vector3 = normalize;
            Vector prod = vector3.prod(vector2);
            for (int i = 0; i < this.r.Length; ++i)
            {
                array[i] = new Vector(this.r[i].mult(vector2), this.r[i].mult(prod), this.r[i].mult(vector3));
            }
            return new Polygon(array);
        }

        public double[] x()
        {
            double[] array = new double[this.r.Length];
            for (int i = 0; i < this.r.Length; ++i)
            {
                array[i] = this.r[i].x;
            }
            return array;
        }

        public double[] y()
        {
            double[] array = new double[this.r.Length];
            for (int i = 0; i < this.r.Length; ++i)
            {
                array[i] = this.r[i].y;
            }
            return array;
        }

        public double[] z()
        {
            double[] array = new double[this.r.Length];
            for (int i = 0; i < this.r.Length; ++i)
            {
                array[i] = this.r[i].z;
            }
            return array;
        }
    }
}
