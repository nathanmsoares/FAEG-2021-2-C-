// Importar bibliotecas externas (import)
using System;

// Agrupador de classes (package)
namespace tiposdedados
{
    // Classe - junção MÉTODOS e ATRIBUTOS/PROPRIEDADES
    //static - não modifica - carregador para memória antes do inicio do programa
    class Program
    {
        //MÉTODO - 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // Tipo Primitivo
            int idade = 10;
            string nome = "Zezinho";
            Console.WriteLine("-Nome: " + nome + " Idade: " +idade); // concatenação
            // Interpolação
            Console.WriteLine($"Nome: {nome} Idade: {idade}"); // System.out.println("")
        }
        // AQUI OHHH
    }
}
