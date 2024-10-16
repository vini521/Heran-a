using Herannca;

//Cachorro cachorro1 = new Cachorro
//{
//    Nome = "Noah biju da Silva",
//    Idade = 3,
//    TipoAlimentacao = "Carnivoro",
//    Raca = "Lulu da palmerania",
//    BuscaObjetos = false
//};

//Console.WriteLine($"Nome: {cachorro1.Nome}, Idade: {cachorro1.Idade} Tipo de Alimentação: {cachorro1.TipoAlimentacao}, É da Raça {cachorro1.Raca}, e busca objetos: {cachorro1.BuscaObjetos}");

//Console.ReadKey();

//Gato gato = new Gato
//{
//    Especie = "Gato",
//    Alimento = "Ração",
//    Mamifero = true
//};
//Console.WriteLine($"A especie do primeiro animal é {gato.Especie},\nSeu alimento é {gato.Alimento}\nEle é mamifero? {gato.Mamifero}");
//gato.SomEmitido();

//Porco porco = new Porco
//{
//    Especie = "Porco",
//    Alimento = "Lavagem",
//    Mamifero = true
//};
//Console.WriteLine($"\nA especie do segundo animal é {porco.Especie},\nSeu alimento é {porco.Alimento}\nEle é mamifero? {porco.Mamifero}");
//porco.SomEmitido();

//Capivara capi = new Capivara
//{
//    Especie = "Porco",
//    Alimento = "Lavagem",
//    Mamifero = true
//};
//Console.WriteLine($"\nA especie do tereceiro animal é {capi.Especie},\nSeu alimento é {capi.Alimento}\nEle é mamifero? {capi.Mamifero}");
//capi.SomEmitido();

//Console.ReadKey();

//ContaCorrente conta1 = new ContaCorrente
//{
//    Banco = "Banco do Brasil",
//    Agencia = "Brotas",
//    Conta = "Poupança",
//    Saldo = 5700,
//    Limite = 500,
//};
//Console.WriteLine($"Seu banco é: {conta1.Banco}, sua agencia é: {conta1.Agencia}, sua conta é: {conta1.Conta}, seu saldo é de: {conta1.Saldo}, seu limite é de: {conta1.Limite}.");


//ContaCorrente conta2 = new ContaCorrente
//{
//    Banco = "Nubank",
//    Agencia = "Brotas",
//    Conta = "Corrente",
//    Saldo = 8000,
//    Limite = 3000,
//};
//Console.WriteLine($"Seu banco é: {conta2.Banco}, sua agencia é: {conta2.Agencia}, sua conta é: {conta2.Conta}, seu saldo é de: {conta2.Saldo}, seu limite é de: {conta2.Limite}.");

//ContaCorrente conta3 = new ContaCorrente
//{
//    Banco = "Sicred",
//    Agencia = "Brotas",
//    Conta = "Corrente",
//    Saldo = 10700,
//    Limite = 5000,
//};
//Console.WriteLine($"Seu banco é: {conta3.Banco}, sua agencia é: {conta3.Agencia}, sua conta é: {conta3.Conta}, seu saldo é de: {conta3.Saldo}, seu limite é de: {conta3.Limite}.");
//Console.ReadKey();

Funcionario fun1 = new Funcionario { Nome = "Vini", Idade = 30 };
Funcionario fun2 = new Funcionario { Nome = "Vini", Idade = 30 };
//chamando o metodo envelhecer 
fun1.Envelhecer(19); //Somar a idade que você passou para a variavelfun1 e soma com mais 10

Console.WriteLine($"Nome: {fun1.Nome}, Idade: {fun1.Idade} você envelheceu 19 anos");


fun2.Rejuvenecer(15);//subtraindo a idade que você passou para a variavelfun1 e soma com mais 10


Console.WriteLine($"Nome: {fun2.Nome}, Idade: {fun2.Idade} você rejuveneceu 15 anos");


Funcionario fun3 = new Funcionario { Nome = "Toto", Idade = 24 };
Funcionario fun4 = new Funcionario { Nome = "Toto", Idade = 24 };
//chamando o metodo envelhecer 
fun3.Envelhecer(14); //Somar a idade que você passou para a variavelfun1 e soma com mais 10

Console.WriteLine($"Nome: {fun3.Nome}, Idade: {fun3.Idade} você envelheceu 14 anos");


fun4.Rejuvenecer(12);//subtraindo a idade que você passou para a variavelfun1 e soma com mais 10


Console.WriteLine($"Nome: {fun4.Nome}, Idade: {fun4.Idade} você rejuveneceu 12 anos");

Funcionario fun5 = new Funcionario { Nome = "Lívia", Idade = 17 };
Funcionario fun6 = new Funcionario { Nome = "Lívia", Idade = 17 };
//chamando o metodo envelhecer 
fun5.Envelhecer(6); //Somar a idade que você passou para a variavelfun1 e soma com mais 10

Console.WriteLine($"Nome: {fun5.Nome}, Idade: {fun5.Idade} você envelheceu 6 anos");


fun6.Rejuvenecer(9);//subtraindo a idade que você passou para a variavelfun1 e soma com mais 10


Console.WriteLine($"Nome: {fun6.Nome}, Idade: {fun6.Idade} você rejuveneceu 9 anos");

Funcionario fun7 = new Funcionario { Nome = "Cauã", Idade = 18 };
Funcionario fun8 = new Funcionario { Nome = "Cauã", Idade = 18 };
//chamando o metodo envelhecer 
fun7.Envelhecer(7); //Somar a idade que você passou para a variavelfun1 e soma com mais 10

Console.WriteLine($"Nome: {fun7.Nome}, Idade: {fun7.Idade} você envelheceu 7 anos");


fun8.Rejuvenecer(6);//subtraindo a idade que você passou para a variavelfun1 e soma com mais 10


Console.WriteLine($"Nome: {fun8.Nome}, Idade: {fun8.Idade} você rejuveneceu 6 anos");

Funcionario fun9 = new Funcionario { Nome = "Malu", Idade = 19 };
Funcionario fun10 = new Funcionario { Nome = "Malu", Idade = 19 };
//chamando o metodo envelhecer 
fun9.Envelhecer(5); //Somar a idade que você passou para a variavelfun1 e soma com mais 10

Console.WriteLine($"Nome: {fun9.Nome}, Idade: {fun9.Idade} você envelheceu 5 anos");


fun10.Rejuvenecer(2);//subtraindo a idade que você passou para a variavelfun1 e soma com mais 10


Console.WriteLine($"Nome: {fun10.Nome}, Idade: {fun10.Idade} você rejuveneceu 2 anos");


Console.ReadKey();