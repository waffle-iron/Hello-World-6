using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaInvertida
{
    class Clase1
    {
        List<int> l1 = new List<int>();
        public int agregar(int numero)
        {

            l1.Add(numero);

            return numero;
        }
        public void imprimir()
        {
            Console.WriteLine("--------Lista original--------");
            for (int i = 0; i < l1.Count; i++)
            {
                    Console.WriteLine(l1[i]);
              
            }
            Console.WriteLine("------------------------------");
        }
        public void imprimirInverso()
        {
            Console.WriteLine("------- Lista invertida------");
            for (int i = l1.Count-1; i >=0; i--)
            {
                
                Console.WriteLine(l1[i]);
                
            }
            Console.WriteLine("-----------------------------");
        }
    }
}
