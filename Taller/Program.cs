using System;

namespace Taller
{
    class TALLER_MECANICO
    {
        string PLACAS, PROPIETARIO, CONTESTACION;
        int ESPACIOS, SIN_ESPACIOS;
        double TARIFA, GANANCIA;
        string[] PLACAAUTOMIVIL;
        string[] DUEÑO;
        double[] COSTO;
        public double Tarifas
        {
            get { return TARIFA; }
            set { TARIFA = value; }
        }
        public double Ganancia
        {
            get { return GANANCIA; }
            set { GANANCIA = value; }
        }
        public string Propietario
        {
            get { return PROPIETARIO; }
            set { PROPIETARIO = value; }
        }
        public string Placas
        {
            get { return PLACAS; }
            set { PLACAS = value; }
        }
        public string Contestacion
        {
            get { return CONTESTACION; }
            set { CONTESTACION = value; }
        }
        public int Espacios
        {
            get { return ESPACIOS; }
            set { ESPACIOS = value; }
        }
        public int Sin_espacios
        {
            get { return SIN_ESPACIOS; }
            set { SIN_ESPACIOS = value; }
        }
        public void EN_LAPUERTA()
        {
            Console.WriteLine("*****************TALLER MECANICO*************");
            for (int i = 0; i < 5; i++)
            {
                GANANCIA = -1;
                Console.WriteLine("*********************************************");
                Console.Write("PLACAS: ");
                Placas = Console.ReadLine().ToString();
                Console.Write("PROPIETARIO: ");
                Propietario = Console.ReadLine().ToString();
                Console.Write("COSTO POR REPARACION: " + "$");
                Tarifas = double.Parse(Console.ReadLine());
                Ganancia = Ganancia + Tarifas;
                Espacios += 1;
                Sin_espacios += 1;
            }
        }
        public void POR_SALIR()
        {
            Console.WriteLine("SOLAMENTE HAY: " + Espacios);
            Console.WriteLine("NO HAY MUCHO ESPACIO");
            
            do
            {
                Console.Write("¿SALDRA UN AUTOMIVIL? ");
                Contestacion = Console.ReadLine().ToLower();
                if (Contestacion == "si" || Contestacion == "SI")
                {
                    
                    Sin_espacios -= 1;
                    Ganancia += Tarifas;
                    Console.Write("¿INGRESARA UN NUEVO AUTO? ");
                    Contestacion = Console.ReadLine().ToLower();
                    if (Contestacion == "si")
                    {
                        Console.WriteLine("**************************************************");
                        Console.Write("PLACAS: ");
                        Placas = Console.ReadLine().ToString();
                        Console.Write("PROPIETARIO: ");
                        Propietario = Console.ReadLine().ToString();
                        Console.Write("COSTO DE REPARACION: " + "$");
                        Tarifas = double.Parse(Console.ReadLine());
                        Espacios = Espacios + 1;
                        Sin_espacios = Sin_espacios + 1;
                        Console.WriteLine("********" + Espacios);
                        Console.WriteLine("**********" + Sin_espacios);
                    }
                    else
                    {
                        Console.WriteLine("ESPERA UN MOMENTO");
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Siga esperando...");
                    Console.ReadLine();
                }

            } while (Sin_espacios > 0);
        }
        public void ENTRAR_UNO_NUEVO()
        {
            Console.WriteLine("AUTOS QUE FUERON ARREGLADOS: " + Espacios);
            PLACAAUTOMIVIL= new string[Espacios];
            DUEÑO = new string[Espacios];
            COSTO = new double[Espacios];
            for (int i = 0; i < Espacios; i++)
            {
                PLACAAUTOMIVIL[i] = Placas;
                DUEÑO[i] = Propietario;
                COSTO [i] = Tarifas;
            }
            Console.WriteLine("GANANCIAS DEL DIA DE HOY: " + "$" + Ganancia);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TALLER_MECANICO taller = new TALLER_MECANICO();

            taller.EN_LAPUERTA();
            taller.POR_SALIR();
            taller.ENTRAR_UNO_NUEVO();
        }

    }
}