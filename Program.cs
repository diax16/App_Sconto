
using System.Text;
using System.Threading.Tasks;


namespace App_Sconto
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            int vacio;
            int contador = 0;
            int contadorM = 0;
            int contadorH = 0;
            int edad = 50;
            double compra;
            string sexo;
            do
            {
                Console.WriteLine("ingrese la compra");
                compra = double.Parse(Console.ReadLine());
                contador ++;

                if (compra >= 500)
                {
                    Console.WriteLine("Descuento del 30%");
                }
                if (compra >= 300 && compra > 500)
                {
                    Console.WriteLine("Descuento del 20%");
                }
                if (compra < 300)
                {
                    Console.WriteLine("Descuento del 10%");
                }

                Console.WriteLine("ingrese el sexo m - mujer h - hombre");
                sexo = Console.ReadLine();
                if (sexo == "m")
                {
                    Console.WriteLine("QUE EDAD TIENE?");
                    edad = int.Parse(Console.ReadLine());


                    if (edad >= 50)
                    {
                        Console.WriteLine("SE APLICA DESCUENTO EXTRA 10 %");
                        contadorM++;
                    }
                    else
                    {
                        Console.WriteLine("NO CUMPLE CON LA EDAD, NO HAY DESCUENTO EXTRA");
                    }
                }
                
                if (sexo == "h")
                {
                    Console.WriteLine("QUE EDAD TIENE?");
                    edad = int.Parse(Console.ReadLine());
                    if (edad >= 60)
                    {
                        Console.WriteLine("SE APLICA DESCUENTO EXTRA 10 %");
                    }
                    else
                    {
                        Console.WriteLine("NO CUMPLE CON LA EDOD, NO HAY DESCUENTO EXTRA");
                    }
                }

                Console.WriteLine("Esta vacio?  1-vacio 2-seguir");
                vacio = int.Parse(Console.ReadLine());

            }
            while (vacio == 2);

            Console.WriteLine("la cantidad de clientes atendidos " + contador);
            
            Console.WriteLine("la cantidad de mujeres aplica descuento " + contadorM);

            Console.WriteLine("la cantidad de hombres aplica descuento " + contadorH);


            Console.ReadKey();

        }
    }
}
