using System;

namespace CADENAS
{
    class Program
    {
        class Cadenas
        {
            string Cade;

            public void LETRAS_MAYUSCULAS()
            {
                //*******Este codigo hace qu el ingresar alguna letra en minuscula a mayusculas***********//
                Console.WriteLine("***************************************************");
                Console.WriteLine("la cadena en mayusculas es: {0}", Cade.ToUpper());
                //*******Este codigo es para intercambiar unas letras por numero*********////
                Console.WriteLine("***************************************************");
                Console.WriteLine("Se intercambain las letras por numeros: {0}", Cade.Replace("a", "4").Replace("i", "1").Replace("s", "5").Replace("b", "8").Replace("e", "3").Replace("t", "7"));
                Console.WriteLine("***************************************************");
            }
            public void FRASE()
            {
                Console.WriteLine("Insecte una frase: ");
                Cade = Convert.ToString(Console.ReadLine());
                char[] cArray = Cade.ToCharArray();
                string Reverse = String.Empty;
                ////**Esto aplica para al ingresar la frase o palabras  te muestra despues acomodados al reves*** MAYI (IYAM)***//
                for (int i = cArray.Length - 1; i > -1; i--)
                {
                    Reverse += cArray[i];
                }
                Console.WriteLine("**********************");
                Console.WriteLine("La palabra de reversa :" + Reverse);
                Console.ReadKey();
            }  
        }
        static void Main(string[] args)
        {
            Cadenas OBJCADENAS = new Cadenas();
             OBJCADENAS.FRASE();
            Cadenas OBJECADENAS = new Cadenas();
            OBJCADENAS.LETRAS_MAYUSCULAS();


        }
    }

    
}
