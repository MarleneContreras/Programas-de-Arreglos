using System;
using System.Collections.Generic;
using System.Text;

namespace Taller_mecanica
{
    class TALLER_ME
    {
        //Atributos    
        private string[,] Autos;
        private List<string> Registrados;
        private List<int> cobro;
        private int ind;
        private int indiceS;
        //Propiedades   
        public string[,] Carros1
        {
            get => Autos; set => Autos = value;
        }
        public int N
        {
            get;
        }
        public List<int> Cobros
        {
            get => cobro; set => cobro = value;
        }
        public int Ind
        {
            get => ind; set => ind = value;
        }
        public List<string> CarrosRegistrados
        {
            get => Registrados; set => Registrados = value;
        }
        public int IndiceS { get => indiceS; set => indiceS = value; }
        //Constructor    
        public TALLER_ME(int n)
        {
            //se ingresa el numero de la capacidad maxima de autos 
            N = n;
            Autos = new string[N, 2];
            cobro = new List<int>();
            CarrosRegistrados = new List<string>();
            IndiceS = 0;
            Ind = 0;
            for (int rows = 0; rows < N; rows++)
            {
                for (int columns = 0; columns < 2; columns++)
                {
                    Carros1[rows, columns] = " - ";
                }
            }
        }
        //metodo     
        public Boolean Entrar(string No_placas, string Propietario)
        {
            if (Ind < N)
            {
                for (int i = 0; i < N; i++)
                {
                    if (Autos[i, 0] == " - ")
                    {
                        Ind = i; break;
                    }
                }
                Carros1[Ind, 0] = No_placas;
                Carros1[Ind, 1] = Propietario; string value = $"{No_placas}, {Propietario}";
                CarrosRegistrados.Add(value); return true;
            }
            return false;
        }
        public Boolean Recoger()
        {
            if (Ind - 1 >= 0)
            {
                for (int i = 0; i < N; i++)
                {
                    if (Autos[i, 0] != " - ")
                    {
                        Autos[i, 0] = Autos[i + 1, 0];
                        Autos[i, 1] = Autos[i + 1, 1];
                    }
                }
                Autos[N - 1, 0] = " - "; Autos[N - 1, 1] = " - "; return true;
            }
            return false;
        }
        public string Espacios()
        {
            String ans = "";
            for (int rows = 0; rows < N; rows++)
            {
                ans += Autos[rows, 0] + ", "; ans += Autos[rows, 1] + "\n";
            }
            return ans;
        }
        public void Cobrar(int cobro)
        {
            Cobros.Add(cobro);
        }
        public int[] GetMonto()
        {
            int[] AMonto = Cobros.ToArray(); return AMonto;
        }
        public string[] GetCarrosAcumulados()
        {
            string[] ACarrosAcumulados = CarrosRegistrados.ToArray(); return ACarrosAcumulados;
        }
        //Propiedades   
       
    }
}

