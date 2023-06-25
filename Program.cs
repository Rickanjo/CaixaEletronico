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

Console.Write("Digite a senha.....: ");
string senha = Console.ReadLine()!;

Thread.Sleep(2000);

Console.WriteLine("\nEscolha uma opção: ");
Console.WriteLine("Digite *1* para Sacar");
Console.WriteLine("Digite *2* para Transferir");

char tipoOperacao = Console.ReadKey().KeyChar;
Console.WriteLine();

string operacaoEscolhida;

switch (char.ToUpper(tipoOperacao))
{
    case '1':
        operacaoEscolhida = "Sacar";
        Console.WriteLine($"\nVocê escolheu: {operacaoEscolhida}.\n");
        Console.WriteLine("Notas disponíveis para saque: 20, 50, 100 e 200.");
        Console.WriteLine("\nO valor máximo de saque é de 2000 Reais.\n");

        Console.Write("Digite o valor desejado para saque...: ");
        int valorSaque;
        bool deuCerto = int.TryParse(Console.ReadLine(), out valorSaque);

        Console.Write("Digite a senha...........: ");
        string senhaDigitada = Console.ReadLine()!;

        Console.WriteLine("Verificando a senha...");
        Thread.Sleep(3000);

        if (senha == senhaDigitada)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Acesso permitido.\n");
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Senha incorreta.\n");
            Console.WriteLine("Retire o cartão e insira novamente.");
            return;
        }
        if (!deuCerto || valorSaque <= 4)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Esse caixa eletrônico não trabalha com esse(s) tipo(s) de nota(s).");
            return;
        }
        else if (valorSaque > 2000)
        {
            Console.WriteLine("Esse caixa eletrônico só permite saques de no máximo 2000 Reais.");
            Console.WriteLine("Retire o cartão e insira novamente.");
            return;
        }
        else
        {
            int[] notas = { 200, 100, 50, 20, 10, 5 };
            int[] quantidades = new int[notas.Length];

            for (int i = 0; i < notas.Length; i++)
            {
                quantidades[i] = valorSaque / notas[i];
                valorSaque %= notas[i];
            }

            Console.WriteLine();

            Console.WriteLine("Notas necessárias para o saque: \n");

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
        Console.WriteLine("Obrigado pela preferência.");
        break;

    case '2':
        operacaoEscolhida = "Transferir";
        Console.Write("Digite o número da conta para a qual você deseja transferir: ");
        int contaTransferir;
        if (!int.TryParse(Console.ReadLine(), out contaTransferir))
        {
            Console.WriteLine("Número de conta inválido.");
            return;
        }

        string resposta = string.Empty;

        while (resposta != "s" && resposta != "n")
        {
            Console.WriteLine($"Tem certeza que quer transferir para a conta {contaTransferir}? (S/N)");
            resposta = Console.ReadLine()?.ToLower().Trim()!;

            if (resposta == "s")
            {
                Console.WriteLine($"Você escolheu transferir para a conta {contaTransferir}\n");
                Console.Write("Digite o valor desejado para transferir...: ");
                int valorTransferencia;
                if (!int.TryParse(Console.ReadLine(), out valorTransferencia))
                {
                    Console.WriteLine("Valor inválido.");
                    return;
                }

                if (valorTransferencia <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valor inválido.");
                    return;
                }
                else if (valorTransferencia > 2000)
                {
                    Console.WriteLine("Esse caixa eletrônico só permite transferências de no máximo 2000 Reais.");
                    return;
                }

                Console.Write("Digite a senha...........: ");
                string senhaDigitadaTrans = Console.ReadLine()!;

                Console.WriteLine("Verificando a senha...");
                Thread.Sleep(3000);

                if (senha == senhaDigitadaTrans)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Acesso permitido.\n");
                    Console.ResetColor();
                }
                else
                {
                    Console.WriteLine("Senha incorreta.\n");
                    Console.WriteLine("Retire o cartão e insira novamente.");
                    return;
                }

                Console.WriteLine("Em andamento...");
                Thread.Sleep(4000);
                Console.WriteLine($"Você transferiu {valorTransferencia} reais para a conta {contaTransferir}.");
                Console.WriteLine("Obrigado pela preferência.");
                }
                else if (resposta == "n")
                {
                Console.WriteLine("Transferência cancelada.");
                }
                else
                {
                Console.WriteLine("Opção inválida. Digite 'S' para confirmar ou 'N' para cancelar.");
                }
            }
            break;

    default:
        operacaoEscolhida = "Operação desconhecida";
        break;
}
Console.ResetColor();