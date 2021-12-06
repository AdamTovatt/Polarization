using System.Drawing;

namespace Polarization.Models
{
    interface ObjectToDraw
    {
        Color[] Colors { get; set; }
        Polygon[] Data { get; set; }

        Color[] Color();
        void Update();
        void Update(double p0);
    }
}
