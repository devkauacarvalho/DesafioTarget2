using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InverterString.Models

{
    public class ObjetoNome
    {
        public void InverterNome(string nome)
        {
            string nomeInvertido = "";

            // Itera sobre o nome de trás para frente na string nomeInvertido
            for (int ultimoIndice = nome.Length - 1; ultimoIndice >= 0; ultimoIndice--)
            {
                nomeInvertido += nome[ultimoIndice];
            }

            Console.WriteLine($"Seu nome invertido fica: {nomeInvertido}");
        }
    }
}