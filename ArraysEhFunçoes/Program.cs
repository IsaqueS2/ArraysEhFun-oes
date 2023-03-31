using System;

public class Program
{
    static int[] valores = new int[10] { 1, -1, 2, 3, 4, -4, 9, 12, 7, -3 };

    public static void Main()
    {
        int maiorValor = EncontrarMaiorValor(valores);
        Console.WriteLine($"Maior valor: {maiorValor}");

        int menorValor = EncontrarMenorValor(valores);
        Console.WriteLine($"Menor valor: {menorValor}");

        double valorMedio = EncontrarValorMedio(valores);
        Console.WriteLine($"Valor Médio: {valorMedio}");

        EncontrarTresMaioresValores(valores);

        Console.Write("Valores Negativos: ");
        EncontrarValoresNegativos(valores);
        Console.WriteLine();

        Console.Write("Todos os Valores: ");
        ExibirValores(valores);

        Console.WriteLine();
        RemoverValor(valores);

    }

    static int EncontrarMaiorValor(int[] valores)
    {

        int maiorValor = valores[0];

        for (int i = 0; i < valores.Length; i++)
        {
            if (valores[i] > maiorValor)
            {
                maiorValor = valores[i];
            }
        }

        return maiorValor;
    }

    static int EncontrarMenorValor(int[] valores)
    {

        int menorValor = valores[0];

        for (int i = 0; i < valores.Length; i++)
        {
            if (valores[i] < menorValor)
            {
                menorValor = valores[i];
            }
        }

        return menorValor;
    }

    static double EncontrarValorMedio(int[] valores)
    {

        double somaDosValores = 0;

        for (int i = 0; i < valores.Length; i++)
        {
            somaDosValores += valores[i];
        }

        return somaDosValores / valores.Length;
    }

    static void EncontrarTresMaioresValores(int[] valores)
    {

        Array.Sort(valores);

        Console.WriteLine($"Três maiores valores: {valores[7]}, {valores[8]}, {valores[9]}");

    }

    static void EncontrarValoresNegativos(int[] valores)
    {

        Array.Sort(valores);

        for (int i = 0; i < valores.Length; i++)
        {
            if (valores[i] < 0)
            {
                Console.Write($"{valores[i]} ");
            }
        }

    }

    static void ExibirValores(int[] valores)
    {

        for (int i = 0; i < valores.Length; i++)
        {
            Console.Write($"{valores[i]}  ");
        }

    }


    static void RemoverValor(int[] valores)
    {
        Console.WriteLine("Digite um valor para remover: ");
        int valorRemovido = int.Parse(Console.ReadLine());


        for (int i = 0; i < valores.Length; i++)
        {
            if (valorRemovido == valores[i])
            {
                valores[i] = 0;
            }
        }
    }
}