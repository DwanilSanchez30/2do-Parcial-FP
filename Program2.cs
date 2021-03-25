using System;

namespace _2do_parcial2
{
    class Program
    {
        private string[] Nombres;
        private float[] Salarios;

        public void Cargar() 
        {
            Nombres = new string[5];
            Salarios = new float[5];

            for(int f=0;f < Nombres.Length;f++) 
            {
                Console.Write("Nombre del empleado: ");
                Nombres[f] = Console.ReadLine();
                Console.Write("Su salario es: ");
                string ES;
                ES = Console.ReadLine();
                Salarios[f]=float.Parse(ES);
                Console.WriteLine();
            }
        }

        public void SalarioMayor() 
        {
            float Mayor;
            int pos;
            Mayor = Salarios[0];
            pos = 0;
            for(int f=1;f < Nombres.Length; f++) 
            {
                if (Salarios[f] > Mayor) 
                {
                    Mayor = Salarios[f];
                    pos = f;
                }
            }
            Console.WriteLine("El empleado con el salario mayor es {0}",Nombres[pos]);
            Console.WriteLine("Tiene un salario de: {0}",Mayor);
            Console.WriteLine();
            Console.WriteLine("Presione una tecla para reiniciar el programa");
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            Program Empleado = new Program();
            Empleado.Cargar();
            Empleado.SalarioMayor();
        }
    }
}