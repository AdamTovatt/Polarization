using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polarization.Models
{
    class Vector
    {
        public double x;
        public double y;
        public double z;

        public static readonly Vector UnitX = new Vector(1.0, 0.0, 0.0);
        public static readonly Vector UnitY = new Vector(0.0, 1.0, 0.0);
        public static readonly Vector UnitZ = new Vector(0.0, 0.0, 1.0);

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double abs()
        {
            return Math.Sqrt(this.x * this.x + this.y * this.y + this.z * this.z);
        }

        public Vector add(Vector vector)
        {
            Vector vector2 = new Vector(0.0, 0.0, 0.0);
            vector2.x = this.x + vector.x;
            vector2.y = this.y + vector.y;
            vector2.z = this.z + vector.z;
            return vector2;
        }

        public double mult(Vector vector)
        {
            return this.x * vector.x + this.y * vector.y + this.z * vector.z;
        }

        public Vector normalize()
        {
            Vector scale = new Vector(0.0, 0.0, 0.0);
            if (this.abs() != 0.0)
            {
                scale = this.scale(1.0 / this.abs());
            }
            return scale;
        }

        public Vector prod(Vector vector)
        {
            Vector vector2 = new Vector(0.0, 0.0, 0.0);
            vector2.x = this.y * vector.z - this.z * vector.y;
            vector2.y = this.z * vector.x - this.x * vector.z;
            vector2.z = this.x * vector.y - this.y * vector.x;
            return vector2;
        }

        public Vector scale(double n)
        {
            Vector vector = new Vector(0.0, 0.0, 0.0);
            vector.x = n * this.x;
            vector.y = n * this.y;
            vector.z = n * this.z;
            return vector;
        }

        public Vector subtract(Vector vector)
        {
            Vector vector2 = new Vector(0.0, 0.0, 0.0);
            vector2.x = this.x - vector.x;
            vector2.y = this.y - vector.y;
            vector2.z = this.z - vector.z;
            return vector2;
        }
    }
}
