﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        public static double Osszead(double egyikszam, double masikszam)
        {
            return egyikszam + masikszam;
        }
        public static double Kivon(double egyikszam, double masikszam)
        {
            return egyikszam - masikszam;
        }
        public static double Szorzas(double egyikszam, double masikszam)
        {
            return egyikszam * masikszam;
        }
        public static double Osztas(double egyikszam, double masikszam)
        {
            return egyikszam / masikszam;
        }
        public static void CE(double masikszam)
        {
            masikszam = 0;
            return;
        }
        public static void C(double egyikszam, double masikszam)
        {
            egyikszam = 0;
            masikszam = 0;
            return;
        }
    }
}
