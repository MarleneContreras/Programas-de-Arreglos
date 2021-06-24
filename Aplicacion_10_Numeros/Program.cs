using System;

namespace Aplicacion_10_Numeros
{
    class Program
    {
        class NUMEROS10
        {
            public int Num1_1, Num2_2, Num3_3, Num4_4, Num5_5, Num6_6, Num7_7, Num8_8, Num9_9, Num10_10,  SUMAS, Promedios;
            public int Num1
            {
                get { return Num1_1; }
                set { Num1_1 = value; }
            }
            public int Num2
            {
                get { return Num2_2; }
                set { Num2_2 = value; }
            }
            public int Num3
            {
                get { return Num3_3; }
                set { Num3_3 = value; }
            }
            public int Num4
            {
                get { return Num4_4; }
                set { Num4_4 = value; }
            }
            public int Num5
            {
                get { return Num5_5; }
                set { Num5_5 = value; }
            }
            public int Num6
            {
                get { return Num6_6; }
                set { Num6_6= value; }
            }
            public int Num7
            {
                get { return Num7_7; }
                set { Num7_7 = value; }
            }
            public int Num8
            {
                get { return Num8_8; }
                set { Num8_8 = value; }
            }
            public int Num9
            {
                get { return Num9_9; }
                set { Num9_9 = value; }
            }
            public int Num10
            {
                get { return Num10_10; }
                set { Num10_10 = value; }
            }
            public int suma
            {
                get { return SUMAS; }
                set { SUMAS = value; }
            }
            public int promedio
            {
                get { return Promedios; }
                set { Promedios = value; }
            }
            public void SUMA()
            {
                //TE PIDE INGRESAR LOS 10 NUMEROS
                Console.WriteLine("Insertar el numero 1");
                Num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 2");
                Num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 3");
                Num3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 4");
                Num4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 5");
                Num5 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 6");
                Num6 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 7");
                Num7 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 8");
                Num8 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 9");
                Num9 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 10");
                Num10 = Convert.ToInt32(Console.ReadLine());
                //TOTAL DE LA SUMA
                Console.WriteLine("***************************************************");
                suma = Num1 + Num2 + Num3 + Num4 + Num5 + Num6 + Num7 + Num8 + Num9 + Num10;
                Console.WriteLine("A) Suma de los  digitos  " + suma);

            }
            //PROMEDIO DE LOS 10 NUMERO ENTRE 10
            public void PROMEDIO()
            {
                Console.WriteLine("***************************************************");
                promedio = suma / 10;
                Console.WriteLine("B) Promedio de los digitos " + promedio);
                Console.WriteLine("***************************************************");
            }
            //MUESTRA EL NUMERO MAYOR
            public void NumeroMasGrande()
            {
                if (Num1 > Num2 && Num1 > Num3 && Num1 > Num4 && Num1 > Num5 && Num1 > Num6 && Num1 > Num7 && Num1 > Num8 && Num1 > Num9 && Num1 > Num10)
                {
                    Console.WriteLine("C) El numero mayor de los digito es el " + Num1);
                }
                 if  (Num2 > Num1 && Num2 > Num3 && Num2 > Num4 && Num2 > Num5 && Num2 > Num6 && Num2 > Num7 && Num2 > Num8 && Num2 > Num9 && Num2 > Num10)
                 {
                    Console.WriteLine("C) El numero mayor de los digitos es el " + Num2);
                 }
                 if (Num3 > Num1 && Num3 > Num2 && Num3 > Num4 && Num3 > Num5 && Num3> Num6 && Num3 > Num7 && Num3 > Num8 && Num3 > Num9 && Num3 > Num10)
                 {
                    Console.WriteLine("C) El numero mayor de los digitos es el " + Num3);
                 }
                if (Num4> Num1 && Num4 > Num2 && Num4 > Num3 && Num4 > Num5 && Num4 > Num6 && Num4 > Num7 && Num4 > Num8 && Num4 > Num9 && Num4 > Num10)
                {
                    Console.WriteLine("C) El numero mayor de los digitos es el " + Num4);
                }
                if  (Num5 > Num1 && Num5 > Num2 && Num5 > Num3 && Num5 > Num4 && Num5 > Num6 && Num5 > Num7 && Num5 > Num8 && Num5 > Num9 && Num5 > Num10)
                {
                    Console.WriteLine("C) El numero mayor de los digitos es el " + Num5);
                }
                if (Num6 > Num1 && Num6 > Num2 && Num6 > Num3 && Num6 > Num4 && Num6 > Num5 && Num6 > Num7 && Num6 > Num8 && Num6 > Num9 && Num6 > Num10)
                {
                    Console.WriteLine("C) El numero mayor de los digitos es el " + Num6);
                }
                if (Num7 > Num1 && Num7 > Num2 && Num7 > Num3 && Num7 > Num4 && Num7 > Num5 && Num7 > Num6 && Num7 > Num8 && Num7 > Num9 && Num5+7 > Num10)
                {
                    Console.WriteLine("C) El numero mayor de los digitos es el " + Num7);
                }
                if (Num8 > Num1 && Num8 > Num2 && Num8 > Num3 && Num8 > Num4 && Num8 > Num5 && Num8 > Num6 && Num8 > Num7 && Num8 > Num9 && Num8 > Num10)
                {
                    Console.WriteLine("C) El numero mayor de los digitos es el " + Num8);
                }
                if (Num9 > Num1 && Num9 > Num2 && Num9 > Num3 && Num9 > Num4 && Num9 > Num5 && Num9 > Num6 && Num9 > Num7 && Num9 > Num8 && Num9 > Num10)
                {
                    Console.WriteLine("C) El numero mayor de los digitos es el " + Num9);
                }
                if (Num10 > Num1 && Num10 > Num2 && Num10 > Num3 && Num10 > Num4 && Num10 > Num5 && Num10 > Num6 && Num10 > Num7 && Num10 > Num8 && Num10 > Num9)
                {
                    Console.WriteLine("C) El numero mayor de los digitos es el " + Num10);
                }
                Console.WriteLine("***************************************************");
            }

            //MUESTRA EL NUMERO MENOR
            public void NumeroMENOR()
            {
                if (Num1 < Num2 && Num1 < Num3 && Num1 < Num4 && Num1 < Num5 && Num1 < Num6 && Num1 < Num7 && Num1 <Num8 && Num1 < Num9 && Num1 < Num10)
                {
                    Console.WriteLine("D) El numero menor de los digitos es el " + Num1);
                }
                if (Num2 < Num1 && Num2 < Num3 && Num2 < Num4 && Num2 < Num5 && Num2 < Num6 && Num2 < Num7 && Num2 < Num8 && Num2 < Num9 && Num2 < Num10)
                {
                    Console.WriteLine("D) El numero menor de los digitos es el " + Num2);
                }
                if (Num3 < Num1 && Num3 < Num2 && Num3 < Num4 && Num3 < Num5 && Num3 < Num6 && Num3 < Num7 && Num3 < Num8 && Num3 < Num9 && Num3 < Num10)
                {
                    Console.WriteLine("D) El numero menor de los digitos es el " + Num3);
                }
                if (Num4 < Num1 && Num4 < Num2 && Num4 < Num3 && Num4 < Num5 && Num4 < Num6 && Num4 < Num7 && Num4 < Num8 && Num4 < Num9 && Num4 < Num10)
                {
                    Console.WriteLine("D) El numero menor de los digitos es el " + Num4);
                }
                if (Num5 < Num1 && Num5 < Num2 && Num5 < Num3 && Num5 < Num4 && Num5 < Num6 && Num5 < Num7 && Num5 < Num8 && Num5 < Num9 && Num5 < Num10)
                {
                    Console.WriteLine("D) El numero menor de los digitos es el " + Num5);
                }
                if (Num6 < Num1 && Num6 < Num2 && Num6 < Num3 && Num6 < Num4 && Num6 < Num5 && Num6 < Num7 && Num6 < Num8 && Num6 < Num9 && Num6 < Num10)
                {
                    Console.WriteLine("D) El numero menor de los digitos es el " + Num6);
                }
                if (Num7 < Num1 && Num7 < Num2 && Num7 < Num3 && Num7 < Num4 && Num7 < Num5 && Num7 < Num6 && Num7 < Num8 && Num7 < Num9 && Num7 < Num10)
                {
                    Console.WriteLine("D) El numero menor de los digitos es el " + Num7);
                }
                if (Num8 < Num1 && Num8 < Num2 && Num8 < Num3 && Num8 < Num4 && Num8 < Num5 && Num8 < Num6 && Num8 < Num7 && Num8 < Num9 && Num8 < Num10)
                {
                    Console.WriteLine("D) El numero menor de los digitos es el " + Num8);
                }
                if (Num9 < Num1 && Num9 < Num2 && Num9 < Num3 && Num9 < Num4 && Num9 < Num5 && Num9 < Num6 && Num9 < Num7 && Num9 < Num8 && Num9 < Num10)
                {
                    Console.WriteLine("D) El numero menor de los digitos es el " + Num9);
                }
                if (Num10 < Num1 && Num10 < Num2 && Num10 < Num3 && Num10 < Num4 && Num10 < Num5 && Num10 < Num6 && Num10 < Num7 && Num10 < Num8 && Num10 < Num9)
                {
                    Console.WriteLine("D) El numero menor de los digitos es el " + Num10);
                }
                
            }




        }



        static void Main(string[] args)
        {
            NUMEROS10 ObjNUM = new NUMEROS10();
            ObjNUM.SUMA();
            NUMEROS10 ObjNUMP = new NUMEROS10();
            ObjNUM.PROMEDIO();
            NUMEROS10 ObjNUMM = new NUMEROS10();
            ObjNUM.NumeroMasGrande();
            NUMEROS10 ObjNUMMENOR = new NUMEROS10();
            ObjNUM.NumeroMENOR();
        }
    }
}
