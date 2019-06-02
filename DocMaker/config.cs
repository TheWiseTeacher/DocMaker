﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Drawing.Text;

namespace DocMaker
{
    class config
    {
        public const double PAPER_WIDTH_A4 = 1024;
        public const double PAPER_RATIO_A4 = 1.414d;

        public static double CurrentPaperRatio;

        public static string LastVisitedPath = AppDomain.CurrentDomain.BaseDirectory;


        public static PrivateFontCollection TTF_Jannah;
        public static PrivateFontCollection TTF_Roboto;

        public static void Init()
        {
            CurrentPaperRatio = PAPER_RATIO_A4;

            TTF_Jannah = new PrivateFontCollection();
            //TTF_Jannah.AddFontFile("fonts\\JannaLT-Regular.ttf");

            TTF_Roboto = new PrivateFontCollection();
            //TTF_Roboto.AddFontFile("fonts\\Roboto\\Roboto-Regular.ttf");
        }


        public static List<Item> itemsList = new List<Item>();
        



    }
}
