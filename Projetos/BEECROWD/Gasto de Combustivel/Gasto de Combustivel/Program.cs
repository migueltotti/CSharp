using System;
using System.Globalization;

class URI
{
    static void Main(string[] args)
    {
        // consumo carro: 12 km/l
        int tempo, velocidade, distancia;
        // tempo - horas ; velocidade = km/h
        double consumo; // distancia / 12

        tempo = int.Parse(Console.ReadLine());
        velocidade = int.Parse(Console.ReadLine());
        distancia = (tempo * velocidade);

        consumo = (double)distancia / 12;
        // quando fazemos divisoes de numeros inteiros em C# o valor resultante sempre eh arredendado, por isso precisamos colocar '(double)' antes para permitir que o valor 'quebrado' seja armazenado

        Console.WriteLine(consumo.ToString("F3", CultureInfo.InvariantCulture));

    }
}