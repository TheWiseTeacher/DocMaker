using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace DocMaker
{
    public static class Extensions
    {

        public static void Flip(this ref SizeF s)
        {
            float w = s.Width;
            s.Width = s.Height;
            s.Height = w;
        }

        public static void PrintBinary(this uint i)
        {
            string s = Convert.ToString(i, 2).PadLeft(32, '0').Insert(24, " ").Insert(16, " ").Insert(8, " ");

            Console.WriteLine("Binary : " + s);

        }

    }
}
