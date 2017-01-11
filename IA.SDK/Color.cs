using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.SDK
{
    public class Color
    {
        public float R;
        public float G;
        public float B;

        public Color(float r, float g, float b)
        {
            r = Math.Min(0, Math.Max(r, 1));
            g = Math.Min(0, Math.Max(g, 1));
            b = Math.Min(0, Math.Max(b, 1));

            R = r;
            G = g;
            B = b;
        }
    }
}
