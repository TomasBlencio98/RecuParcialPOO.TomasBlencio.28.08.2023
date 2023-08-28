using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecuParcialPOO.TomasBlencio.Entidades
{
    public static class Horoscopo
    {
        public static string SignoZodiacal(DateTime f)
        {
            string signo = "";
            if (f.Day>=22 && f.Month>=12 || f.Day<=20 && f.Month<=1)
            {
                signo = "Capricornio";
            }
            else if (f.Day >= 21 && f.Month >= 1 || f.Day <= 19 && f.Month <= 2)
            {
                signo = "Acuario";
            }
            else if (f.Day >= 20 && f.Month >= 2 || f.Day <= 20 && f.Month <= 3)
            {
                signo = "Piscis";
            }
            else if (f.Day >= 21 && f.Month >= 3 || f.Day <= 20 && f.Month <= 4)
            {
                signo = "Aries";
            }
            else if (f.Day >= 21 && f.Month >= 4 || f.Day <= 21 && f.Month <= 5)
            {
                signo = "Tauro";
            }
            else if (f.Day >= 22 && f.Month >= 5 || f.Day <= 21 && f.Month <= 6)
            {
                signo = "Geminis";
            }
            else if (f.Day >= 22 && f.Month >= 6 || f.Day <= 22 && f.Month <= 7)
            {
                signo = "Cancer";
            }
            else if (f.Day >= 23 && f.Month >= 7 || f.Day <= 22 && f.Month <= 8)
            {
                signo = "Leo";
            }
            else if (f.Day >= 23 && f.Month >= 8 || f.Day <= 22 && f.Month <= 9)
            {
                signo = "Viego";
            }
            else if (f.Day >= 23 && f.Month >= 9 || f.Day <= 22 && f.Month <= 10)
            {
                signo = "Libra";
            }
            else if (f.Day >= 23 && f.Month >= 10 || f.Day <= 22 && f.Month <= 11)
            {
                signo = "Escorpio";
            }
            else
            {
                signo = "Sagitario";
            }
            return signo;
        }
        public static string SignoChino(int anio)
        {
            string signo = "";
            switch (anio%12)
            {
                    case 0:signo = "Mono"; break;
                    case 1: signo = "Gallo"; break;
                    case 2: signo = "Perro"; break;
                    case 3: signo = "Cerdo"; break;
                    case 4: signo = "Rata"; break;
                    case 5: signo = "Buey"; break;
                    case 6: signo = "Tigre"; break;
                    case 7: signo = "Conejo"; break;
                    case 8: signo = "Dragon"; break;
                    case 9: signo = "Serpiente"; break;
                    case 10: signo = "Caballo"; break;
                default:
                    signo = "Cabra";
                    break;
            }
            return signo;
        }
    }
}
