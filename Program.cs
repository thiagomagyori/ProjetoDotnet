//fazendo uso da classes
using Projetoc_.Classes;


List<Pessoafisica> listaPf = new List<Pessoafisica>();
string? opcao;
Pessoafisica metodosPj = new Pessoafisica();

Console.Clear();
Console.ResetColor();

Utils.BarraCarregamento("Inicializando");

//Menu de boas vindas

Console.WriteLine(@$"
 ------------------------------------------------------------------
 |                     Sistema de Cadastro                        |
 ------------------------------------------------------------------
");

Thread.Sleep(1000);
Console.Clear();


//Menu opções Geral

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
    // Console.WriteLine($" O texto digitado foi: {digitacao}");

    switch (opcao)
    {
        case "1":

            string? opcaoPf;


            //Menu opções para pessoas físicas

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


                //Input de dados para pessoa física


                switch (opcaoPf)
                {
                    case "1":
                          Pessoafisica novaPf = new Pessoafisica();
                        Endereco novoEndPf = new Endereco();

                        novaPf.nome = "Turma16";

                        Console.Clear();

                        Console.WriteLine(@$"
                        Foi inserido o nome 'Turma16' no atributo nome da Classe Pessoa Física,
                        O arquivo: Turma16.txt foi criado com êxito!
                        Tecle 'ENTER' para continuar.
                        ");

                        /*     bool dataValida;
                            do
                            {
                                Console.WriteLine($"Digite a data de nascimento (Ex: DD/MM/AAAA), 'ENTER' para continuar.");
                                string? dataNascimento = Console.ReadLine();
                                dataValida = novaPf.ValidarDataNasc(dataNascimento);
                                if (dataValida == true)
                                {
                                    DateTime.TryParse(dataNascimento, out DateTime dataConvertida);
                                    novaPf.dataNasc = dataConvertida;
                                }
                                else
                                {
                                    Console.WriteLine($"Erro; Data inválida, digite um valor válido. Tecle Enter pra continuar");
                                    Console.ReadLine();
                                }
                            } while (dataValida == false);
                            Console.WriteLine($"Digite o CPF da Pessoa Física, tecle 'ENTER' para continuar.");
                            novaPf.cpf = Console.ReadLine();
                            Console.WriteLine($"Digite o Rendimento da Pessoa Física, tecle 'ENTER' para continuar.");
                            novaPf.rendimento = float.Parse(Console.ReadLine());
                            Console.WriteLine($"Digite o nome da rua da Pessoa Física, tecle 'ENTER' para continuar.");
                            novoEndPf.logradouro = Console.ReadLine();
                            Console.WriteLine($"Digite o numero do endereço da Pessoa Física, tecle 'ENTER' para continuar.");
                            novoEndPf.numero = int.Parse(Console.ReadLine());
                            Console.WriteLine($"Digite o complemento, tecle 'ENTER' para continuar.");
                            novoEndPf.complemento = Console.ReadLine();
                            Console.WriteLine($"Este endereço é Comercial? Digite S ou N ?");
                            string endCom = Console.ReadLine().ToUpper();
                            if (endCom == "S")
                            {
                                novoEndPf.endComercial = true;
                            }
                            else
                            {
                                novoEndPf.endComercial = false;
                            }
                            novaPf.endereco = novoEndPf;
                            listaPf.Add(novaPf); */

                        /* 
                                                StreamWriter sw = new StreamWriter(novaPf.nome);
                                                sw.WriteLine(novaPf.nome);
                                                sw.Close(); */

                        using (StreamWriter sw = new StreamWriter($"{novaPf.nome}.txt"))
                        {
                            sw.WriteLine(novaPf.nome);
                        }
                        //Console.WriteLine($"Objeto adicionado na lista!");
                        //Thread.Sleep(6000);
                        Console.ReadLine();
                        break;

                    case "2":
                        
                                               Console.Clear();
                                                /* if (listaPf.Count > 0)
                                                {
                                                    foreach (PessoaFisica cadaPessoa in listaPf)
                                                    {
                                                        Console.WriteLine(@$"
                                                    NOME: {cadaPessoa.nome}
                                                    LOGRADOURO: {cadaPessoa.endereco.logradouro}, NUMERO {cadaPessoa.endereco.numero}, COMPLEM. {cadaPessoa.endereco.complemento}
                                                    RENDIMENTO MENSAL.: {cadaPessoa.rendimento.ToString("C")}
                                                    IMPOSTO A PAGAR: {cadaPessoa.CalcularImposto(cadaPessoa.rendimento).ToString("C")}
                                                    DATA NASC.: {cadaPessoa.dataNasc.ToString("d")}
                                                    ");
                                                        Console.WriteLine($"Tecle Enter para continuar a lista");
                                                        Console.ReadLine();
                                                        Console.Clear();
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine($"Lista vazia, cadastre uma nova Pessoa Física.");
                                                    Thread.Sleep(4000);
                                                    Console.Clear();
                                                } */

                       using (StreamReader sr = new StreamReader("Turma16.txt"))
                        {
                            string? linha;
                            while ((linha = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(@$"
                                
                                O Conteúdo do arquivo Turma16.txt é: 
                                
                                {linha}
                                
                                Fim do arquivo.
                                ");
                            }
                            Console.WriteLine($"Tecle Enter para o continuar");
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




            break;
        // Menu opções para pessoa jurídica

        case "2":
           string? opcaoPj;

            do
            {
                Console.Clear();
                Console.WriteLine(@$"
 ------------------------------------------------------------------
 |                 Escolha uma opção abaixo:                      |
 ------------------------------------------------------------------
 |                   1 - Cadastrar Pessoa Jurídica para Arquivo   |
 |                   2 - Listar Pessoa Jurídica do Arquivo        |
 |                                                                |
 |                   0 - Volta ao menu anterior                   |   
 ------------------------------------------------------------------
");

                opcaoPj = Console.ReadLine();

                switch (opcaoPj)
                {
                    case "1":

                        Pessoajuritica novaPjIn = new Pessoajuritica();
                        Endereco novoEndPjIn = new Endereco();

                        novaPjIn.razaoSocial = "Deves system";
                        novaPjIn.cnpj = "31.876.411/0001-79";
                        novaPjIn.rendimento = 200000.00f;

                        novoEndPjIn.logradouro = "Rua Copacabana";
                        novoEndPjIn.numero = 354;
                        novoEndPjIn.complemento = "Empresa Senai Informatica";
                        novoEndPjIn.endComercial = true;

                        novaPjIn.endereco = novoEndPjIn;

                        metodosPj.Inserir(novaPjIn);


                        Console.WriteLine(@$"
            Nome da Razão Social: {novaPjIn.razaoSocial}
            Endereço: {novoEndPjIn.logradouro}, {novoEndPjIn.numero}
            CNPJ: {novaPjIn.cnpj} - Valido: {novaPjIn.ValidarCnpj(novaPjIn.cnpj)}
            
            *** Valores adicionados no arquivo Database/PessoaJuridica.csv ***
            *** Tecle 'Enter' para continuar!  ***
            ");
                        Console.ReadLine();

                        break;

                    case "2":

                        Pessoajuritica novaPj = new Pessoajuritica();
                        Endereco novoEndPj = new Endereco();

                        List<Pessoajuritica> ListaPj = metodosPj.LerArquivo();

                        Console.Clear();
                        Console.WriteLine($"Lendo dados do Arquivo");
                        Thread.Sleep(4000);
                        Console.Clear();

                        foreach (var cadaItem in ListaPj)
                        {
                            Console.WriteLine(@$"
                        Nome: {cadaItem.nome}
                        Razão Social: {cadaItem.razaoSocial}
                        CNPJ: {cadaItem.cnpj}
                        ");

                            Console.WriteLine($"Tecle Enter para Continuar");
                            Console.ReadLine();
                            Console.Clear();
                        }

                        Console.WriteLine($"Lista finalizada.");
                        Thread.Sleep(3000);
                        Console.Clear();

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


            } while (opcaoPj != "0");


            Console.WriteLine($"Pessoa Jurídica Selecionada");
            break;

            
        case "0":

            break;


        default:
            Console.WriteLine($"Valor não encontrado, digite um valor correto (1, 2 ou 0)");
            Thread.Sleep(4000);
            break;
    }

    Console.Clear();
} while (opcao != "0");

Utils.BarraCarregamento("Finalizando");

//Console.Clear();














/*

//metodo construtor instanciando as classes
Pessoafisica novaPessoafisica = new Pessoafisica();
Endereco novoEnderecoPf = new Endereco();

//Atribuição de valores
novaPessoafisica.nome = "Thiago";
novaPessoafisica.cpf = 494745638;
novaPessoafisica.dataNac = new DateTime(2008,02,13);
novaPessoafisica.endereco = novoEnderecoPf; //atribuindo a classe abistrata
novaPessoafisica.rendimento = 4000.00f; // para força ele a converter para float



//Atribuição de valores endereço
novoEnderecoPf.logradouro = "Rua dos bamdeirantes";
novoEnderecoPf.numero = 7;
novoEnderecoPf.complemento = "Rua sem saída";
novoEnderecoPf.endComercial = true;
*/

/*
//imprimindo
Console.WriteLine(novaPessoafisica.nome);
Console.WriteLine(novaPessoafisica.cpf);
Console.WriteLine(novaPessoafisica.dataNac);
Console.WriteLine(novaPessoafisica.endereco);
Console.WriteLine(novaPessoafisica.rendimento);



//concatenação
Console.WriteLine("NOME: " + novaPessoafisica.nome);
Console.WriteLine("CPF: " + novaPessoafisica.cpf);
Console.WriteLine("DATA NACIMENTO: " + novaPessoafisica.dataNac);
Console.WriteLine("ENDEREÇO: " + novaPessoafisica.endereco);
Console.WriteLine("RENDIMENTO: " + novaPessoafisica.rendimento);


//interpolação
Console.WriteLine($"NOME: {novaPessoafisica.nome}");
Console.WriteLine($"CPF: {novaPessoafisica.cpf}");
Console.WriteLine($"DATA NACIMENTO: {novaPessoafisica.dataNac}");
Console.WriteLine($"ENDEREÇO: {novaPessoafisica.endereco}");
Console.WriteLine($"RENDIMENTO: {novaPessoafisica.rendimento}");


Console.WriteLine(novaPessoafisica.CalcularImposto(novaPessoafisica.rendimento));

float valor = novaPessoajuridica.rendimento = 16600;
Console.WriteLine(novaPessoajuridica.CalcularImposto(valor));*/

/*temos como formatar os valores a serem apresentados */


                                      //começa no formato americano  month-day-year (mês-dia-ano).
//DateTime dataNacimento = new DateTime (1992,02,13);
/*
DateTime date1 = DateTime.Now;
DateTime date2 = DateTime.UtcNow;
DateTime date3 = DateTime.Today;

 var result = date3 - dataNacimento;



 var idade = result.TotalDays/365;

 if(idade > 30 ){
    Console.WriteLine("Parabéns você tem disconto no seu seguro de carro e moto");
 }
 
Console.WriteLine(date2);
Console.WriteLine(date3);

Console.WriteLine(novaPessoafisica.ValidarDate(dataNac));*/

//Console.WriteLine(novaPessoafisica.ValidarDate("13/02/1992"));

/*
Console.WriteLine(@$"

Nome: {novaPessoafisica.nome}
Endereço: {novoEnderecoPf.logradouro}, {novoEnderecoPf.numero}
Vai ter deconto no seguro: {novaPessoafisica.ValidarDate(novaPessoafisica.dataNac)}
");*/


//============================PJ===================================
/*
Pessoajuritica novaPessoajuridica = new Pessoajuritica();
Endereco novoEnderecoPj = new Endereco();





//CHAMANDO A FUNÇÃO E PASSANDOUM VALOR PARA ELA 
//Console.WriteLine(novaPessoajuridica.Validcnpj("34.865.466/0001-79"));
//metodo construtor instanciando as classes

//Atribuição de valores
novaPessoajuridica.razaoSocial = "Devs System";
novaPessoajuridica.cnpj = "34.865.466/0001--79";
novaPessoajuridica.rendimento = 4000.00f; // para força ele a converter para float




//Atribuição de valores endereço
novoEnderecoPj.logradouro = "Rua tira dentes";
novoEnderecoPj.numero = 86;
novoEnderecoPj.complemento = "Av Principal";
novoEnderecoPj.endComercial = true;

novaPessoajuridica.endereco = novoEnderecoPj;

Console.WriteLine(@$"

Razão Social: {novaPessoajuridica.razaoSocial}
Endereço: {novoEnderecoPj.logradouro}, {novoEnderecoPj.numero}
CNPJ: {novaPessoajuridica.cnpj} - Valido: {novaPessoajuridica.Validcnpj(novaPessoajuridica.cnpj)}
");
*/
