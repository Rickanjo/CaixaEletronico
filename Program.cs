// Ao realizar um saque um caixa eletrônico calcula a quantidade de notas a entregar ao solicitante.
Console.WriteLine("--- Caixa Eletrônico ---\n");

Console.Write("Digite o valor desejado para saque...:");
int valorSaque = int.Parse(Console.ReadLine()!);

if (valorSaque <= 0) {
    Console.WriteLine("Valor inválido");
} else {
    int [] notas = {200, 100, 50, 20, 10, 5, 2, 1};
    int [] quantidades = new int[notas.Length];

    for (int i = 0; i < notas.Length; i++) {
        quantidades[i] = valorSaque / notas[i];
        valorSaque %= notas[i];
    }

    Console.WriteLine("Notas necessárias para o saque: ");

    for (int i = 0; i < notas.Length; i++) {
        if (quantidades[i] > 0) {
            Console.WriteLine($"{quantidades[i]} nota(s) de {notas[i]} reais");
        }
    }
}
