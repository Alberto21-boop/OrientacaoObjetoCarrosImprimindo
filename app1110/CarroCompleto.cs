using app1110;
using System.IO;

Carro carro = new Carro();

carro.NomeDoCarro = Console.ReadLine();
carro.NumeroDaPlaca = int.Parse(Console.ReadLine());
carro.CorDoCarro = Console.ReadLine();

string[] lines = { "Carro : " + carro.NomeDoCarro, "Placa : " + carro.NumeroDaPlaca, "Cor : " + carro.CorDoCarro };

string docPath = @"C:\Users\Àlberto Barbòsa\Desktop\PastaImprime";

using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "WriteLines.txt")))
{
    foreach (string line in lines)
        outputFile.WriteLine(line);
}