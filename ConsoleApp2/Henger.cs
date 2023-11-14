using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Henger
    {
            public double sugar;
            public double magassag;
            public static double SzuletesSzamlalo;


        public Henger(double sugar, double magassag)
            {
                this.sugar = sugar;
                this.magassag = magassag;
                SzuletesSzamlalo += 1;
            }

            public double Terfogat()
            {
                return Math.PI * Math.Pow(sugar, 2) * magassag;
            }

            public  string ToString()
            {
                return $"Henger: Sugar = {sugar}, Magasság = {magassag}, Térfogat = {Terfogat()}";
            }
        public double Sugar { get => sugar;}
        public double Magassag { get => magassag;}
        public static double Szuletesszamlalo { get => SzuletesSzamlalo;}
     }
}
