using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_3
{
    public class Circulo : FiguraGeometrica
    {

        public double Radio { get; set; }
        const double PI = 3.14159;

        public override double CalcularArea()
        {
            double area = PI * Radio * Radio;
            return area;
        }

        public override double CalcularPerimetro()
        {
            double perimetro = 2 * PI * Radio;
            return perimetro;
        }
    }
}
