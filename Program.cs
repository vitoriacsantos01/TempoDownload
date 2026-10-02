Console.WriteLine("--- tempo de Download ---");
Console.WriteLine("tamanho do arquivo em MB........: ");
double tamanho = double.Parse(Console.ReadLine()) * 8;


Console.Write("velocidade da conexão em Mbps...: ");


double velocidade = double.Parse(Console.ReadLine());
double tempo = (tamanho / velocidade) / 60; 
Console.WriteLine($"tempo de dowload: {tempo:F2} minutos");

