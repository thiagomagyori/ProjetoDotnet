//fazendo uso da classes
using Projetoc_.Classes;

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


//============================PJ===================================
//Pessoajuritica novaPessoajuridica = new Pessoajuritica();



Console.WriteLine(@$"

Nome: {novaPessoafisica.nome}
Endereço: {novoEnderecoPf.logradouro}, {novoEnderecoPf.numero}
Vai ter deconto no seguro: {novaPessoafisica.ValidarDate(novaPessoafisica.dataNac)}
");


