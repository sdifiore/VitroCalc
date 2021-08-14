using System;

namespace VitroCalc
{
    class Program
    {
        static void Main()
        {
            double largura, altura, comprimentoMadeira, areaVidro;
                string larguraString, alturaString;

                Console.WriteLine("Digite a largura da janela em metros:\a");
                larguraString = Console.ReadLine();
                largura = double.Parse(larguraString);

                Console.WriteLine("Digite a altura da janela em metros:\a");
                alturaString = Console.ReadLine();
                altura = double.Parse(alturaString);

                comprimentoMadeira = 2 * (largura + altura) * 3.25;

                areaVidro = 2 * (largura * altura);

                Console.WriteLine($"O comprimento da madeira é { comprimentoMadeira }.\n"
                                + $"A área envidraçada é { areaVidro } pés quadrados");
        }
    }
}
