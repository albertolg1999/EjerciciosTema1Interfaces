using System;

namespace EjerciciosTema1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            bool salirMenu=false;
            
           

            while (!salirMenu)
            {

                Console.WriteLine("******Menu******");
                Console.WriteLine("******1. Resta de 2 numeros enteros******");
                Console.WriteLine("******2. Cantidad Cifras de un numero******");
                Console.WriteLine("******3. Suma Intervalo******");
                Console.WriteLine("******4. Fibonacci Recursivo******");
                Console.WriteLine("******5. Salir******");


                do
                {
                    Console.WriteLine("Introduzca una opcion del menu: ");
                    opcion = solicitarEntero();
                } while (opcion <= 0);

                switch (opcion)
                {
                    case 1:
                        int a = 0, b = 0;
                        do
                        {
                            Console.WriteLine("Introduzca el valor del primer numero");
                            a = solicitarEntero();
                            Console.WriteLine("Introduzca el valor del segundo numero");
                            b = solicitarEntero();

                            if (a < b)
                            {
                                Console.WriteLine("El primer numero introducido debe ser mayor que el segundo");
                            }
                        } while (a < b);

                        int resta = a - b;
                        Console.WriteLine("El resultado de la resta es: " + resta);
                        break;

                    case 2:
                        int num = 0;
                        int num_caract = 0;
                        bool valido = false;
                        String cadena;
                        Console.WriteLine("Introduzca el numero del que quiere contar sus cifras");

                        do
                        {
                            num = solicitarEntero();
                            cadena = num.ToString();
                            num_caract = cadena.Length;

                            if(num_caract < 0 || num_caract > 5)
                            {
                                Console.WriteLine("El numero debe tener como maximo 5 digitos");
                            }
                        } while (num < 0||num_caract<0||num_caract>5);

                        Console.WriteLine("La cantidad de cifras del numero " + num + " es de " + num_caract + " cifras");
                        

                        break;

                    case 3:
                        int resultado = 0;
                        int num1 = 0, num2 = 0;
                        

                        do
                        {
                            Console.WriteLine("Introduzca el primer numero");
                            num1 = solicitarEntero();

                            if (num1 < 0)
                            {
                                Console.WriteLine("El numero debe ser positivo");
                            }
                        } while (num1 < 0 );

                        do
                        {
                            Console.WriteLine("Introduzca el segundo numero");
                            num2 = solicitarEntero();

                            if (num2 < 0)
                            {
                                Console.WriteLine("El numero debe ser positivo");
                            }
                            else if (num2 < num1)
                            {
                                Console.WriteLine("El segundo numero debe ser mayor que el primero");
                            }
                        } while (num2 < 0||num2<num1);

                        resultado = sumaIntervalo(num1, num2);
                        Console.WriteLine("El resultado de la suma es: " + resultado);
                        break;

                    case 4:
                        int numer = 0;
                        do
                        {
                            Console.WriteLine("Introduzca un numero para realizar la serie de Fibonacci");
                            numer = solicitarEntero();

                            if (numer < 0)
                            {
                                Console.WriteLine("El numero debe ser positivo");
                            }
                        } while (numer < 0);

                        Console.WriteLine("La serie de fibonacci hasta el numero " + numer + " es:");

                        for (int i = 0; i < numer; i++)
                        {
                            Console.WriteLine(SerieFibonacci(i));
                        }
                        break;
                    case 5:
                        Console.WriteLine("Hasta pronto!!!!");
                        salirMenu = true;
                        break;
                    default:
                        Console.WriteLine("Introduzca una opcion correcta");
                        break;
                }

                Console.WriteLine("");
            }
            
        }


        static int sumaIntervalo(int num1, int num2)
        {
            int contador = num1;
            int final = num2;
            int resultado = 0;

            while (contador <= final)
            {
                resultado += contador;
                contador += 1;
            }

            return resultado;
        }
        static int SerieFibonacci(int num)
        {
            if (num == 0 || num == 1)
            {
                return num;
            }
            else
            {
                return SerieFibonacci(num - 1) + SerieFibonacci(num - 2);
            }
        }
        static int solicitarEntero()
        {
            bool valido;
            int num;
            
            do
            {
                valido = int.TryParse(Console.ReadLine(), out num);
                if (!valido)
                    Console.WriteLine("Debe ser un numero entero y positivo");
                
            } while (!valido);
            return num;
            
        }
    }
}
