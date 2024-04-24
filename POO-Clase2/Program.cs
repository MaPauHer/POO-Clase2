using POO_Clase2.Ejercicio_1;
using POO_Clase2.Ejercicio_2;
using POO_Clase2.Ejercicio_3;
using System.Drawing;


namespace POO_Clase2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Ejercicio 1
            // Configurar el metodo Emitir sonido para que cada tipo de animal haga un sonido diferente
            // el metodo emitir sonido no devuelve nada (void), imprimir en consola el "sonido"

            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("\nEjercicio 1");
        
            Perro perro = new Perro() { Edad = 2, Nombre = "Buddy" };

            Gato gato = new Gato() { Edad = 5, Nombre = "Michi" };

            perro.EmitirSonido();

            gato.EmitirSonido();

            #endregion

            #region Ejercicio 2 
            // Agregar la propiedad "Peso" unicamente para las notebooks 
            // Agregar la propiedad "Refactorizada" que debe ser un booleano unicamente para las PcEscritorio
            // Instanciar una notebook y una pcEscritorio
            // Imprimir por pantalla las propiedades de cada uno

            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("\nEjercicio 2");

            Notebook miNotebook = new Notebook() { Marca = "Lenovo", Peso = 5 };
            PcEscritorio miPcEscritorio = new PcEscritorio() { Marca = "Dell", Refactorizada = true };

            Console.WriteLine("\n Propiedades de miNotebook. ");
            Console.WriteLine(" Marca: " + miNotebook.Marca);
            Console.WriteLine(" Peso: " + miNotebook.Peso);

            Console.WriteLine("\n Propiedades de miPcEscritorio. ");
            Console.WriteLine(" Marca: " + miPcEscritorio.Marca);
            Console.WriteLine(" Refactorizada: " + miPcEscritorio.Refactorizada);

            #endregion


            #region Ejercicio 3

            // Crear la clase "FiguraGeometrica" la cual debe ser abstracta y tener 2 metodos, uno para calcular el area y el otro el perimetro
            // Crear dos clases "Circulo" y "Rectangulo" que deben heredar de "FiguraGeometrica"
            // Implementar los metodos para que cada figura calcule el area y el perimetro como corresponda
            // Instanciar las clases e imprimir los valores del area y el perimetro para cada figura
            // Mostrar los resultados por consola

            Console.WriteLine("\n--------------------------------");
            Console.WriteLine("\nEjercicio 3");

            Circulo circulo1 = new Circulo() { Radio = 4.00 };

            Console.WriteLine("\n Circulo");
            Console.WriteLine(" Perimetro: " + circulo1.CalcularPerimetro());
            Console.WriteLine(" Area: " + circulo1.CalcularArea());


            Rectangulo rectangulo1 = new Rectangulo() { Base = 5.30, Altura = 2.50 };
            Console.WriteLine("\n Rectangulo");
            Console.WriteLine(" Perimetro: " + rectangulo1.CalcularPerimetro());
            Console.WriteLine(" Area: " + rectangulo1.CalcularArea());

            #endregion

            Console.ReadKey();
        }
    }
}