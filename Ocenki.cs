using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predmeti
{
     public class Ocenki:Informaciq, IComparable<Ocenki>
    {
        private string paralelka;
        public string Paralelka
        {
            get { return paralelka; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("error");
                }
                this.paralelka = value;
            }
        }
        private double uspeh;
        public double Uspeh
        {
            get { return uspeh; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("error");
                }
                this.uspeh = value;
            }
        }
        private int klas;
        public int Klas
        {
            get { return klas; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException("error");
                }
                this.klas = value;
            }
        }
        public Ocenki(string name, string izvanklasnaForma, string paralelka, int klas, double uspeh):base(name, izvanklasnaForma)
        {
            this.Klas = klas;
            this.Paralelka = paralelka;
            this.Uspeh = uspeh;
        }

        public int CompareTo(Ocenki other)
        {
            int result = this.Uspeh.CompareTo(other.Uspeh);
            if (result == 0)
                result = this.Klas.CompareTo(other.Klas);
            return result;
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"{this. klas} {this.paralelka} {this.uspeh}");
        }
    }
}
