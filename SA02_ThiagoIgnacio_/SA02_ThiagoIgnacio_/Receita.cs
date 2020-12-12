using System;
using System.Collections.Generic;
using System.Text;

namespace SA02_ThiagoIgnacio_
{
    class Receita
    {
        public string NomeReceita { get; set; }
        public int Codigo { get; set; }
        public string TempoPreparacao { get; set; }
        public int GrauDificuldade { get; set; }
        public int NumPessoas { get; set; }
        public string Categoria { get; set; }
        public string Descricao { get; set; }
        public string Ingredientes { get; set; }
        public double Preco { get; set; }


        public Receita(string nomeReceita, int codigo, string tempoPreparacao,
            int grauDificuldade, int numPessoas, string categoria,
            string descricao, string ingredientes, double preco)
        {
            NomeReceita = nomeReceita;
            Codigo = codigo;
            TempoPreparacao = tempoPreparacao;
            GrauDificuldade = grauDificuldade;
            NumPessoas = numPessoas;
            Categoria = categoria;
            Descricao = descricao;
            Ingredientes = ingredientes;
            Preco = preco;
        }

        public override string ToString()
        {
            return "Nome: " + NomeReceita +
                "\nCodigo: " + Codigo +
                "\nTempo de Preparação: " + TempoPreparacao +
                "\nGrau de Dificuldade: " + GrauDificuldade +
                "\nNumero de Pessoas: " + NumPessoas +
                "\nCategoria: " + Categoria +
                "\nDescrição: " + Descricao +
                "\nIngredientes: " + Ingredientes +
                "\nPreco: R$ " + Preco;
        }
    }
}
