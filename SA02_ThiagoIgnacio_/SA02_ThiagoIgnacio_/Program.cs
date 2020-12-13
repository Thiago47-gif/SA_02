using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace SA02_ThiagoIgnacio_
{
    class Program
    {
        static void Main(string[] args)
        {
            Receita[] receita = new Receita[30]; //Vetor - Cadastrar, Editar, Eliminar e Exibir Receitas Existentes
            List<Receita> receitas = new List<Receita>(); //Lista - Consulta de Receitas

            string menu; //Voltar ciclo de repetição do menu (do while)
            string voltarEdicao; //Voltar ciclo de repetição "editar receita" (do while)
            int cont = 0; //Contador de receitas cadastradas
            

            do //Inicializando Ciclo de repetição
            {
                Console.WriteLine("    ****************************************************");
                Console.WriteLine("    *                   MENU PRINCIPAL                 *");
                Console.WriteLine("    *                                                  *");
                Console.WriteLine("    *                1- CADASTRAR RECEITAS             *");
                Console.WriteLine("    *                2- EDITAR RECEITAS                *");
                Console.WriteLine("    *                3- ELIMINAR RECEITAS              *");
                Console.WriteLine("    *                4- RECEITAS CADASTRADAS           *");
                Console.WriteLine("    *                5- CONSULTA                       *");
                Console.WriteLine("    ****************************************************\n\n");

                Console.Write("Digite a opção desejada no menu:  ");
                int respostaMenu = int.Parse(Console.ReadLine()); //Opção do menu

                Console.Clear(); //Limpar tela

                Console.WriteLine();
                
                switch (respostaMenu) //Decisão do menu
                {
                    case 1: //Decisão
                        Console.WriteLine("    ==================================");
                        Console.WriteLine("    ******* CADASTRAR RECEITAS *******");
                        Console.WriteLine("    ==================================\n\n\n");


                        Console.Write("Quantas Receitas deseja adicionar: ");
                        int numReceitas = int.Parse(Console.ReadLine()); //Quantidade de receitas para cadastrar

                        Console.Clear(); //Limpar tela

                        for (int i = 0; i < numReceitas; i++) //Ciclo de repetição de quantas vezes será feito o cadastro de receitas
                        {
                            Console.WriteLine($"\n\nReceita #{i+1} : ");
                            
                            Console.Write("\n\nNome: ");
                            string nomeReceita = Console.ReadLine();
                            
                            Console.Write("\nCódigo: ");
                            int codigo = int.Parse(Console.ReadLine());
                            
                            Console.Write("\nTempo de Preparação(em minutos): ");
                            string tempoPreparacao = Console.ReadLine();
                            
                            Console.Write("\nGrau de Dificuldade: \n");
                            
                            Console.WriteLine("1-Fácil");
                            Console.WriteLine("2-Médio");
                            Console.WriteLine("3-Difícil");
                            Console.WriteLine("4-Muito Difícil");
                            
                            Console.Write("\nOpção: ");
                            int grauDificuldade = int.Parse(Console.ReadLine());
                            
                            Console.Write("\n\nNúmero de Pessoas: ");
                            int numPessoas = int.Parse(Console.ReadLine());

                            Console.Write("\nCategoria: \n");

                            Console.WriteLine("1-Doce");
                            Console.WriteLine("2-Salgado");
                            Console.WriteLine("3-Massa");

                            Console.Write("\nOpção: ");
                            int categoria = int.Parse(Console.ReadLine());

                            Console.Write("\nDescrição: ");
                            string descricao = Console.ReadLine();
                            
                            Console.Write("\nIngredientes: ");
                            string ingredientes = Console.ReadLine();
                            
                            Console.Write("\nPreco: R$ ");
                            double preco = double.Parse(Console.ReadLine());
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine($"    ******* Receita '{nomeReceita}' Cadastrada ********");
                            Console.WriteLine();

                            receita[i] = new Receita(nomeReceita, codigo, tempoPreparacao, //Vetor recebendo os valores inseridos
                                                 grauDificuldade, numPessoas, categoria,
                                                 descricao, ingredientes, preco);

                            receitas.Add(new Receita(nomeReceita, codigo, tempoPreparacao, //Lista recebendo os valores inseridos
                                                     grauDificuldade, numPessoas, categoria,
                                                     descricao, ingredientes, preco));

                            cont = cont + 1; //Contador de receitas cadastradas

                            Console.ReadKey(); //Chave vazia
                            Console.Clear(); //Limpar tela

                        }

                        break; //Fim Decisão

                    case 2: //Decisão
                        Console.WriteLine("    ===============================");
                        Console.WriteLine("    ******* EDITAR RECEITAS *******");
                        Console.WriteLine("    ===============================\n\n\n");

                        do //Inicializando Ciclo de repetição
                        {
                            Console.Write("Diga o código da receita que deseja editar: ");
                            int codEditar = int.Parse(Console.ReadLine()); //Inserir codigo para consulta

                            Console.Clear(); //Limpar tela

                            for (int i = 0; i < cont; i++) //Ciclo de repetição de quantas receitas foram o cadastradas
                            {

                                if (receita[i].Codigo == codEditar) //Identificar se o codigo existe para ser editado
                                {
                                    receita[i] = null; //Apagar dados da receita do vetor
                                    receitas.Remove(receitas[i]); //Apagar dados da receita da lista

                                    //Editar receita
                                    Console.WriteLine($"\n\nReceita #{i+1} : ");

                                    Console.Write("\n\nNome: ");
                                    string nomeReceita = Console.ReadLine();

                                    Console.Write("\nCódigo: ");
                                    int codigo = int.Parse(Console.ReadLine());

                                    Console.Write("\nTempo de Preparação(em minutos): ");
                                    string tempoPreparacao = Console.ReadLine();

                                    Console.Write("\nGrau de Dificuldade: \n");

                                    Console.WriteLine("1-Fácil");
                                    Console.WriteLine("2-Médio");
                                    Console.WriteLine("3-Difícil");
                                    Console.WriteLine("4-Muito Difícil");

                                    Console.Write("\nOpção: ");
                                    int grauDificuldade = int.Parse(Console.ReadLine());

                                    Console.Write("\n\nNúmero de Pessoas: ");
                                    int numPessoas = int.Parse(Console.ReadLine());

                                    Console.Write("\nCategoria: \n");

                                    Console.WriteLine("1-Doce");
                                    Console.WriteLine("2-Salgado");
                                    Console.WriteLine("3-Massa");

                                    Console.Write("\nOpção: ");
                                    int categoria = int.Parse(Console.ReadLine());

                                    Console.Write("\nDescrição: ");
                                    string descricao = Console.ReadLine();

                                    Console.Write("\nIngredientes: ");
                                    string ingredientes = Console.ReadLine();

                                    Console.Write("\nPreco: R$ ");
                                    double preco = double.Parse(Console.ReadLine());

                                    
                                    Console.WriteLine("\n\n    ============================================");
                                    Console.WriteLine($"    ******* Receita Editada Com Sucesso ********");
                                    Console.WriteLine("    ============================================\n\n");

                                    receitas.Add(new Receita(nomeReceita, codigo, tempoPreparacao, //Vetor recebendo os valores inseridos
                                                     grauDificuldade, numPessoas, categoria,
                                                     descricao, ingredientes, preco));

                                    receita[i] = new Receita(nomeReceita, codigo, tempoPreparacao, //Lista recebendo os valores inseridos
                                                         grauDificuldade, numPessoas, categoria,
                                                         descricao, ingredientes, preco);

                                    

                                    Console.ReadKey(); //Chave vazia
                                    Console.Clear(); //Limpar tela

                                }


                            }
                            Console.Write("\n\nDeseja Editar mais alguma ? ");
                            voltarEdicao = Console.ReadLine(); //Voltar ciclo de repetição "editar receita" (do while)
                        }
                        while (voltarEdicao == "sim" || voltarEdicao == "SIM" || voltarEdicao == "Sim"); //Voltar ciclo de repetição 

                        break; //Fim Decisão

                    case 3: //Decisão
                        Console.WriteLine("    =================================");
                        Console.WriteLine("    ******* ELIMINAR RECEITAS *******");
                        Console.WriteLine("    =================================\n\n\n");

                            Console.Write("Diga o código da receita que deseja eliminar: ");
                            int codEliminar = int.Parse(Console.ReadLine()); //Inserir codigo para consulta

                        Console.Clear(); //Limpar tela

                        for (int i = 0; i < cont; i++) //Ciclo de repetição de quantas receitas foram o cadastradas
                        {
                            if (receita[i].Codigo == codEliminar) //Identificar se o codigo existe para ser eliminado
                            {
                                Console.WriteLine("\n    *******RECEITA DE NOME " + receita[i].NomeReceita + " APAGADA COM SUCESSO*******");

                                Console.ReadKey(); //Chave vazia
                                Console.Clear(); //Limpar tela

                                receita[i] = null; //Apagar dados da receita do vetor
                                receitas.Remove(receitas[i]); //Apagar dados da receita da lista
                            }


                        }
                            

                        break; //Fim Decisão

                    case 4: //Decisão
                        Console.WriteLine("    ====================================");
                        Console.WriteLine("    ******* RECEITAS CADASTRADAS *******");
                        Console.WriteLine("    ====================================\n\n");

                        foreach (Receita i in receita) //Estrutura de repetição
                        {
                            Console.WriteLine($"{i}\n");
                        }

                        Console.ReadKey(); //Chave vazia

                        break; //Fim Decisão

                    case 5: //Decisão

                        Console.WriteLine("    ==============================");
                        Console.WriteLine("    ********** CONSULTAS *********");
                        Console.WriteLine("    ==============================\n\n\n");
                         
                        string resp;
                        do //Inicializando Ciclo de repetição
                        {
                            Console.WriteLine("Opcões de consulta:\n");

                            Console.WriteLine("1-Listar receitas por dificuldade;");
                            Console.WriteLine("2-Listar receitas por categoria;");
                            Console.WriteLine("3-Listar receitas por tempo de preparação;");
                            Console.WriteLine("4-Valor estimado da receita;\n");

                            Console.Write("Digite a opção desejada para fazer a consulta da receita: ");
                            int opcaoConsulta = int.Parse(Console.ReadLine()); //Opção do sub-menu

                            Console.Clear(); //Limpar tela

                            switch (opcaoConsulta) //Decisão do sub-menu
                            {
                                case 1: //Decisão
                                    Console.WriteLine("    =============================================");
                                    Console.WriteLine("    ********** RECEITAS POR DIFICULDADE *********");
                                    Console.WriteLine("    =============================================\n\n");

                                    Console.Write("Grau de Dificuldade Existente: \n");
                                    Console.WriteLine("1-Fácil");
                                    Console.WriteLine("2-Médio");
                                    Console.WriteLine("3-Difícil");
                                    Console.WriteLine("4-Muito Difícil\n\n");
                                    
                                     
                                    Console.ReadKey(); //Chave vazia

                                    List<Receita> receitasDificuldade = (from r in receitas //Ordem Crecente do grau de dificuldade
                                                                         orderby r.GrauDificuldade ascending
                                                                         select r).ToList();

                                    foreach (Receita j in receitasDificuldade) //Estrutura de repetição
                                    {
                                        Console.WriteLine($"{j}\n\n");

                                    }

                                    Console.ReadKey(); //Chave vazia
                                    Console.Clear(); //Limpar tela

                                    break; //Fim Decisão

                                case 2: //Decisão

                                    Console.WriteLine("    =============================================");
                                    Console.WriteLine("    *********** RECEITAS POR CATEGORIA **********");
                                    Console.WriteLine("    =============================================\n\n");

                                    Console.Write("Categorias: \n");

                                    Console.WriteLine("1-Doce");
                                    Console.WriteLine("2-Salgado");
                                    Console.WriteLine("3-Massa\n\n");

                                    Console.ReadKey();

                                    List<Receita> receitasCategoria = (from j in receitas //Ordem Crecente das categorias
                                                                       orderby j.Categoria ascending
                                                                       select j).ToList();

                                    foreach (Receita j in receitasCategoria) //Estrutura de repetição
                                    {
                                        Console.WriteLine($"{j}\n\n");

                                    }

                                    Console.ReadKey(); //Chave vazia
                                    Console.Clear(); //Limpar tela

                                    break; //Fim Decisão

                                case 3: //Decisão

                                    Console.WriteLine("    =====================================================");
                                    Console.WriteLine("    ********** RECEITAS POR TEMPO DE PREPARAÇÃO *********");
                                    Console.WriteLine("    =====================================================\n\n");

                                    List<Receita> receitasTempoPreparacao = (from j in receitas //Ordem Crecente do tempo de preparação
                                                                             orderby j.TempoPreparacao ascending
                                                                             select j).ToList();

                                    foreach (Receita j in receitasTempoPreparacao) //Estrutura de repetição
                                    {
                                        Console.WriteLine($"{j}\n\n");

                                    }

                                    Console.ReadKey(); //Chave vazia
                                    Console.Clear(); //Limpar tela

                                    break; //Fim Decisão

                                case 4: //Decisão

                                    Console.WriteLine("    ================================================");
                                    Console.WriteLine("    ********** RECEITAS POR VALOR ESTIMADO *********");
                                    Console.WriteLine("    ================================================\n\n");

                                    List<Receita> receitasValor = (from j in receitas //Ordem Crecente dos valores
                                                                   orderby j.Preco ascending
                                                                   select j).ToList();

                                    foreach (Receita j in receitasValor) //Estrutura de repetição
                                    {
                                        Console.WriteLine($"{j}\n");

                                    }

                                    Console.ReadKey(); //Chave vazia
                                    Console.Clear(); //Limpar tela

                                    break; //Fim Decisão

                            }

                            Console.Write("\n\n Deseja fazer nova consulta ? ");
                            resp = Console.ReadLine(); //Voltar ciclo de repetição do menu (do while)

                            Console.Clear(); //Limpar tela
                        }
                        while (resp == "sim" || resp == "SIM" || resp == "Sim"); //Voltar ciclo de repetição 

                        break; // Fim Decisão



                }
                Console.Clear(); //Limpar tela

                Console.Write("\n\n  Digite 'm' para voltar ao menu ou 's' para sair do programa: ");
                menu = Console.ReadLine(); //Voltar ciclo de repetição do menu (do while)

                Console.Clear(); //Limpar tela
            }
            while (menu == "m"); //Voltar ciclo de repetição 

            Console.WriteLine("\n\n\n\n\n       =======================================");
            Console.WriteLine("       ********* PROGRAMA FINALIZADO *********");
            Console.WriteLine("       =======================================\n\n\n\n\n");
        }
    }
}
