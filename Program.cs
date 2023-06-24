Console.ForegroundColor = ConsoleColor.DarkRed;
Console.WriteLine("                   --- Caixa Eletrônico ---\n");

Console.ResetColor();

Console.WriteLine("Insira o cartão...");
Console.ReadKey();
Console.WriteLine("Verificando cartão...");
Thread.Sleep(1500);
Console.WriteLine("Aguarde estamos verificando o seu cartão ");

Thread.Sleep(5000);

Console.WriteLine("Cartão verificado com sucesso ");
Thread.Sleep(1500);
Console.Write("Digite a senha.....:");
string senha = Console.ReadLine()!;

Thread.Sleep(2000);

Console.WriteLine("\nEscolha um abaixo: ");
Console.WriteLine("Digite *1* para Sacar");
Console.WriteLine("Digite *2* para Transfirir");
char tipoOperação = Console.ReadKey().KeyChar;

Console.WriteLine();

string operaçãoEscolhida;

switch (Char.ToUpper(tipoOperação))
{

    case '1':
    operaçãoEscolhida = "Sacar";
    Console.WriteLine($"\nVocê escolheu: {operaçãoEscolhida}.\n");
    Console.WriteLine("Notas Disponiveis para seque 5, 10, 20, 50, 100 e 200. ");
    Console.WriteLine("\nO máximo de dinheiro possivel de sacar 2000 Reais\n ");

    Console.Write("\nDigite o valor desejado para saque...: ");

    int valorSaque;
    bool deuCerto = int.TryParse(Console.ReadLine()!, out valorSaque);

    Console.Write("Digite a senha...........: ");
    string senhaDigitada = Console.ReadLine()!;

    Console.WriteLine("Verificando a senha...");
    Thread.Sleep(3000);

    if (senha == senhaDigitada)
    {
        Console.WriteLine("Acesso permetido");
    }else  
    {
        Console.WriteLine("Senha incorreta. \n");
        Console.WriteLine("Retire o cartão e insira novamente.");
        
        return;
    }

     if (!deuCerto || valorSaque <= 4) 
    {
        Console.ForegroundColor =  ConsoleColor.Red;
        Console.WriteLine("Esse caixa eletrônico não trabalha com esse(s) tipo(s) de nota(s) ");

    } else if (valorSaque > 2000)
    {
        Console.WriteLine("Esse caixa eletrônico so pode sacar no máximo 2000 Reais");
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

        Console.WriteLine();

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
    Console.WriteLine("Retire seu dinheiro...");
    Thread.Sleep(4000);
    Console.WriteLine("Obrigado pelo preferência.");


    break;

    case '2':
    operaçãoEscolhida = "Transferir";
    Console.Write("Digite o número da conta para a qual você deseja transferir: ");
    int contaTransferir = int.Parse(Console.ReadLine()!);
    string resposta = string.Empty;

    while (resposta != "s" && resposta != "n")
    {
        Console.WriteLine($"Tem certeza que quer transferir para a conta {contaTransferir}? (S/N)");
        resposta = Console.ReadLine()?.ToLower().Trim()!;

        if (resposta == "s")
        {
            Console.WriteLine($"Você escolheu transferir para a conta {contaTransferir}\n");
            Console.Write("\nDigite o valor desejado para transferir...: ");
            int valorTransferencia;
            bool deuCertoTrans = int.TryParse(Console.ReadLine()!, out valorTransferencia);

            if (!deuCertoTrans || valorTransferencia <= 0) 
            {
                Console.ForegroundColor =  ConsoleColor.Red;
                Console.WriteLine("Valor inválido ");

            } else if (valorTransferencia > 2000)
            {
                Console.WriteLine("Esse caixa eletrônico so pode transferir no máximo 2000 Reais");
                return;

            }
            else if (resposta == "n")
            {
             Console.WriteLine("Transferência cancelada.");
             
            }
            else
            {
                Console.WriteLine("Em andamento");
                Thread.Sleep(4000);
                Console.WriteLine($"Você transferio {valorTransferencia} reais para a conta {contaTransferir}"); 
                Console.WriteLine("Obrigado pelo preferência.");

                //Console.WriteLine("Opção inválida. Digite 'S' para confirmar ou 'N' para cancelar.");
            }
        }   
    }
    
    break;

    default:
    operaçãoEscolhida = "Operação desconhecida";
    break;

   // default:
    //operaçãoEscolhida = "Operação desconhecida";
    //break;
}   

Console.ResetColor();


 //Console.Write("Digite o número da conta que você quer transfirir");
   // int contatransferir = int.Parse(Console.ReadLine()!);

   // Console.WriteLine("Obrigado pelo preferência.");