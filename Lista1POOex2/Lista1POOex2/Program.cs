using System;

namespace Lista1POOex2
{
    class Program
    {
            static void Main(string[] args)
            {
                Quadrado quad;

                quad = new Quadrado(23);

                Console.Write("Informe a aresta do quadrado: ");
                quad.setAresta(int.Parse(Console.ReadLine()));
                
                quad.calcularArea();

                Console.WriteLine("A area do quadrado é:{0} ",quad.getArea());
            }

    }
}
