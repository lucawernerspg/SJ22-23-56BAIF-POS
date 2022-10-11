using System;
using System.Runtime;

namespace ExProperties.App
{
    internal class Rechteck
    {
        private int laeng;
        public int Laenge

        {
            get
            {
                return laeng;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("fuck you");
                }
                else
                {
                    laeng = value;
                }
            }
        }

        private int breit;

        public int Breite
        {
            get
            {
                return breit;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("fuck you");
                }
                else
                {
                    breit = value;
                }
            }
        }

        public decimal Flaeche
        {
            get
            {
                return (decimal)Laenge * (decimal)Breite;
            }
        }

    }

}