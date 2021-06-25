using System;

namespace MAYOR_MENOR
{
    class Program
    {
        class menor_mayor
        {
            int Num1_1, Num2_2, Num3_3, Num4_4, Num5_5, Num6_6, Num7_7, Num8_8, Num9_9, Num10_10,  Num11_11, Num12_12,  Num13_13,Num14_14, Num15_15, Num16_16, Num17_17, Num18_18, Num19_19, Num20_20;
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
                set { Num6_6 = value; }
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
            public int Num11
            {
                get { return Num11_11; }
                set { Num11_11 = value; }
            }
            public int Num12
            {
                get { return Num12_12; }
                set { Num12_12 = value; }
            }
            public int Num13
            {
                get { return Num13_13; }
                set { Num13_13 = value; }
            }
            public int Num14
            {
                get { return Num14_14; }
                set { Num14_14 = value; }
            }
            public int Num15
            {
                get { return Num15_15; }
                set { Num15_15 = value; }
            }
            public int Num16
            {
                get { return Num16_16; }
                set { Num16_16 = value; }
            }
            public int Num17
            {
                get { return Num17_17; }
                set { Num17_17 = value; }
            }
            public int Num18
            {
                get { return Num18_18; }
                set { Num18_18 = value; }
            }
            public int Num19
            {
                get { return Num19_19; }
                set { Num19_19 = value; }
            }
            public int Num20
            {
                get { return Num20_20; }
                set { Num20_20 = value; }
            }
            public void M_Y_M()
            {
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
                Console.WriteLine("Insertar el numero 11");
                Num11 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 12");
                Num12 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 13");
                Num13 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 14");
                Num14 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 15");
                Num15 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 16");
                Num16 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 17");
                Num17 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 18");
                Num18 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 19");
                Num19 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Insertar el numero 20");
                Num20 = Convert.ToInt32(Console.ReadLine());
                //arreglo con números en desorden
                int[] numeros = { Num1, Num2, Num4, Num5, Num6, Num7, Num8, Num9, Num10, Num3, Num11, Num12, Num14, Num15, Num16, Num17, Num18, Num19, Num20, Num13 };
                //la siguiente instrucción ordena el arreglo numeros demenor a mayor
                //su sintaxis es array.Sort(nombredelarreglo);
                Array.Reverse(numeros);
                //la siguiente sintaxis invierte el orden del arreglo, comoestaba de
                //menor a mayor ahora estará de mayor a menor
                //su sintaxis es array.Reverse(nombredelarreglo);
                Array.Sort(numeros);
                Console.WriteLine("Ordenados de menor a mayor");
                //se imprime en pantalla el arreglo con un ciclo for
                for (int i = 0; i < numeros.Length; i++)
                {
                    Console.WriteLine("Numero: " + numeros[i].ToString());
                }
                Console.ReadLine();//sedetiene pantalla
            }
        }
        static void Main(string[] args)
        {
            menor_mayor OBJMYM = new menor_mayor();
            OBJMYM.M_Y_M();
        }
    }
}
