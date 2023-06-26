using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RPGDev
{
    internal class Mapa
    {
        public int alturaM = 10;
        public int larguraM = 10;
        public int[,] formatoMapa;
        public int[] mobSpaw;
        public int[] entrada;
        public int[] saida;

        public Mapa()
        {
            Console.Write("\nGerando Mapa ");
            formatoMapa = new int[alturaM,larguraM];
            mobSpaw = new int[] { 0,1,2,3 };
            MontarMapa();
            
            Console.Write(".");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(700);
            Console.Write(".");
            Thread.Sleep(700);
            Console.WriteLine("\nMapa Gerado");
        }

        public void MontarMapa()
        {
            Random rdn = new Random();
            for (int i = 0; i < alturaM; i++)
            {
                for (int j = 0; j < larguraM; j++)
                {
                    formatoMapa[i,j] = mobSpaw[rdn.Next(0,3)];
                }
            }
            int xEntrada = rdn.Next(0,10);
            int yEntrada = rdn.Next(0,10);
            formatoMapa[xEntrada,yEntrada] = 0;
            entrada = new int[] { xEntrada,yEntrada };
            int xSaida = rdn.Next(0,10);
            int ySaida = rdn.Next(0,10);
            formatoMapa[xSaida,ySaida] = 4;
            saida = new int[] { xSaida,ySaida };
        }
        public void MostrarMApa(List<int> passos)
        {

            int[] ultimapegada = new int[] { entrada[0], entrada[1] };
            string mapaComeco = "◇";
            string mappassos = "□";
            string mapDesconhecido = "▩";
            string[,] MapaMostrar = new string[alturaM, larguraM];
            MapaMostrar[ultimapegada[0], ultimapegada[1]] = mapaComeco;
            
            for (int i = 0; i < passos.Count; i++)
            {
                if(passos[i] == 4) {

                    ultimapegada[1]--;
                    MapaMostrar[ultimapegada[0], ultimapegada[1]] = mappassos;
                   
                    
                }
                else if (passos[i] == 3)
                {
                    ultimapegada[1]++;
                    MapaMostrar[ultimapegada[0], ultimapegada[1]] = mappassos;
                   

                }
                else if(passos[i] == 1)
                {
                    ultimapegada[0]--;
                    MapaMostrar[ultimapegada[0], ultimapegada[1]] = mappassos;
                   
                }
                else if (passos[i] == 2)
                {
                    ultimapegada[0]++;
                    MapaMostrar[ultimapegada[0], ultimapegada[1]] = mappassos;
                    
                }


            }
            for (int i = 0; i < larguraM; i++)
            {
                for (int j = 0; j < alturaM; j++)
                {
                    if(MapaMostrar[i,j] != mappassos&& MapaMostrar[i, j] != mapaComeco) { MapaMostrar[i, j] = mapDesconhecido; }
                   
                    Console.Write(MapaMostrar[i, j]+" ");
                    if (j == alturaM - 1) { Console.Write("\n"); }
                }

            }


        }
    }
}
