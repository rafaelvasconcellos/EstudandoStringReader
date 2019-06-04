using System;
using System.IO;
using System.Text;

namespace EstudoDoStringReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            var textoDoGloboesporte = new ArquivoTexto();

            using (var leitor = new StringReader(textoDoGloboesporte.Texto))
            {
                using (var escritor = new StringWriter())
                {
                    string linha;
                    while ((linha = leitor.ReadLine()) != null)
                    {
                        escritor.WriteLine("֎ " + linha);
                    }

                    Console.WriteLine(escritor);
                }
            }

            Console.ReadKey();
        }

    }

    public class ArquivoTexto
    {
        public string Texto => @"O bom retrospecto do Palmeiras em sua arena em 2019 embala o time de Felipão 
nas últimas duas rodadas do Campeonato Brasileiro antes da paralisação para a disputa América. 
Será no estádio alviverde que o Verdão receberá Athletico e Avaí para manter ou até aumentar a 
folga na liderança do torneio nacional.";

    }
}
