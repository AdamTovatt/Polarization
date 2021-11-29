using System.Drawing;

namespace Polarization.Models
{
    interface ObjectToDraw
    {
        Color[] Colors { get; set; }

        Color[] color();
        Polygon[] data();
        void update();
        void update(double p0);
    }
}
