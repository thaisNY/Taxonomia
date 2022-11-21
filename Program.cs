// See https://aka.ms/new-console-template for more information
using Taxonomia.Animal;

Console.WriteLine("Bem Vindo ao Meu Primeiro Sistema!!");
Console.WriteLine("Sistema Taxonomia!!");
while (true) 
{
    Console.WriteLine("Escolha o número do animal que você quer acessar \r\n");
    Console.WriteLine(" 1- Dragao, 2-Cachorro, 3-Peixe Dourado, 4- Coruja e 5 Sair do Sistema \r\n");
    int num = int.Parse(Console.ReadLine());
    if(num == 1)
    {
        Dragao Furiadaluz = new Dragao();
        Furiadaluz.Filo = "Reptil";
        Furiadaluz.Especie = "Dragao";
        Furiadaluz.Nome = "Furia da Luz";
        Furiadaluz.Idade = 125;
        Furiadaluz.Existencia = false;
        Console.WriteLine($" Filo: {Furiadaluz.Filo}");
        Console.WriteLine($" Especie: {Furiadaluz.Especie}");
        Console.WriteLine($" Nome {Furiadaluz.Nome}");
        Console.WriteLine($" Idade: {Furiadaluz.Idade}");
        Console.WriteLine($" Existencia: {Furiadaluz.Existencia}");
        Furiadaluz.Nascer();
        Furiadaluz.Crescer();
        Furiadaluz.Reproduzir();
        Furiadaluz.Morrer();
        continue;
    }
    else if (num == 2)
    {
       Cachorro Toto = new Cachorro();
        Toto.Filo = "Mamifero";
        Toto.Especie = "Cachorro";
        Toto.Nome = "Toto";
        Toto.Idade = 10;
        Toto.Existencia = true;
        Console.WriteLine($" Filo: {Toto.Filo}");
        Console.WriteLine($" Especie: {Toto.Especie}");
        Console.WriteLine($" Nome {Toto.Nome}");
        Console.WriteLine($" Idade: {Toto.Idade}");
        Console.WriteLine($" Existencia: {Toto.Existencia}");
        Toto.Nascer();
        Toto.Crescer();
        Toto.Reproduzir();
        Toto.Morrer();
        continue;
    }
    else if (num == 3)
    {
        PeixeDourado Peixinho = new PeixeDourado();
        Peixinho.Filo = "Peixe";
        Peixinho.Especie = "Dourado";
        Peixinho.Nome = "Peixinho";
        Peixinho.Idade = 1;
        Peixinho.Existencia = true;
        Console.WriteLine($" Filo: {Peixinho.Filo}");
        Console.WriteLine($" Especie: {Peixinho.Especie}");
        Console.WriteLine($" Nome {Peixinho.Nome}");
        Console.WriteLine($" Idade: {Peixinho.Idade}");
        Console.WriteLine($" Existencia: {Peixinho.Existencia}");
        Peixinho.Nascer();
        Peixinho.Crescer();
        Peixinho.Reproduzir();
        Peixinho.Morrer();
        continue;
    }
    else if (num == 4)
    {
       Coruja Felipeneto = new Coruja();
        Felipeneto.Filo = "Ave";
        Felipeneto.Especie = "Coruja";
        Felipeneto.Nome = "Felipe Neto";
        Felipeneto.Idade = 7;
        Felipeneto.Existencia = true;
        Console.WriteLine($" Filo: {Felipeneto.Filo}");
        Console.WriteLine($" Especie: {Felipeneto.Especie}");
        Console.WriteLine($" Nome {Felipeneto.Nome}");
        Console.WriteLine($" Idade: {Felipeneto.Idade}");
        Console.WriteLine($" Existencia: {Felipeneto.Existencia}");
        Felipeneto.Nascer();
        Felipeneto.Crescer();
        Felipeneto.Reproduzir();
        Felipeneto.Morrer();
        continue;
    }
    else if (num == 5)
    {
        Console.WriteLine("Obrigado por visitar o Sistema de Taxonomia!!");
        break;
    }
    else
    {
        Console.WriteLine("Você digitou um valor invalido tente novamente!!");
        continue;
    }
}

