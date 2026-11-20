using System.ComponentModel;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using Exercícios_Ficha05;
CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

// Exercício 1 - Ficha 05
//Televisao tv = new Televisao();
//Console.WriteLine("Estado inicial da televisão: " + tv.Ligada);
//tv.Ligar();
//Console.WriteLine("Estado da televisão após ligar: " + tv.Ligada);
//tv.Desligar();
//Console.WriteLine("Estado da televisão após desligar: " + tv.Ligada);

// Explique que detalhes internos ficam fora deste modelo de televisão.
// Faltou definir os estados se liaga = false retornava delsigada, se estivesse true retornava ligada.

// Exercício 2 - Ficha 05
//Termostato termostato = new Termostato();
//Console.WriteLine("Temperatura inicial do termostato: " + termostato.Temperatura);
//Console.WriteLine("Teste de validação de temperaturas:");
//Console.WriteLine("Definir temperatura para 16: " + termostato.Definir(16));
//Console.WriteLine("Definir temperatura para 31: " + termostato.Definir(31));
//Console.WriteLine("Definir temperatura para 30: " + termostato.Definir(30));

// Exercício 3 - Ficha 05
//Conta novaConta = new Conta();
//Console.WriteLine("Saldo inicial da conta: " + novaConta.Saldo);
//Console.WriteLine("Depósito de 50 euros: " + novaConta.Depositar(50));
//Console.WriteLine("Levantamento de 20 euros: " + novaConta.Levantar(20));
//Console.WriteLine("Levantamento de 40 euros: " + novaConta.Levantar(40));
//Console.WriteLine("Saldo final da conta: " + novaConta.Saldo);

// Exercício 4 - Ficha 05
//Stock novoStock = new Stock();
//novoStock.Repor(5);
//novoStock.Retirar(2);
//novoStock.Retirar(4);
//novoStock.Repor(0);
//Console.WriteLine("Quantidade final em stock: " + novoStock.Quantidade);

// Exercício 5 - Ficha 05
//Aluno novoAluno = new Aluno("Ana", 1001);
//Console.WriteLine("Nome: " + novoAluno.Nome + "Nmr: "+ novoAluno.Numero);

// Exercício 6 - Ficha 05
//Carro novoCarro = new Carro("Alfa", 5);
//Console.WriteLine("Marca:" + novoCarro.Marca + "Portas:" + novoCarro.Portas);

// Exercício 7 - Ficha 05
//Cao novoCao = new Cao(); // também poderia ser feito com Animal novoCao = new Cao();, mas não é o ideal, pois não se pode instanciar uma classe abstrata.
//Gato novoGato = new Gato();
//Console.WriteLine(novoCao.EmitirSom());
//Console.WriteLine(novoGato.EmitirSom());

// Exercício 8 - Ficha 05
//Pessoa novoDocente = new Docente("Ana"); 
//Console.WriteLine(novoDocente.Descrever());

// Exercício 10 - Ficha 05
//Veterinario novoVet = new Veterinario();
//Cao cao = new Cao();
//Gato gato = new Gato();
//Console.WriteLine(novoVet.Ouvir(cao));
//Console.WriteLine(novoVet.Ouvir(gato));

// Exercício 11 - Ficha 05
//Calculadora calc = new Calculadora();
//calc.Somar(2, 3);
//calc.Somar(2, 3, 4);

// Exercício 12 - Ficha 05
//Figura novaFigura = new Retangulo(4,3);
//Console.WriteLine(novaFigura.Area());

// Exercício 15 - Ficha 05
//Conta novaConta = new ContaPoupanca();
//novaConta.Depositar(100);
//Console.WriteLine("Saldo: " + novaConta.Saldo);

// Exercício 17 - Ficha 05
//Autor novoAutor = new Autor("Eça de Queirós");
//Livro livro1 = new Livro("Os Maias", novoAutor.Nome);
//Livro livro2 = new Livro("O Primo Basílio", novoAutor.Nome);
//Console.WriteLine("livro1: " + livro1.Titulo + " - Autor: " + livro1.Autor);
//Console.WriteLine("livro2: " + livro2.Titulo + " - Autor: " + livro2.Autor);

// Exercício 19 - Ficha 05
////////////////Linha novaLinha = new Linha(2, 7.5m);
////////////////Console.WriteLine("Total: " + novaLinha.Total());
//Encomenda novae = new Encomenda(2, 7.5m);
//Console.WriteLine("Total: " + novae.Total());

//Exercicio do teste exemplo

//class Cancela
//{
//    bool estado;
//    int passagens;

//    public Cancela()
//    {
//        estado = false;
//        passagens = 0; 
//    }

//    public void Abrir()
//    {
//        estado = true;
//    }

//    public void Fechar()
//    {
//        estado = false;
//    }

//    public bool EstaAberta()
//    {
//        return estado;
//    }

//    public int GetPassagens()
//    {
//        return passagens;
//    }

//    public bool RegistarPassagem()
//    {
//        if(estado == true)
//        {
//            passagens++;
//            return true;
//        }
//        else
//        {
//            return false;
//        }
//    }
//}

//class Parque
//{
//    string nome;
//    int capacidade;
//    int ocupados;
//    Cancela entrada;
//    Cancela saida;

//    public Parque(string nome, int capacidade)
//    {
//        this.nome = nome;
//        this.capacidade = capacidade;
//        ocupados = 0;
//        entrada = new Cancela();
//        saida = new Cancela();
//    }

//    public string PropriedadeNome()
//    {
//        return nome;
//    }

//    public bool EstaCheio() 
//    {
//        if(ocupados<capacidade)
//        {
//            return false;
//        }
//        else
//        {
//            return true;
//        }
//    }

//    public int GetLugaresOcupados()
//    {
//        return ocupados;
//    }
    
//    public int GetLugaresLivres()
//    {
//        return capacidade - ocupados;
//    }

//    public bool Entra()
//    {
//        if (ocupados < capacidade)
//        {
//            entrada.Abrir();
//            entrada.RegistarPassagem();
//            entrada.Fechar();
//            ocupados ++;
//            return true;
//        }
//        else 
//        { 
//            return false; 
//        }
//    }
//}

//class Programa
//{
//    static void Main()
//    {
//        Parque[] parques = new Parque[4];
//        parques[0] = new Parque("A", 10);
//        parques[1] = new Parque("B", 20);
//        parques[2] = new Parque("C", 30);
//        parques[3] = new Parque("D", 40);

//        for(int i = 0; i < parques.Length; i++)
//        {
//            parques[i].Entra();
//        }

//        for(int i = 0; i < parques.Length; i++)
//        {
//            Console.WriteLine(parques[i].PropriedadeNome()+ parques[i].GetLugaresLivres());
//        }
//    }
//}

