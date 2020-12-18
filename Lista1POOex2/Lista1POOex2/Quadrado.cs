using System;
using System.Collections.Generic;
using System.Text;

namespace Lista1POOex2
{
    class Quadrado
    {
        
        private int area;
        private int aresta;

        public Quadrado()
        {
            this.area = 0;
        }

        public Quadrado(int valor)
        {
            this.area = valor;
        }
        public void setAresta(int p)
        {
            aresta = p;
        } 

        public int getAresta()
        {
            return aresta;
        }

        public int getArea()
        {
            return area;
        }

        public void calcularArea()
        {
            area = aresta * aresta;
        }
    }
}
