using System;

namespace Aula_de_PC1_ContagemRegressiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Vamos Lançar um foguete?\n Tecle enter:");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Aperte qualquer botão para ligar os motores:");
            Console.ReadKey();
            Console.WriteLine("Ligando motores...\n");
            Console.WriteLine("Aperte qualquer botão para ajustar o curso");
            Console.ReadKey();
            Console.WriteLine("Ajustando curso...\n");
            Console.WriteLine("Aperte *Enter* para decolar:");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Decolando em:\n");
            Console.WriteLine("...3\n");
            Console.WriteLine("...2\n");
            Console.WriteLine("...1\n \n");
            Console.ForegroundColor= ConsoleColor.DarkRed;
            Console.WriteLine("DECOLAGEM BEM SUCEDIDA!!");
            Console.ResetColor();

        
        }
    }
}
