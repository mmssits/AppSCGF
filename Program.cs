using System;

namespace ControleFinancas
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            bool applicationOn = true;

            Console.WriteLine("____________________________________________________\n");
            Console.WriteLine("  SCGF - Sistema de Controle e Gestão de Finanças  ");
            Console.WriteLine("____________________________________________________\n");

            Console.WriteLine("Seja bem-vindo(a) ao SCGF, seu braço direito no controle de finanças pessoal!\n");

            Console.WriteLine("Para prosseguir, digite o nome do titular da conta:");

            nome = Console.ReadLine();


            while (applicationOn)
            {
                Console.Clear();

                Console.WriteLine("____________________________________________________\n");
                Console.WriteLine("  SCGF - Sistema de Controle e Gestão de Finanças  ");
                Console.WriteLine("____________________________________________________\n");

                Console.WriteLine($"Seja bem-vindo(a), {nome}!\n");

                Console.WriteLine("Escolha uma das opções a seguir:\n");
                Console.WriteLine("1 - Adicionar despesa");
                Console.WriteLine("2 - Adicionar receita");
                Console.WriteLine("3 - Visualizar saldos");
                Console.WriteLine("4 - Visualizar transações");
                Console.WriteLine("5 - Sair da aplicação");

                int option = Convert.ToInt32(Console.ReadLine());

                

                Conta conta = new Conta(nome);

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Digite o valor da despesa: ");
                        double despesaValor = Convert.ToDouble(Console.ReadLine());
                        conta.AdicionarTransacao(despesaValor, "Despesa");
                        break;

                    case 2:
                        Console.WriteLine("Digite o valor da receita: ");
                        double receitaValor = Convert.ToDouble(Console.ReadLine());
                        conta.AdicionarTransacao(receitaValor, "Receita");
                        break;

                    case 3:
                        Console.WriteLine($"Saldo atual da conta: {conta.CalcularSaldo}");
                        break;

                    case 4:
                        conta.ListarTransacoes();
                        break;

                    case 5:
                        applicationOn = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida. Por favor, escolha novamente uma opção válida.");
                           break;
                }

                Console.Clear();
            }
        }
    }
}
