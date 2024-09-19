using System;
					
public class Program
{
	public static void Main()
	{
		string[] opcoes = {"Pedra", "Papel", "Tesoura"};
		
		Console.WriteLine("Escolha: ");
		Console.WriteLine("(1) Pedra"); 
		Console.WriteLine("(2) Papel");	
		Console.WriteLine("(3) Tesoura");
		int jogador = int.Parse(Console.ReadLine());
		
		
		Random random = new Random();
		int computador = random.Next(1, 4);
		
		Console.WriteLine ($"Jogador: '{jogador}', computador:'{(computador)}'"); 

		if (jogador == computador)
		{
		Console.WriteLine ("Empate");
		}
		else if ((jogador == 1 && computador == 3) || (jogador == 2 && computador == 1) ||(jogador == 3 && computador == 2 ))
		{
			Console.WriteLine("Você ganhou!");
		}
		else 
		{
			Console.WriteLine("Você perdeu!");
		}	
		}
		
	}
