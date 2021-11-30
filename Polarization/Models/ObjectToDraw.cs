using System.Drawing;

namespace Polarization.Models
{
    interface ObjectToDraw
    {
        Color[] Colors { get; set; }
        Polygon[] Data { get; set; }

        Color[] color();
        void update();
        void update(double p0);
    }
}
