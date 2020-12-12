﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace SA02_ThiagoIgnacio_
{
    class Program
    {
        static void Main(string[] args)
        {
            Receita[] receita = new Receita[4];
            List<Receita> receitas = new List<Receita>();

            string menu;
            string voltarEdicao;
            int cont = 0;
            string nomeReceita;

            do
            {
                Console.WriteLine("    ****************************************************");
                Console.WriteLine("    *                   MENU PRINCIPAL                 *");
                Console.WriteLine("    *                                                  *");
                Console.WriteLine("    *                1- CADASTRAR RECEITAS             *");
                Console.WriteLine("    *                2- EDITAR RECEITAS                *");
                Console.WriteLine("    *                3- ELIMINAR RECEITAS              *");
                Console.WriteLine("    *                4- RECEITAS CADASTRADAS           *");
                Console.WriteLine("    *                5- CONSULTA                       *");
                Console.WriteLine("    ****************************************************");
                Console.WriteLine();
                Console.WriteLine();

                Console.Write("Digite a opção desejada no menu:  ");
                int respostaMenu = int.Parse(Console.ReadLine());

                Console.ReadKey();
                Console.Clear();

                Console.WriteLine();
                Console.WriteLine();

                switch (respostaMenu)
                {
                    case 1:
                        Console.WriteLine("    ******* CADASTRAR RECEITAS *******");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();


                        Console.Write("Quantas Receitas deseja adicionar: ");
                        int numReceitas = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        for (int i = 0; i < numReceitas; i++)
                        {
                            Console.WriteLine("Receita #" + i + ": ");
                            Console.WriteLine();
                            Console.Write("Nome: ");
                            nomeReceita = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Código: ");
                            int codigo = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.Write("Tempo de Preparação(em minutos): ");
                            string tempoPreparacao = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Grau de Dificuldade: ");
                            Console.WriteLine();
                            Console.WriteLine("1-Fácil");
                            Console.WriteLine("2-Médio");
                            Console.WriteLine("3-Difícil");
                            Console.WriteLine("4-Muito Difícil");
                            Console.WriteLine();
                            Console.Write("Opção: ");
                            int grauDificuldade = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.Write("Número de Pessoas: ");
                            int numPessoas = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.Write("Categoria: ");
                            string categoria = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Descrição: ");
                            string descricao = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Ingredientes: ");
                            string ingredientes = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Preco: R$ ");
                            double preco = double.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine($"        ******* Receita '{nomeReceita}' Cadastrada ********");
                            Console.WriteLine();
                            Console.WriteLine("__________________________________________________________________________________");
                            Console.WriteLine();
                            Console.WriteLine();

                            receita[i] = new Receita(nomeReceita, codigo, tempoPreparacao,
                                                 grauDificuldade, numPessoas, categoria,
                                                 descricao, ingredientes, preco);

                            receitas.Add(new Receita(nomeReceita, codigo, tempoPreparacao,
                                                     grauDificuldade, numPessoas, categoria,
                                                     descricao, ingredientes, preco));

                            cont = cont + 1;

                        }

                        break;

                    case 2:
                        Console.WriteLine("    ===============================");
                        Console.WriteLine("    ******* EDITAR RECEITAS *******");
                        Console.WriteLine("    ===============================");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();
                        do
                        {
                            Console.Write("Diga o código da receita que deseja editar: ");
                            int codEditar = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine();
                            for (int i = 0; i < cont; i++)
                            {

                                if (receita[i].Codigo == codEditar)
                                {
                                    receita[i] = null;
                                    Console.WriteLine("Receita #" + i + ": ");
                                    Console.WriteLine();
                                    Console.Write("Nome: ");
                                    nomeReceita = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.Write("Código: ");
                                    int codigo = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                    Console.Write("Tempo de Preparação(em minutos): ");
                                    string tempoPreparacao = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.Write("Grau de Dificuldade: ");
                                    Console.WriteLine();
                                    Console.WriteLine("1-Fácil");
                                    Console.WriteLine("2-Médio");
                                    Console.WriteLine("3-Difícil");
                                    Console.WriteLine("4-Muito Difícil");
                                    Console.WriteLine();
                                    Console.Write("Opção: ");
                                    int grauDificuldade = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                    Console.Write("Número de Pessoas: ");
                                    int numPessoas = int.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                    Console.Write("Categoria: ");
                                    string categoria = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.Write("Descrição: ");
                                    string descricao = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.Write("Ingredientes: ");
                                    string ingredientes = Console.ReadLine();
                                    Console.WriteLine();
                                    Console.Write("Preco: R$ ");
                                    double preco = double.Parse(Console.ReadLine());
                                    Console.WriteLine();
                                    Console.WriteLine();

                                    receita[i] = new Receita(nomeReceita, codigo, tempoPreparacao,
                                                         grauDificuldade, numPessoas, categoria,
                                                         descricao, ingredientes, preco);

                                    receitas.Add(new Receita(nomeReceita, codigo, tempoPreparacao,
                                                     grauDificuldade, numPessoas, categoria,
                                                     descricao, ingredientes, preco));
                                }


                            }
                            Console.Write("Deseja Editar mais alguma ? ");
                            voltarEdicao = Console.ReadLine();
                        }
                        while (voltarEdicao == "sim" || voltarEdicao == "SIM" || voltarEdicao == "Sim");

                        break;

                    case 3:
                        Console.WriteLine("    =================================");
                        Console.WriteLine("    ******* ELIMINAR RECEITAS *******");
                        Console.WriteLine("    =================================");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();

                        do
                        {
                            Console.Write("Diga o código da receita que deseja eliminar: ");
                            int codEliminar = int.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine();

                            for (int i = 0; i < cont; i++)
                            {

                                if (receita[i].Codigo == codEliminar)
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("    *******RECEITA DE NOME " + receita[i].NomeReceita + " APAGADA COM SUCESSO*******");
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    receita[i] = null;
                                }


                            }
                            Console.Write("Deseja Excluir mais alguma ? ");
                            voltarEdicao = Console.ReadLine();
                        }
                        while (voltarEdicao == "sim" || voltarEdicao == "SIM" || voltarEdicao == "Sim");

                        break;

                    case 4:
                        Console.WriteLine("    ====================================");
                        Console.WriteLine("    ******* RECEITAS CADASTRADAS *******");
                        Console.WriteLine("    ====================================");
                        Console.WriteLine();
                        Console.WriteLine();

                        foreach (Receita i in receita)
                        {
                            Console.WriteLine($"{i}\n");
                        }

                        break;

                    case 5:

                        Console.WriteLine("    ==============================");
                        Console.WriteLine("    ********** CONSULTAS *********");
                        Console.WriteLine("    ==============================");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();

                        string resp;
                        do
                        {
                            Console.WriteLine("Opcões de consulta:");
                            Console.WriteLine();
                            Console.WriteLine("1-Listar receitas por dificuldade;");
                            Console.WriteLine("2-Listar receitas por categoria;");
                            Console.WriteLine("3-Listar receitas por tempo de preparação;");
                            Console.WriteLine("4-Cotação de ingredientes;");
                            Console.WriteLine("5-Valor estimado da receita;");
                            Console.WriteLine();

                            Console.Write("Digite a opção desejada para fazer a consulta da receita: ");
                            int opcaoConsulta = int.Parse(Console.ReadLine());

                            switch (opcaoConsulta)
                            {
                                case 1:
                                    Console.WriteLine("    =============================================");
                                    Console.WriteLine("    ********** RECEITAS POR DIFICULDADE *********");
                                    Console.WriteLine("    =============================================");
                                    Console.WriteLine();
                                    Console.WriteLine();

                                    Console.Write("Grau de Dificuldade Existente: ");
                                    Console.WriteLine();
                                    Console.WriteLine("1-Fácil");
                                    Console.WriteLine("2-Médio");
                                    Console.WriteLine("3-Difícil");
                                    Console.WriteLine("4-Muito Difícil");
                                    Console.WriteLine();
                                    
                                     
                                    Console.ReadKey();
                                    Console.Clear(); 

                                    List<Receita> receitasDificuldade = (from r in receitas
                                                                         orderby r.GrauDificuldade ascending
                                                                         select r).ToList();

                                    foreach (Receita j in receitasDificuldade)
                                    {
                                        Console.WriteLine($"{j}\n");

                                    }




                                    break;
                            }



                            Console.Write("Deseja fazer nova consulta ? ");
                            resp = Console.ReadLine();
                        }
                        while (resp == "sim" || resp == "SIM" || resp == "Sim");

                        break;

                }
                Console.Write("Digite 'm' para voltar ao menu ou 's' para sair do programa: ");
                menu = Console.ReadLine();

            }
            while (menu == "m");
        }
    }
}