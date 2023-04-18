using T16CodBackEnd.Classes;

List<PessoaFisica> listaPf = new List<PessoaFisica>();
PessoaJuridica metodosPj = new PessoaJuridica();

string? opcao;

Console.ForegroundColor = ConsoleColor.DarkRed;
Utils.BarraCarregamento("Inicializando");

Console.Clear();
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Yellow;

Console.WriteLine(@$"
------------------------------------------------------------------
 |                     Sistema de Cadastro                        |
 ------------------------------------------------------------------
");

// Dormir/Sleep = 1 segundo / 1000 = 1 milisegundo
Thread.Sleep(2000);
Console.Clear();

do
{
    Console.WriteLine(@$"
 ------------------------------------------------------------------
 |                 Escolha uma opção abaixo:                      |
 ------------------------------------------------------------------
 |                   1 - Pessaoa Física                           |
 |                   2 - Pessaoa Jurídica                         |
 |                                                                |
 |                   0 - Exit                                     |   
 ------------------------------------------------------------------
");

    Console.ResetColor();


    Console.WriteLine($"Digite uma das opções acima e tecle 'Enter' !");
    opcao = Console.ReadLine();
    // Console.WriteLine($" O texto digitado foi: {opcao}");

    switch (opcao)
    {
        case "1":

            string? opcaoPf;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
 ------------------------------------------------------------------
 |                 Escolha uma opção abaixo:                      |
 ------------------------------------------------------------------
 |                   1 - Cadastrar Pessoa Física em Arquivo       |
 |                   2 - Listar Pessoa Física do Arquivo          |
 |                                                                |
 |                   0 - Volta ao menu anterior                   |   
 ------------------------------------------------------------------
");

                opcaoPf = Console.ReadLine();

                switch (opcaoPf)
                {
                    //metodo construtor
                    case "1":


                        PessoaFisica novaPF = new PessoaFisica();
                        Endereco novoEndPf = new Endereco();

                        Console.WriteLine($"Digite o nome da Pessoa Física, tecle 'Enter' para continuar.");
                        novaPF.nome = Console.ReadLine();

                        bool dataValida;
                        do
                        {
                            Console.WriteLine($"Digite a data de nascimento (DD/MM/AAAA), 'Enter' para continuar.");
                            string? dataNascimento = Console.ReadLine();

                            dataValida = novaPF.ValidarDataNasc(dataNascimento);


                            if (dataValida == true)
                            {
                                DateTime.TryParse(dataNascimento, out DateTime dataConvertida);
                                novaPF.dataNasc = dataConvertida;

                            }
                            else
                            {
                                Console.WriteLine($"Erro; Data Inválida, digite um valor válido. Tecle 'Enter' para continuar.");
                                Console.ReadLine();

                            }


                        } while (dataValida == false);



                        Console.WriteLine($"Digite o CPF da Pessoa Física, tecle 'Enter' para continuar.");
                        novaPF.cpf = Console.ReadLine();

                        Console.WriteLine($"Digite o rendimento da Pessoa Física, tecle 'Enter' para continuar.");
                        novaPF.rendimento = float.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o endereço da Pessoa Física, tecle 'Enter' para continuar.");
                        novoEndPf.logradouro = Console.ReadLine();

                        Console.WriteLine($"Digite o numero do endereço da Pessoa Física, tecle 'Enter' para continuar.");
                        novoEndPf.numero = int.Parse(Console.ReadLine());

                        Console.WriteLine($"Digite o complemento do endereço, tecle 'Enter' para continuar.");
                        novoEndPf.complemento = Console.ReadLine();

                        Console.WriteLine($"Este endereço é Comercial? Digite S ou N");
                        string endCom = Console.ReadLine().ToUpper();

                        if (endCom == "S")
                        {
                            novoEndPf.endComercial = true;
                        }
                        else
                        {
                            novoEndPf.endComercial = false;
                        }


                        novaPF.endereco = novoEndPf;

                        listaPf.Add(novaPF);

                        //StreamWriter sw = new StreamWriter(novaPF.nome);
                        //sw.WriteLine(novaPF.nome);
                        //sw.Close();

                        using (StreamWriter sw = new StreamWriter($"arquivo-{novaPF.nome}.txt"))
                        {
                            sw.WriteLine(novaPF.nome);

                        }



                        Console.WriteLine($"Objetivo adicionado na lista");
                        Thread.Sleep(3000);

                        break;


                    case "2":

                        Console.Clear();
                        if (listaPf.Count > 0)
                        {



                            foreach (PessoaFisica cadaPessoa in listaPf)
                            {
                                Console.WriteLine(@$"
                            
                            NOME: {cadaPessoa.nome}
                            DATA NASCIMENTO: {cadaPessoa.dataNasc.ToString("d")}
                            LOGRADOURO: {cadaPessoa.endereco.logradouro}, NUMERO {cadaPessoa.endereco.numero}, COMPLEMENTO {cadaPessoa.endereco.complemento}
                            RENDA MENSAL: {cadaPessoa.rendimento.ToString("C")}
                            IMPOSTO A PAGAR: {cadaPessoa.CalcularImposto(cadaPessoa.rendimento).ToString("C")}
                            
                            ");

                                Console.WriteLine($"Tecle 'Enter' para continuar a lista");
                                Console.ReadLine();
                                Console.Clear();
                            }

                        }
                        else
                        {
                            Console.WriteLine($"Lista vazia, cadastre uma nova pessoa física");
                            Thread.Sleep(4000);
                            Console.Clear();
                        }

                        using (StreamReader sr = new StreamReader("arquivo-Flavio.txt"))
                        {

                            string? linha;
                            while ((linha = sr.ReadLine()) != null)
                            {
                                Console.WriteLine($"{linha}");

                            }

                            Console.WriteLine($"Tecle 'Enter' para continuar");
                            Console.ReadLine();

                        }


                        break;

                    case "0":
                        Console.WriteLine($"Voltando ao menu anterior");
                        Thread.Sleep(2000);
                        break;

                    default:
                        Console.WriteLine($"Valor não encontrado, digite um valor correto (1, 2 ou 0)");
                        Thread.Sleep(4000);
                        break;
                }



            } while (opcaoPf != "0");


            // Console.WriteLine($"Pessoa Física Selecionada");


            //System.Console.WriteLine($"Tecle 'Enter' para continuar");
            //Console.ReadLine();
            break;

        case "2":
            Console.WriteLine($"Pessoa Jurídica Selecionada");

            PessoaJuridica novaPj = new PessoaJuridica();
            Endereco novoEndPj = new Endereco();

                        List<PessoaJuridica> ListaPj = metodosPj.LerArquivo();

            foreach (var cadaItem in ListaPj)
            {
                Console.WriteLine(@$"
                            Nome: {cadaItem.nome}
                            Razão Social: {cadaItem.razaoSocial}
                            CNPJ: {cadaItem.cnpj}
                           
                            ");
                Console.WriteLine($"Tecle 'Enter' para continuar");
                Console.ReadLine();
                Console.Clear();
                
            }
            break;

        case "0":
            Console.WriteLine($"Saindo do Sistema");
            break;
        default:
            Console.WriteLine($"Opção não encontrada. Digite uma das opções acima");
            break;
    }


    Thread.Sleep(2000);
    Console.Clear();

} while (opcao != "0");

Utils.BarraCarregamento("Finalizando");