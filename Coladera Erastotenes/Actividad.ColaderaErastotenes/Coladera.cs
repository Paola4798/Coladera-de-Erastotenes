using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.ColaderaErastotenes
{
    class Coladera
    {
        private int[] elementos = new int[1000];

        public string eratostenes()
        {
            string cadena = "";

            for (int i = 1; i < 1000; i++) elementos[i] = 1;
            // inicializamos los elementos del vector en 1
            
            for (int i = 2; i < 1000; i++)
            {
                int div = 1;                   
                // variable utlizada para determinar si el numero i, solo tiene dos divisores
                for (int y = 2; y <= i; y++)   
                // ciclo para recorrer los numeros del 2 hasta i
                {
                    if ((i % y) == 0) div++;    
                    // validamos si i modulo y es 0, es decir que es divisible, un numero primo
                }                               
                // solo es divisble por dos numeros, asi que div debe ser 2, para que i sea primo
                if (div == 2) for (int z = i + i; z < 1000; z += i) elementos[z] = 0;   
                // si div es 2, el numero es primo y se aplica
            }                                                                          
            // el metodo erastotenes, y se pone un 0 a los multiplos de i


            for (int i = 2; i < 1000; i++)
            {
                if (elementos[i] == 1) cadena += i + " , ";
            }

            return cadena;
        }
    }
}
