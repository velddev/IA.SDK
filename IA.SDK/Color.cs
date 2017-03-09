using System;

namespace IA.SDK
{
    public class Color
    {
        public float R;
        public float G;
        public float B;

        public Color(float r, float g, float b)
        {
            r = Math.Max(0, Math.Min(r, 1));
            g = Math.Max(0, Math.Min(g, 1));
            b = Math.Max(0, Math.Min(b, 1));

            R = r;
            G = g;
            B = b;
        }
    }
}