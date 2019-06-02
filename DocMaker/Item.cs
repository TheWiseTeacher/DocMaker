using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DocMaker
{


    class Item : ICloneable
    {
        public enum TYPE
        {
            LABEL,
        }

        public TYPE Type { get; set; }
        public bool Visible { get; set; }

        public int X { get; set; }
        public int Y { get; set; }
        public int S { get; set; }

        public bool CX { get; set; }
        public bool CY { get; set; }

        public string VA { get; set; }
        public string HA { get; set; }

        public int FS { get; set; }
        public int OF { get; set; }


        public string Title { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    public struct LayoutHeader
    {
        public char TYPE;
        public char DECODER;
        public Int32 SIZE;
        public Int32 IMGS;
    }

    public struct LayoutTextData
    {
        public char TS;

        public double X;
        public double Y;
        public double S;

        public bool CX;
        public bool CY;

        public char HA;
        public char VA;

        public char FS;
        public char FLAGS;
    }
}
