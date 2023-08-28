using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuParcialPOO.TomasBlencio.Entidades
{
    public class Kilo
    {
        private double peso;
        public double GetPeso()
        {
            return peso;
        }
        public Kilo()
        {
            peso = 10;
        }
        public Kilo(double peso)
        {
            this.peso = peso;
        }
        public static implicit operator double(Kilo kilo)
        {
            return kilo.GetPeso();
        }

        public static explicit operator Kilo(Libra libra)
        {
            return new Kilo(libra.GetPeso()* 0.45359237);
        }
        public static bool operator ==(Kilo k1, Kilo k2)
        {
            return k1.GetPeso() == k2.GetPeso();
        }

        public static bool operator !=(Kilo k1, Kilo k2)
        {
            return !(k1 == k2);
        }
        public double GetEquivalenteLibra()
        {
            return peso* 0.45359237;
        }
        public static Kilo operator +(Kilo k1, Kilo k2)
        {
            return new Kilo(k1.GetPeso()+k2.GetPeso());
        }
        public static Kilo operator -(Kilo k1, Kilo k2)
        {
            return new Kilo(k1.GetPeso() - k2.GetPeso());
        }

        public static bool operator ==(Kilo kilo, Libra libra)
        {
            return kilo == libra.GetEquivalenteKilo();
        }
        public static bool operator !=(Kilo kilo, Libra libra)
        {
            return !(kilo==libra.GetEquivalenteKilo());
        }
    }
}
