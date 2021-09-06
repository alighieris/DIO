using System;
using DIO.Heritage;

namespace DIO
{
	class Program
	{
		static void Main(string[] args)
		{
			// Classes1
			var s = new Pilha();
			s.Empilha(1);
			s.Empilha(10);
			s.Empilha(100);
			Console.WriteLine(s.Desempilha());
			Console.WriteLine(s.Desempilha());
			Console.WriteLine(s.Desempilha());
			
			// Switch
			string opt;
			Console.WriteLine("Escreva o input: ");
			opt = Console.ReadLine();
			switch (opt)
			{
				case "0":
					Console.WriteLine("Digitou 0");
					break;
					
				case "1":
					Console.WriteLine("Digitou 1");
					break;
				case "2":
					Console.WriteLine("Escreva um número decimal:");
					if (decimal.TryParse(Console.ReadLine(), out decimal numero))
					{
						Console.WriteLine(numero);
					}
					else
					{
						throw new ArgumentException(" Não é um número");
					}
					break;
				default:
					Console.WriteLine("Default");
					break;
			}

			// Classes2
			Ponto p1 = new Ponto(10,20);
			Ponto3D p2 = new Ponto3D(10, 20, 30);
			
			// Não é possível chama p1.CalcularDistancia(), pois é protected, só pode ser acessado internamente
			// e pelas classes filhas

			// Não é possível chamar p1.CalcularDistancia2(), pois é private, só pode ser acessado internamente
			
			p1.CalcularDistancia3();
			
			// Não seria possível usar p2.Calcular();, para este método faz-se:
			Ponto3D.Calcular();
		}
	}
}
