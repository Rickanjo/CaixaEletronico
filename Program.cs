Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("                   --- Caixa Eletrônico ---\n");

Console.WriteLine("Escolha um abaixo: ");
Console.WriteLine("1 - Sacar");
Console.WriteLine("2 - Depositar");
char tipoOperação = Console.ReadKey().KeyChar;

Console.WriteLine();

string operaçãoEscolhida;

switch (Char.ToUpper(tipoOperação))
{

    case '1':
    operaçãoEscolhida = "Sacar";
    Console.ForegroundColor = ConsoleColor.Red;
    break;

    case '2':
    operaçãoEscolhida = "Depositar, Depositar está indisponivel no momento procure uma agencia mas perto";
    Console.ForegroundColor = ConsoleColor.Yellow;
    break;
    
    default:
    operaçãoEscolhida = "Operação desconhecida";
    Console.ForegroundColor = ConsoleColor.DarkGray;
    break;
}

Console.WriteLine($"\nVocê escolheu a operação: {operaçãoEscolhida}.");

Console.ResetColor();

Console.WriteLine("Este caixa eletrônico so trabalha com notas de 5 reais ou mais. ");
Console.WriteLine("Notas Disponiveis para seque 5, 10, 20, 50,100 e 200. ");
Console.WriteLine("O máximo de dinheiro possivel de sacar 2000 Reais ");

Console.Write("\nDigite o valor desejado para saque...: ");
int valorSaque;
bool deuCerto = int.TryParse(Console.ReadLine()!, out valorSaque);

 if (!deuCerto || valorSaque <= 4) 
 {
    Console.ForegroundColor =  ConsoleColor.Red;
    Console.WriteLine("Esse caixa eletrônico não trabalha com esse(s) tipo(s) de nota(s) ");

 } else if (valorSaque > 2000){
    Console.WriteLine("Esse caixa eletrônico não trabalha com esse(s) tipo(s) de nota(s) ");
    return;

 } else 
 {
    int [] notas = {200, 100, 50, 20, 10, 5,};
    int [] quantidades = new int[notas.Length];

    for (int i = 0; i < notas.Length; i++) 
    {
        quantidades[i] = valorSaque / notas[i];
        valorSaque %= notas[i];
    }

    Console.WriteLine("Notas necessárias para o saque: ");

    for (int i = 0; i < notas.Length; i++) 
    {
        if (quantidades[i] > 0) 
        {
            Console.WriteLine($"{quantidades[i]} nota(s) de {notas[i]} reais");
        }




    }
}
Console.ResetColor();