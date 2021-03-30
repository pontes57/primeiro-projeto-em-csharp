using System;

namespace DIO.Series
{
    public class Serie : EntidadeBase
    {
        // Atributos
		private Genero Genero { get; set; }
		private string Titulo { get; set; }
		private string Descricao { get; set; }
		private int Ano { get; set; }
        private bool Excluido {get; set;}
		private int NumEpi {get; set;}
		private bool isanimacao {get; set;}

        // Métodos
		public Serie(int id, Genero genero, string titulo, string descricao, int ano,int NumEpi,bool isanimacao)
		{
			this.Id = id;
			this.Genero = genero;
			this.Titulo = titulo;
			this.Descricao = descricao;
			this.Ano = ano;
            this.Excluido = false;
			this.NumEpi=NumEpi;
			this.isanimacao=isanimacao;
		}

        public override string ToString()
		{
			// Environment.NewLine https://docs.microsoft.com/en-us/dotnet/api/system.environment.newline?view=netcore-3.1
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Titulo: " + this.Titulo + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Início: " + this.Ano + Environment.NewLine;
			retorno += "Numero de episodios da serie: " + this.NumEpi + Environment.NewLine;
			retorno += "e' animacao: " + this.isanimacao + Environment.NewLine;
            retorno += "Excluido: " + this.Excluido;
			return retorno;
		}

        public string retornaTitulo()
		{
			return this.Titulo;
		}

		public int retornaano(){
			return this.Ano;
		}

		public int retornagenero(){
			return (int)Genero;
		}

		public int retornaId()
		{
			return this.Id;
		}
        public bool retornaExcluido()
		{
			return this.Excluido;
		}
        public void Excluir() {
            this.Excluido = true;
        }
		public int retornaNumEpi()
		{
			return this.NumEpi;
		}
		 public bool retornaisanimacao()
		{
			return this.isanimacao;
		}
    }
}