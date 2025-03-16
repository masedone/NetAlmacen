using System;

namespace Almacen
{
    /*
        Un almacen de escritorios hace los siguientes descuentos: 
        - si el cliente compra menos de 5 se le da un descuento del 10%
        - mayor o igual a 5 pero menos de 10 un 20%
        - 10 o mas un 40%
        
        Hacer programa que determine cuanto pagara el cliente si cada escritorio es de 650$
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int numeroEscritorios;
            decimal valorApagar;

            //Usamos out para alterar la variable al volver de la función
            pedirDatos(out numeroEscritorios);
            valorApagar = CalcularValor(numeroEscritorios);
            MostrarResultados(valorApagar);
            
        }

        static void pedirDatos(out int numeroEscritorios) 
        {
            Console.WriteLine("Ingrese número de escritorios que desea");
            //numeroEscritorios va y vuelve cambiado
            numeroEscritorios = Convert.ToInt32(Console.ReadLine());
        }

        static decimal CalcularValor(int numeroEscritorios)
        {
            decimal valor = numeroEscritorios * 650;
            if(numeroEscritorios < 5)
            {
                return valor * 0.9M; //hacemos el 90% ahorrando el 10%
            }
            if(numeroEscritorios >= 5 && numeroEscritorios < 10)
            {
                return valor * 0.8M;
            }
            //Para mayor o igual a 10
            return valor * 0.6M;
        }
        static void MostrarResultados(decimal valorApagar)
        {
            //Eso es un formato numerico con 0 decimal
            Console.WriteLine("El valor a pagar es {0:N0}€", valorApagar);
            Console.ReadKey();
        }
    }
}
