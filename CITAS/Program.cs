using System;

namespace CITAS
{
    class Program
    {
        class EMPRESAS
        {

            double opciones;
            char tclas;
            String empresa1, empresa2, empresa3, D1, D2, D3, H1, H2, H3;
            string respuesta;
            public double OPCIONES
            {
                get { return opciones; }
                set { opciones = value; }
            }
            public char tecla
            {
                get { return tclas; }
                set { tclas = value; }
            }
            public string Nom_empresa1
            {
                get { return empresa1; }
                set { empresa1 = value; }
            }
            public string Nom_empresa2
            {
                get { return empresa2; }
                set { empresa2 = value; }
            }
            public string Nom_empresa3
            {
                get { return empresa3; }
                set { empresa3 = value; }
            }
            public string d1
            {
                get { return D1; }
                set { D1 = value; }
            }
            public string d2
            {
                get { return D2; }
                set { D2 = value; }
            }
            public string d3
            {
                get { return D3; }
                set { D3 = value; }
            }
            public string hora1
            {
                get { return H1; }
                set { H1 = value; }
            }
            public string hora2
            {
                get { return H2; }
                set { H2 = value; }
            }
            public string hora3
            {
                get { return H3; }
                set { H3 = value; }
            }
            public void SALAS_REUNIONES()
            {

                do
                {
                    Console.Clear();
                    Console.SetCursorPosition(30, 0);
                    Console.SetCursorPosition(13, 1);
                    Console.WriteLine("**AGENDA EMPRESARIAL**");
                    do
                    {
                        //POSICION QUE SE ENCUENTRA CADA OPCION EN LA CONSOLA
                        //TIENE COMOLOR PARA IDENTIFICAR CUAL SELECCIONAR
                        Console.SetCursorPosition(1, 2);
                        if (OPCIONES == 1)
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("SALA 1");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(30, 2);
                        if (OPCIONES == 2)
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("SALA 2");

                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(60, 2);
                        if (OPCIONES == 3)
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine("SALA 3");

                        Console.ForegroundColor = ConsoleColor.White;
                        tecla = (char)Console.ReadKey().Key;
                        switch (tecla)
                        {//PARA SABER CUANTAS OPCIONES PUEDES RECORER
                            case (char)ConsoleKey.LeftArrow:
                                if (OPCIONES == 1) OPCIONES = 3; else OPCIONES--;
                                break;
                            case (char)ConsoleKey.RightArrow:
                                if (OPCIONES == 3) OPCIONES = 1; else OPCIONES++;
                                break;
                        }
                    } while (tecla != (char)ConsoleKey.Escape && tecla != (char)ConsoleKey.Enter);
                    if (tecla == (char)ConsoleKey.Escape)
                        OPCIONES = 0;
                    Console.WriteLine("" + OPCIONES);

                    if (OPCIONES == 1)
                    {//INGRESAS INFORMACION DE QUE SE TE PIDE, DESPUES TE ARROJA LA HORA Y EN QUE SALA SERIA Y ASI ES EN LAS 3 SALAS
                        //DE CUALQUIER QUE ESCOJAR
                        Console.WriteLine("**SALA DE REUNION No.1 **");
                        Console.WriteLine("Nombre de la empresa: ");
                        Nom_empresa1 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("¿Que dia quiere su cita?: ");
                        hora1 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Ingrese hora: ");
                        d1 = Convert.ToString(Console.ReadLine());
                        if (d1 == "Domingo")
                        {
                            Console.WriteLine("NO HAY SERVICIO");
                        }
                        Console.WriteLine("PARA RECIBIR EL PAPEL INGRESE  -COMPROBANTE-");
                        respuesta = Convert.ToString(Console.ReadLine());
                        if (respuesta == "COMPROBANTE")
                        {
                            Console.WriteLine("++++++++++++++COMPROBANTE++++++++++++++");
                            Console.WriteLine("        SALA DE REUNION  No.1 AGENDADA");
                            Console.WriteLine("           EMPRESA :" + Nom_empresa1);
                            Console.WriteLine("           DIA DE CITA:" + d1);
                            Console.WriteLine("           HORA DE LLEGADA :" + hora1);
                            Console.WriteLine(" ++++++++++++++++++++++++++++++++++++");
                        }
                        Console.WriteLine("QUIERE CONTINUAR AGENDANDO?");
                        respuesta = Convert.ToString(Console.ReadLine());

                    }
                    else if  (OPCIONES == 2)
                    {
                        Console.WriteLine("**SALA DE REUNION No.2 **");
                        Console.WriteLine("Nombre de la empresa: ");
                        Nom_empresa2 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("¿Que dia quiere su cita?: ");
                        hora2 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Ingrese hora: ");
                        d2 = Convert.ToString(Console.ReadLine());
                        if (d2 == "Domingo")
                        {
                            Console.WriteLine("NO HAY SERVICIO");
                        }
                        Console.WriteLine("PARA RECIBIR EL PAPEL INGRESE  -COMPROBANTE-");
                        respuesta = Convert.ToString(Console.ReadLine());
                        if (respuesta == "COMPROBANTE")
                        {
                            Console.WriteLine(" ++++++++++++COMPROBANTE++++++++++++++++++++");
                            Console.WriteLine("    SALA DE REUNION No.2 AGENDADA   ");
                            Console.WriteLine("        EMPRESA :" + Nom_empresa2);
                            Console.WriteLine("        DIA DE CITA:" + d2);
                            Console.WriteLine("        HORA DE LLEGADA :" + hora2);
                            Console.WriteLine(" ++++++++++++++++++++++++++++++++++++++");
                        }
                        Console.WriteLine("QUIERE CONTINUAR AGENDANDO?");
                        respuesta = Convert.ToString(Console.ReadLine());

                    }
                    if (OPCIONES == 3)
                    {
                        Console.WriteLine("**SALA DE REUCION No.3 **");
                        Console.WriteLine("Nombre de la empresa: ");
                        Nom_empresa3 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("¿Que dia quiere su cita?: ");
                        hora3 = Convert.ToString(Console.ReadLine());
                        Console.WriteLine("Ingrese hora: ");
                        d3 = Convert.ToString(Console.ReadLine());
                        if (d3 == "Domingo")
                        {
                            Console.WriteLine("NO HAY SERVICIO");
                        }
                        Console.WriteLine("PARA RECIBIR EL PAPEL INGRESE  -COMPROBANTE-");
                        respuesta = Convert.ToString(Console.ReadLine());
                        if (respuesta == "COMPROBANTE")
                        {
                            Console.WriteLine(" +++++++++++++++++COMPROBANTE++++++++++++++++++");
                            Console.WriteLine("     SALA DE REUNION No.3 AGENDADA  ");
                            Console.WriteLine("        EMPRESA :" + Nom_empresa3);
                            Console.WriteLine("        DIA DE CITA:" + d3);
                            Console.WriteLine("        HORA DE LLEGADA :" + hora3);
                            Console.WriteLine(" ++++++++++++++++++++++++++++++++++++++++++");
                        }
                        Console.WriteLine("QUIERE CONTINUAR AGENDANDO?");
                        respuesta = Convert.ToString(Console.ReadLine());

                    }
                } while (respuesta == "si" || respuesta== "SI" );

            }
        }
        static void Main(string[] args)
        {
            EMPRESAS objcasos = new EMPRESAS();
            objcasos.SALAS_REUNIONES();
        }
       
    }
}
