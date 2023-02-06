namespace Principal;

using AgendaIma.Entity;

class Program
{
    public static void Main(string[] args)
    {
        // Instanciar uma agenda
        AgendaIma agendaIma = new AgendaIma();

        // Instancia uma pessoa
        Pessoa pessoa1 = new Pessoa("Luis",21);

        // Aramazenando na lista um tipo de dado Pessoa
        agendaIma.ArmazenarPessoaNaAgenda(pessoa1);


        // Armazenando outra pessoa na lista, através do new diretamente
        agendaIma.ArmazenarPessoaNaAgenda(new Pessoa("Marcos",20));
        agendaIma.ArmazenarPessoaNaAgenda(new Pessoa("MARIA",45));


        // Vendo quem ta na lista
        agendaIma.ImprimirAgenda();


        // Retorna a posição na lista onde essa pessoa procurada está
        agendaIma.BuscarPessoaNaAgenda("MARIA");


        // Removendo uma pessoa da agenda
        agendaIma.RemoverPessoaDaAgenda("Marcos");



        // Vendo quem ta na lista
        agendaIma.ImprimirAgenda();


        // Imprimir dados de uma pessoa só
        agendaIma.ImprimirPessoa("MARIA");
    }
} 
