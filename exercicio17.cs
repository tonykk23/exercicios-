using System;

class programa{
    public static void Main(string[] args){
        string nome;
        int idade, AnosNaEmpresa;
        double salario;

        Console.WriteLine("digite seu nome: ");

        Console.WriteLine("digite a sua idade: ");
        idade = double.Parse(Console.ReadLine());

        Console.WriteLine("a quantos você trabalha na empressa?");
        AnosNaEmpresa = double.Parse(Console.ReadLine());

        Console.WritwLine("qual o seu salario?");
        salario = double.Parse(Console.ReadLine());
    }
   
}