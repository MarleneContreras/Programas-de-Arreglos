using System;


namespace Taller_mecanica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*****TALLER MECANICO********");
            Console.ForegroundColor = ConsoleColor.White;
            //Capacidad maxima de 7 autos
            TALLER_ME taller = new TALLER_ME(7);
            Console.WriteLine(taller.Espacios());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("ESPACIOS DISPONIBLES");
            Console.WriteLine("Al ingresar 'A' el programa se cerrara");
            char ans; char salir = 'f';
            while (salir != 'A')
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("¿QUE MOVIMIENTO QUIERE HACER?");
                Console.WriteLine("A)ENTRAR\nB)RECOGER\n"); Console.WriteLine("Selecciona su opcion: ");
                ans = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                Console.ForegroundColor = ConsoleColor.White;
                Console.Clear(); switch (ans)
                {
                    case 'A':
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Ha seleccionado entrar");
                            Console.Write("Introduzca su numero de placas: "); Console.ForegroundColor = ConsoleColor.White; string No_Placas = Convert.ToString(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write("Introduzca el nombre del propietario: "); Console.ForegroundColor = ConsoleColor.White; string nombre = Convert.ToString(Console.ReadLine());
                            if (taller.Entrar( No_Placas , nombre) == false)
                            {
                                Console.WriteLine("Una disculpa, por el momento se encuentra lleno");
                                Console.ReadKey();
                            }
                            Console.ForegroundColor = ConsoleColor.DarkMagenta;
                            Console.Clear();
                            Console.WriteLine("Se han actulizado los registros");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine(taller.Espacios());
                            Console.ReadKey(); break;
                        }
                    case 'B':
                        {
                            Console.ForegroundColor = ConsoleColor.DarkMagenta; Console.WriteLine("Ha seleccionado recoger"); if (taller.Recoger() == false)
                            {
                                Console.WriteLine("Se encuentra vacio");
                                Console.ReadKey();
                            }
                            Console.WriteLine("Se han actualizado los registros"); Console.ForegroundColor = ConsoleColor.White; Console.WriteLine(taller.Espacios());
                            Console.ReadKey(); break;
                        }
                }
                Console.Clear();
                Console.WriteLine("Si ya finalizo para salir precione A o para continuar seleccione cualquier otra tecla");
                salir = char.ToUpper(Convert.ToChar(Console.ReadLine()));
                Console.Clear();
            }
        }
    }
}

