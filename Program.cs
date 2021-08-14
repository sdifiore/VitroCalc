using System;

namespace VitroCalc
{
    class Program
    {
        static void Main()
        {
            float largura, comprimento, comprimentoMadeira, areaEnvidracada;

            const float larguraMax = 5.0f;
            const float larguraMin = 0.5f;
            const float comprimentoMax = 3.0f;
            const float comprimentoMin = 0.75f;

            string larguraString, comprimentoString;

            Console.Write("Forneça a largura da janela: ");
            larguraString = Console.ReadLine();
            largura = float.Parse(larguraString);

            if (largura < larguraMin)
            {
                Console.WriteLine("Largura é muito pequena.\n\n ");
                Console.WriteLine("Usando o mínimo");
                largura = larguraMin;
            }

            if (largura > larguraMax)
            {
                Console.WriteLine("Largura é muito grande.\n\n");
                Console.WriteLine("Usando o máximo");
                largura = larguraMax;
            }

            Console.Write("Forneça o comprimento da janela: ");
            comprimentoString = Console.ReadLine();
            comprimento = float.Parse(comprimentoString);

            if (comprimento < comprimentoMin)
            {
                Console.WriteLine("O comprimento é muito pequeno.\n\n");
                Console.WriteLine("Usando o mínimo");
                comprimento = comprimentoMin;
            }

            if (comprimento > comprimentoMax)
            {
                Console.WriteLine("O comprimento é muito grande.\n\n");
                Console.WriteLine("Usando o máximo");
                comprimento = comprimentoMax;
            }

            comprimentoMadeira = (2.0f * (largura + comprimento) * 3.25f);

            areaEnvidracada = 2 * (largura * comprimento);

            Console.WriteLine($"O comprimento da madeira é { comprimentoMadeira } pés");
            Console.WriteLine($"A área envidraçada é { areaEnvidracada } metros quadrados");
        }
    }
}
