using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGDev
{
    internal class VerificaInput
    {

        public int GetInput(int min, int max)
        {
            string valida = "";

            while (true)
            {
                valida = Console.ReadLine();

                if (valida.All(char.IsDigit) && valida != "")
                {

                    {

                        if (int.Parse(valida) <= max && int.Parse(valida) >= min)
                        {
                            return int.Parse(valida);
                        }
                        else
                        {
                            Console.WriteLine($"\n Caro Jogador, digite uma opção valida: ");
                            Console.Write("Opção -> ");

                        }
                    }
                }
                else
                {
                    Console.WriteLine($"\n Caro Jogador, digite uma opção valida: ");
                    Console.Write("Opção -> ");

                }
            }

        }
    }
}
