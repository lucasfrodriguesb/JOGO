using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo.cs
{
    public class Principal
    {
        public static  void Main(string[] args)
        {
            Console.WriteLine("Escolha um modo de batalha:");
            Console.WriteLine("1 - 1 vs Computador");
            Console.WriteLine("2 - 1 vs 1");
            Console.WriteLine("3 - Sair do jogo");
            int opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Você escolheu 1 vs Computador!");
                    Console.Write("Informe seu nome: ");
                    string nomeJogador = Console.ReadLine();
                    int pontosJogador = 10;
                    int pontosComputador = 10;
                    string[] naipes = { "copas", "ouros", "espadas" };
                    Random random = new Random();
                    string[] nomes = { nomeJogador, "Computador" };
                    int jogadorAtual = random.Next(2);
                    Console.WriteLine("Você começa" + nomes[jogadorAtual]);
                    while (pontosJogador > 0 && pontosComputador > 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"pontos de {nomeJogador}: {pontosJogador}");
                        Console.WriteLine($"pontos do computador: {pontosComputador}");
                        Console.WriteLine();
                        Console.WriteLine($"{nomes[jogadorAtual]}, pressione uma tecla para sortear as cartas");
                        Console.ReadKey();
                        string[] cartas = new string[3];
                        for (int i = 0; i < 3; i++)
                        {
                            int indexCarta = random.Next(naipes.Length);
                            cartas[i] = naipes[indexCarta];
                        }
                        Console.WriteLine($"As cartas que o {nomes[jogadorAtual]} tirou foram:{cartas[0]}, {cartas[1]} e  { cartas[2]}");
                    if (cartas[0] == cartas[1] && cartas[1] == cartas[2])
                        {
                            Console.WriteLine($"O jogador {nomes[jogadorAtual]} tirou cartas iguais e não perde pontos.");
                        }
                        else
                        {
                            Console.WriteLine($"O jogador {nomes[jogadorAtual]} tirou cartas diferentes e perdeu 1 de pontos.");
                        if (jogadorAtual == 0)
                            {
                                pontosJogador--;
                            }
                            else
                            {
                                pontosComputador--;
                            }
                        }
                        jogadorAtual = (jogadorAtual + 1) % 2;
                    }
                    if (pontosJogador == 0)
                    {
                        Console.WriteLine($"{nomeJogador} perdeu todas os pontos. Computador venceu!");
                    }
                    else
                    {
                        Console.WriteLine($"O computador perdeu todas as pontoss. Parabéns{nomeJogador}, vocêvenceu!");
                    }
                    break;
                case 2:
                    Console.WriteLine("Você escolheu jogar contra outro jogador!");
                    Console.Write("Digite o nome do jogador 1: ");
                    string nomeplayer1 = Console.ReadLine();
                    Console.Write("Digite o nome do jogador 2: ");
                    string nomeplayer2 = Console.ReadLine();
                    int pontosplayer1 = 10;
                    int pontosplayer2 = 10;
                    string[] naipesC = { "copas", "ouros", "espadas" };
                    Random randomR = new Random();
                    string[] nomesN = { nomeplayer1, nomeplayer2 };
                    int jogadorAtualUm = randomR.Next(2);
                    Console.WriteLine("O jogador que vai começar é: " +
                    nomesN[jogadorAtualUm]);
                    while (pontosplayer1 > 0 && pontosplayer2 > 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine($"pontos de {nomeplayer1}: {pontosplayer1}");
                        Console.WriteLine($"pontos de {nomeplayer2}: {pontosplayer2}");
                        Console.WriteLine();
                        Console.WriteLine($"{nomesN[jogadorAtualUm]} pressione uma tecla para sortear as cartas...");
                        Console.ReadKey();
                        string[] cartas = new string[3];
                        for (int i = 0; i < 3; i++)
                        {
                            int indexCarta = randomR.Next(naipesC.Length);
                            cartas[i] = naipesC[indexCarta];
                        }
                        Console.WriteLine($"As cartas que o {nomesN[jogadorAtualUm]} tirou foram: {cartas[0]},{ cartas[1]} e { cartas[2]} ");
                    if (cartas[0] == cartas[1] && cartas[1] == cartas[2])
                        {
                            Console.WriteLine($"O jogador {nomesN[jogadorAtualUm]} tirou cartas iguais e não perde pontos.");
                    }
                        else
                        {
                            Console.WriteLine($"O jogador {nomesN[jogadorAtualUm]} tirou cartas diferentes e perdeu 1 de pontos.");
                        if (jogadorAtualUm == 0)
                            {
                                pontosplayer1--;
                            }
                            else
                            {
                                pontosplayer2--;
                            }
                        }
                        jogadorAtualUm = (jogadorAtualUm + 1) % 2;
                    }
                    if (pontosplayer1 == 0)
                    {
                        Console.WriteLine($"O jogador {nomeplayer1} perdeu todas as pontoss.");
                        Console.WriteLine($"O jogador {nomeplayer2} venceu!");
                    }
                    else
                    {
                        Console.WriteLine($"O jogador {nomeplayer2} perdeu todas as pontoss.");
                        Console.WriteLine($"O jogador {nomeplayer1} é o campeão!");
                    }
                    break;
                case 3:
                    Console.WriteLine("Obrigado por jogar! Até a próxima.");
                    break;
                default:
                    break;
            }
            Console.ReadLine();

        }
    }
}
