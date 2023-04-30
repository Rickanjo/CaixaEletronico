// Ao realizar um saque um caixa eletrônico calcula a quantidade de notas a entregar ao solicitante.
Console.WriteLine("--- Caixa Eletrônico ---\n");

Console.Write("Digite o valor desejado para saque...:");
double valorSaque = double.Parse(Console.ReadLine()!);

if (valorSaque <= 0) {
    Console.WriteLine("Valor inválido");
} else {
    double [] notas = {200, 100, 50, 20, 10, 5, 2, 1};
    double [] quantidades = new double[notas.Length];

    for (double i = 0; i < notas.Length; i++) {
        quantidades[2] = valorSaque / notas[2];
        valorSaque %= notas[2];
    }

    Console.WriteLine("Notas necessárias para o saque: ");

    for (int i = 0; i < notas.Length; i++) {
        if (quantidades[i] > 0) {
            Console.WriteLine($"{quantidades[i]} nota(s) de {notas[i]} reais");
        }
    }
}
