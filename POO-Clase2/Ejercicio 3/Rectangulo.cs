using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_3
{
    public class Rectangulo : FiguraGeometrica
    {

        public double Altura { get; set; }
        public double Base { get; set; }

        public override double CalcularArea()
        {
            double area = Base * Altura;
            return area;
        }

        public override double CalcularPerimetro()
        {
            double perimetro = 2 * (Base + Altura);
            return perimetro;
        }
    }
}
