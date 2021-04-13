namespace ModificadoresDeAcesso.Class.Interno
{
    class Interna
    {
        internal string IdentificaClass = "Eu sou uma instância da class Interna e do diretório Interno";

        internal void GetInterna()
        {
            System.Console.WriteLine("== Modificador Interna e seus Membros ==");
            System.Console.WriteLine();
            System.Console.WriteLine("Mensagem Interna : {0}", IdentificaClass);
        }

        internal string InternaPrimaria()
        {
            return $"{IdentificaClass = "Eu sou um metodo da class Interna do diretório Interno"}";
        }

        internal class InternaB : Interna
        {
            public string InternaSecundaria()
            {
                return $"{IdentificaClass = "Eu sou um metodo da subclass Interna do diretório Interno"}";
            }
        }
    }
}