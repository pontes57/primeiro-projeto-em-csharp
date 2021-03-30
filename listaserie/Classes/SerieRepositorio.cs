using System;
using System.Collections.Generic;
using DIO.Series.Interfaces;

namespace DIO.Series
{
	public class SerieRepositorio : IRepositorio<Serie>
	{
        private List<Serie> listaSerie = new List<Serie>();
		public void Atualiza(int id, Serie objeto)
		{
			listaSerie[id] = objeto;
		}

		public void Exclui(int id)
		{
			listaSerie[id].Excluir();
		}

		public void Insere(Serie objeto)
		{
			listaSerie.Add(objeto);
		}

		public List<Serie> Lista()
		{
			return listaSerie;
		}

		public int ProximoId()
		{
			return listaSerie.Count;
		}

		public Serie RetornaPorId(int id)
		{
			return listaSerie[id];
		}

		public void pesquisagenero(){
			foreach (int i in Enum.GetValues(typeof(Genero)))
			{
				Console.WriteLine("{0}-{1}", i, Enum.GetName(typeof(Genero), i));
			}
			Console.Write("Digite o gênero entre as opções acima: ");
			int entradaGenero = int.Parse(Console.ReadLine());

			foreach (var serie in listaSerie)
			{
                int genero = serie.retornagenero();
                if(genero==entradaGenero)
					Console.WriteLine("#ID {0}: - {1} {2}", serie.retornaId(), serie.retornaTitulo(), Enum.GetName(typeof(Genero), entradaGenero));
			}
			
		}

		public void pesquisanimacao(){
			foreach (var serie in listaSerie)
			{
                if(serie.retornaisanimacao())
					Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
			}
		}

		public void pesquisaNumax(){
			Console.Write("Digite o numero maximo de episodios desejado: ");
			int Numax= int.Parse(Console.ReadLine());

			foreach (var serie in listaSerie)
			{
                if(Numax>=serie.retornaNumEpi())
					Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
				}
		}

		public void pesquisaano(){
			Console.Write("Digite o ano de lançamento desejado: ");
			int ano= int.Parse(Console.ReadLine());

			foreach (var serie in listaSerie)
			{
                if(ano==serie.retornaano())
					Console.WriteLine("#ID {0}: - {1}", serie.retornaId(), serie.retornaTitulo());
				}
		}


		public string ObterOpcaoUsuario()
		{
			Console.WriteLine();
			Console.WriteLine("Informe a caracteristica desejada:");

			Console.WriteLine("1- genero");
			Console.WriteLine("2- animacao");
			Console.WriteLine("3- numero maximo de episodios");
			Console.WriteLine("4- ano de lançamento");
			Console.WriteLine();

			string opcaoUsuario = Console.ReadLine().ToUpper();
			Console.WriteLine();
			return opcaoUsuario;
		}

		public void pesquisa(){
			string opcaoUsuario = ObterOpcaoUsuario();
			switch (opcaoUsuario)
			{
				case "1":
					pesquisagenero();
					break;
				case "2":
					pesquisanimacao();
					break;
				case "3":
					pesquisaNumax();
					break;
				case "4":
					pesquisaano();
					break;
				default:
					throw new ArgumentOutOfRangeException();
			}
		}

	}
}