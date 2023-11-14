using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class TomorHenger : Henger
    {
        private double vasFajsuly;

        public TomorHenger(double sugar, double magassag, double vasFajsuly) : base(sugar,magassag)
        {
            this.vasFajsuly = vasFajsuly;
        }

        public TomorHenger(double sugar, double magassag) : base(sugar,magassag)
        {
            this.vasFajsuly = 7.87;
        }

        public double VasFajsuly { get => vasFajsuly;}

        public string ToString()
        {
            return $"TomorHenger: Sugar = {sugar}, Magasság = {magassag}, Vas Fajsúly = {vasFajsuly}, Térfogat = {Terfogat()}";
        }
    }
}
