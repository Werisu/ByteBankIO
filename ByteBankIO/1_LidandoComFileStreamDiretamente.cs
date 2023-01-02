using ByteBankIO;
using System.Text;

partial class Program
{
    static void LidandoComFileStreamDiretamente()
    {
        var enderecoDoArquivo = "contas.txt";

        using (var fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
        {
            var numeroDeBytesLidos = -1;

            var buffer = new byte[1024]; //1KB

            while (numeroDeBytesLidos != 0)
            {
                numeroDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);

                Console.WriteLine($"\nBytes lidos: {numeroDeBytesLidos}");
                EscreverBuffer(buffer, numeroDeBytesLidos);
            }

            // public override int Read(byte[] array, int offset, int count);
            fluxoDoArquivo.Close();
            Console.ReadLine();
        }

    }

    static void EscreverBuffer(byte[] buffer, int bytesLidos)
    {

        var uft8 = new UTF8Encoding();

        var text = uft8.GetString(buffer, 0, bytesLidos);

        // public virtual string GetString(bytes[] bytes, int index, int count);
        Console.Write(text);

        //foreach(var meuByte in buffer)
        //{
        //    Console.Write(meuByte);
        //    Console.Write(" ");
        //}
    }
}