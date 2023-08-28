using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuParcialPOO.TomasBlencio.Entidades
{
    public class Libra
    {
        private double peso;
        public double GetPeso()
        {
            return peso;
        }
        public Libra()
        {
            peso = 10;
        }
        public Libra(double peso)
        {
            this.peso = peso;
        }

        public static implicit operator double(Libra v)
        {
            return v.GetPeso();
        }
        public static explicit operator Libra(Kilo kilo)
        {
            return new Libra(kilo.GetPeso() * 2.2046226219);
        }
        public static bool operator ==(Libra l1, Libra l2)
        {
            return l1.GetPeso() == l2.GetPeso();
        }

        public static bool operator !=(Libra l1, Libra l2)
        {
            return !(l1 == l2);
        }
        public double GetEquivalenteKilo()
        {
            return peso * 2.2046226219;
        }
        public static Libra operator +(Libra l1, Libra l2)
        {
            return new Libra(l1.GetPeso() + l2.GetPeso());
        }
        public static Libra operator -(Libra l1, Libra l2)
        {
            return new Libra(l1.GetPeso() - l2.GetPeso());
        }

    }
}
