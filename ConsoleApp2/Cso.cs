using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Cso : Henger
    {
        private double falVastagsag;

        public Cso(double sugar, double magassag) : base(sugar, magassag)
        {
            this.falVastagsag = 1.0;
        }

        public Cso(double sugar, double magassag, double falVastagsag) : base(sugar, magassag)
        {
            this.falVastagsag = falVastagsag;
        }

        public Cso(double sugar, double magassag, double falVastagsag, double belsőSugar) : base(sugar, magassag)
        {
            this.falVastagsag = falVastagsag;
        }

        public double Terfogat()
        {
            double belsőSugar = sugar - falVastagsag;
            return Math.PI * Math.Pow(belsőSugar, 2) * magassag;
        }

        public string ToString()
        {
            return $"Cso: Sugar = {sugar}, Magasság = {magassag}, Falvastagság = {falVastagsag}, Térfogat = {Terfogat()}";
        }
        public double FalVastagsag { get => falVastagsag;}
    }
}
