using System.Text;
using System.Xml.Linq;

namespace RecuParcialPOO.TomasBlencio.Entidades
{
    public class PrismaRectangularRecto
    {
        private int largo;
        private int ancho;
        private int altura;

        public PrismaRectangularRecto(int largo, int ancho, int altura)
        {
            if (largo<0 || ancho<0 || altura<0)
            {
                throw new ArgumentException("Datos ingresados invalidos");
            }
            this.largo = largo;
            this.ancho = ancho;
            this.altura = altura;
        }
        public PrismaRectangularRecto()
        {
            largo = 1;
            ancho = 1;
            altura = 1;
        }

        public int GetLargo()
        {
            return largo;
        }
        public int GetAncho()
        {
            return ancho;
        }
        public int GetAltura()
        {
            return altura;
        }
        public int GetAreaBase()
        {
            return largo * ancho;
        }
        public int GetAreaAltura()
        {
            return altura * ancho;
        }
        public int GetAreaAncho()
        {
            return altura * largo;
        }
        public int GetArea()
        {
            return 2*(GetAreaBase()+GetAreaAltura()+GetAreaAncho());
            //Área = 2 * (Ab + Ah + Aa) donde Ab es el área base, Ah es el área de la
            //altura y Aa es el área del ancho.
        }
        public int GetVolumen()
        {
            return largo * ancho * altura;
            //Volumen = A * B * h, donde A es el largo, B es el ancho y h la altura.

        }
        public double GetDiagonal()
        {
            return Math.Sqrt(Math.Pow(largo,2)+Math.Pow(ancho,2)+Math.Pow(altura,2));
            
        }
        public string MostrarDatos(PrismaRectangularRecto prr)
        {
            var sb = new StringBuilder();
            sb.AppendLine("Largo: "+prr.largo.ToString());
            sb.AppendLine("Ancho: "+prr.ancho.ToString());
            sb.AppendLine("Altura: "+prr.altura.ToString());
            sb.AppendLine("Area Base: "+prr.GetAreaBase().ToString());
            sb.AppendLine("Area Ancho: "+prr.GetAreaAncho().ToString());
            sb.AppendLine("Area Altura: "+prr.GetAreaAltura().ToString());
            sb.AppendLine("Area: "+prr.GetArea().ToString());
            sb.AppendLine("Volumen: "+prr.GetVolumen().ToString());
            sb.AppendLine("Diagonal: "+prr.GetDiagonal().ToString());
            return sb.ToString();
        }
    }
}