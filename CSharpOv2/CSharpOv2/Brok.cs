﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOv2
{
    public class Brok
    {

        private double _teller, _nevner;

        public Brok()
        {
            _teller = 0;
            _nevner = 1;
        }

        public Brok(int teller) : this()
        {
            Teller = teller;
            Nevner = 1;
        }

        public Brok(int teller, int nevner) : this()
        {
            Teller = teller;
            Nevner = nevner;
        }

        public Brok(Brok forrigeBrok) : this()
        {
            Teller = forrigeBrok.Teller;
            Nevner = forrigeBrok.Nevner;
        }

        public double Teller
        {
            get { return _teller; }
            set { _teller = value; }
        }

        public double Nevner
        {
            get { return _nevner; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Verdi kan ikke være null");
                }

                _nevner = value;
            }
        }

        public double Verdi()
        {
            return Teller / Nevner;
        }

        public string Forkort(int a, int b)
        {
            int bcf = BCF(a, b);
            
            a /= bcf;
            b /= bcf;

            return "Forkortet versjon: " + a + "/" + b;
        }

        public int BCF(int a, int b)
        {
            return b == 0 ? a : BCF(b, a % b);
        }
    }
}
