using System.Drawing;

namespace Polarization.Models
{
    interface ObjectToDraw
    {
        Color[] color();
        Polygon[] data();
        void update();
        void update(double p0);
    }
}
