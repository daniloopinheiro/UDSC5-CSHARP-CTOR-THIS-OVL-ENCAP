using System;
using System.Globalization;
using ModificadoresDeAcesso;
using ModificadoresDeAcesso.Class.Publico;
using ModificadoresDeAcesso.Class.ProtegidoInterno;
using ModificadoresDeAcesso.Class.Interno;
using ModificadoresDeAcesso.Class.Protegido;
using ModificadoresDeAcesso.Class.Privado;
using ModificadoresDeAcesso.Class.PrivadoProtegido;

namespace ModificadoresDeAcesso
{
    class Program : Protegida
    {
        // Utilizando o Main, como base de uma aplicação em MVC, sendo que ele possa ser referênciado como a View.
        static void Main(string[] args)
        {
            System.DateTime sdt = System.DateTime.Now;
            string dtBrazil = sdt.ToString(new CultureInfo("pt-br"));

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"=== CONHECENDO OS MODIFICADORES E SEUS MEMBROS === Data: {dtBrazil}  ====");
            Console.WriteLine("--------------------------------------------------");

            new Menu().MenuPrimario();

            Publica publica = new Publica();
            publica.GetPublica();
            Console.WriteLine(new Publica().PublicaPrimaria());
            Console.WriteLine(new Publica.PublicaB().PublicaSecundaria());

            new Menu().MenuPrimario();

            Interna interna = new Interna();
            interna.GetInterna();
            Console.WriteLine(new Interna().InternaPrimaria());
            Console.WriteLine(new Interna.InternaB().InternaSecundaria());

            new Menu().MenuPrimario();

            ProtegidaInterna protegidaInterna = new ProtegidaInterna();
            protegidaInterna.GetProtegidaInterna();
            Console.WriteLine(new ProtegidaInterna().ProtegidaInternaPrimaria());
            Console.WriteLine(new ProtegidaInterna.ProtegidaInternaB().ProtegidaInternaSecundaria());

            new Menu().MenuPrimario();

            new ProgramB().MainB();

            new Menu().MenuPrimario();

            Protegida protegida = new Protegida();
            Program program = new Program();
            program.GetProtegida();
            Console.WriteLine(program.ProtegidaPrimaria());
            Console.WriteLine(new Protegida.ProtegidaB().ProtegidaSecundaria());
            Console.WriteLine();
            Console.WriteLine("\n Atenção: Sabemos que a classe privada, não é possivel de ser instânciada por outras classes. Então não teremos ela instãncia na classe program.");

            new Menu().MenuPrimario();

            Console.WriteLine("\n Por fim, por aqui terminamos nosso teste: Pressione a tecla Enter para sair ...");
            Console.ReadLine();

        }
        class ProgramB : PrivadaProtegida
        {
            public void MainB()
            {
                PrivadaProtegida privadaProtegida = new PrivadaProtegida();
                ProgramB programB = new ProgramB();
                programB.GetPrivadaProtegida();
                Console.WriteLine(programB.PrivadaProtegidaPrimaria());
                Console.WriteLine(new PrivadaProtegida.PrivadaProtegidaB().PrivadaProtegidaSecundaria());
            }
        }
    }
}