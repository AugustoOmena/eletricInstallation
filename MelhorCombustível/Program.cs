using System;
using System.ComponentModel;
using System.Globalization;

class Program {
    public static void Main(String[] args)
    {

        double gasolina, alcool;
        Console.Write("Qual o Preço do álcool? ");
        double va = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.WriteLine();
        alcool = va;
        Console.Write("Qual o preço da Gasolina? ");
        double vg = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        gasolina = vg;
        double mc = (va / vg);
        Console.WriteLine();
        Console.WriteLine("A diferença foi de: " + mc.ToString("F2", CultureInfo.InvariantCulture));
        try
        {
            if (mc > 0.7)
            {
                Console.WriteLine("vale a pena a gasolina. ");
            }
            else if (mc < 0.7)
            {
                Console.WriteLine("vale a pena o álcool.");
            }
            else
            {
                Console.WriteLine("tanto faz abastecer com um ou outro.");
            }
        }
        catch
        {
            Console.WriteLine("Valor não correspondente.");
        }
    }
}