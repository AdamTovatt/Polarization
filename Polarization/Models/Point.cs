using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polarization.Models
{
    public class ScreenPoint
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public ScreenPoint(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
