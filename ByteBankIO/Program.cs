using ByteBankIO;
using System.Text;

partial class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Digite o seu nome");
        //var nome = Console.ReadLine();

        var linas = File.ReadAllText("contas.txt");
        Console.WriteLine(linas);

        Console.WriteLine("Aplicação Finalizada ...");
        Console.ReadLine();
    }
}