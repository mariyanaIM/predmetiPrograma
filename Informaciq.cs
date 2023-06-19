using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predmeti
{
    public class Informaciq:IPrint
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("error");
                }
                this.name = value;
            }
        }
        private string izvanklasnaForma;
        public string IzvanklasnaForma
        {
            get { return izvanklasnaForma; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("error");
                }
                this.izvanklasnaForma = value;
            }
        }
        public Informaciq(string name, string izvanklasnaForma)
        {
            this.Name = name;
            this.IzvanklasnaForma = izvanklasnaForma;
        }
        public virtual void Print()
        {
            Console.WriteLine($"{this.name} {this.izvanklasnaForma}");
        }
    }
}
