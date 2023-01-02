using ByteBankIO;
using System.Text;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456, 7895, 4785.40, Gustavo Santos";

            var encoding = Encoding.UTF8;

            var bytes = encoding.GetBytes(contaComoString);

            fluxoDeArquivo.Write(bytes, 0, bytes.Length);
        }
    }

    static void CirarArquivoComWrite()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using(var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using(var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.Write("328,7739,4833.26,Pedro");
        }
    }

    static void gerarCopiaDeUmArquivo()
    {
        var arquivoOriginal = new FileStream("contas.txt", FileMode.Open);
        var arquivoNovo = new FileStream("contas2.txt", FileMode.Create);
        var buffer = new byte[1024];

        using (arquivoOriginal)
        using (arquivoNovo)
        {
            var bytesLidos = -1;
            while (bytesLidos != 0)
            {
                bytesLidos = arquivoOriginal.Read(buffer, 0, 1024);
                arquivoNovo.Write(buffer, 0, bytesLidos);
            }
        }

        var rodape = Encoding.UTF8.GetBytes("Este documento é uma cópia do original");
        arquivoNovo.Write(rodape, 0, rodape.Length);
    }

    static void TestaEscrita()
    {
        var caminhoNovoArquivo = "teste.txt";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            for (int i = 0; i < 1000000; i++)
            {
                escritor.WriteLine($"Linha {i}");
                escritor.Flush(); //Despeja o buffer para o Stream

                Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter...");
                Console.ReadLine();
            }
        }
    }

    static void TestaEscritaStreamWriter()
    {
        var caminhoNovoArquivo = "TestaEscrita.txt";

        using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDeArquivo))
        {
            escritor.WriteLine(true);
            escritor.WriteLine(false);
            escritor.WriteLine(4545454545);
        }

        Console.WriteLine("Aplicação finalizada ...");
    }
}