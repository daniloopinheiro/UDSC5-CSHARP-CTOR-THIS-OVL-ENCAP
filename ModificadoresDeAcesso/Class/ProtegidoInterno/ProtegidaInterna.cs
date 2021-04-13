namespace ModificadoresDeAcesso.Class.ProtegidoInterno
{
    class ProtegidaInterna
    {
        protected internal string IdentificaClass = "Eu sou uma instância da class Protegida Interna e do diretório Protegido Interno";

        protected internal void GetProtegidaInterna()
        {
            System.Console.WriteLine("== Modificador Protegido Interno e seus Membros ==");
            System.Console.WriteLine();
            System.Console.WriteLine("Mensagem Protegida Interna : {0}", IdentificaClass);
        }

        protected internal string ProtegidaInternaPrimaria()
        {
            return $"{IdentificaClass = "Eu sou um metodo da class Protegida Interna do diretório Protegido Interno"}";
        }

        protected internal class ProtegidaInternaB : ProtegidaInterna
        {
            public string ProtegidaInternaSecundaria()
            {
                return $"{IdentificaClass = "Eu sou um metodo da subclass Interna do diretório Protegido Interno"}";
            }
        }
    }
}