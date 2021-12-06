using System.Drawing;

namespace Polarization.Models
{
    class Axis : ObjectToDraw
    {
        public Color[] Colors { get; set; }
        public Polygon[] Data { get; set; }

        public double[] bb;
        public Color[] c;


        public Axis(double[] bb)
        {
            this.bb = new double[6];
            Data = new Polygon[1];
            this.c = new Color[1];
            this.bb = bb;
            this.c[0] = System.Drawing.Color.Black;
            this.Update();
        }

        public Color[] Color()
        {
            return this.c;
        }

        public void Update()
        {
            Data[0] = new Polygon(new Vector[] { new Vector(this.bb[0], 0.0, 0.0), new Vector(this.bb[3], 0.0, 0.0), new Vector(0.0, 0.0, 0.0), new Vector(0.0, this.bb[1], 0.0), new Vector(0.0, this.bb[4], 0.0), new Vector(0.0, 0.0, 0.0), new Vector(0.0, 0.0, this.bb[2]), new Vector(0.0, 0.0, this.bb[5]) });
        }

        public void Update(double n)
        {
        }
    }
}
