using System;

namespace Urna_Eletronica_Codigo_Fonte
{
    class Program
    {
        //Atribuiçoes candidato A 
        static string nomecandidatoA;
        static int partidoA;
        static int votosA;
        //Atribuiçoes candidato B
        static string nomecandidatoB;
        static int partidoB;
        static int votosB;
        static void Main(string[] args)
        {
            Candidatos a = new Candidatos(nome: nomecandidatoA = "Candidato A", partido: partidoA = 56, votos: votosA = 0);
            Candidatos b = new Candidatos(nome: nomecandidatoB = "Candidato B", partido: partidoB = 65, votos: votosB = 0);

            MenuOptions();

            /* Modo de instanciar de forma com que os atributos da instancia estejam publicos em suas definiçoes
            Candidatos a = new Candidatos
            {
                Nome = "Candidato A",
                Partido = 56,
                votos = 0
            };
            Candidatos b = new Candidatos
            {
                Nome = "Candidato B",
                Partido = 65,
                votos = 0
            };
            */

        }

        static void Votacao()
        {

            Console.WriteLine($"Candidatos disponiveis para votação: {nomecandidatoA} do partido: {partidoA} , {nomecandidatoB} do partido:{partidoB}");
            int NumeroCandidato;
            Console.WriteLine("Digite o Numero do partido do candidato: ");
            Console.WriteLine("Ou digite \"0\" para encerrar a votação ");
            NumeroCandidato = Convert.ToInt32(Console.ReadLine());

            while (NumeroCandidato != 0)
            {
                if (NumeroCandidato == partidoA)
                {
                    string confirmar = "CONFIRMAR";
                    string cancelar = "CANCELAR";
                    string input;
                    Console.WriteLine($"Digite  \"CONFIRMAR\" se Deseja votar no candidato {nomecandidatoA} do partido {partidoA}? ");
                    Console.WriteLine("Digite \"CANCELAR\"  para Desistir");
                    input = Console.ReadLine().ToUpper();
                    while (input != confirmar || input != cancelar)
                    {
                        if (input == confirmar)
                        {
                            votosA++;
                            Console.WriteLine($"Seu voto no candidato: {nomecandidatoA} do partido: {partidoA} foi computado com sucesso, obrigado!" );
                            
                            return;
                        }
                        else if (input == cancelar)
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Não entendemos o que quis dizer, tente novamente");
                        }
                        Console.WriteLine($"Digite \"CONFIRMAR\" se Deseja votar no candidato {nomecandidatoA} do partido {partidoA}? ");
                        Console.WriteLine("Digite \"CANCELAR\" para Desistir");
                        input = Console.ReadLine().ToUpper();
                        
                    }

                }
                else if (NumeroCandidato == partidoB)
                {
                    string confirmar = "CONFIRMAR";
                    string cancelar = "CANCELAR";
                    string input;
                    Console.WriteLine($"Digite  \"CONFIRMAR\" se Deseja votar no candidato {nomecandidatoB} do partido {partidoB}? ");
                    Console.WriteLine("Digite \"CANCELAR\"  para Desistir");
                    input = Console.ReadLine().ToUpper();
                    while (input != confirmar || input != cancelar)
                    {
                        if (input == confirmar)
                        {
                            votosB++;
                            Console.WriteLine($"Seu voto no candidato: {nomecandidatoB} do partido: {partidoB} foi computado com sucesso, obrigado!");
                            return;
                        }
                        else if (input == cancelar)
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Não entendemos o que quis dizer, tente novamente");
                        }
                        Console.WriteLine($"Digite \"CONFIRMAR\" se Deseja votar no candidato {nomecandidatoB} do partido {partidoB}? ");
                        Console.WriteLine("Digite \"CANCELAR\" para Desistir");
                        input = Console.ReadLine().ToUpper();
                       
                        
                    }
                    
                }
                Console.WriteLine($"Candidatos disponiveis para votação: {nomecandidatoA} do partido: {partidoA} , {nomecandidatoB} do partido:{partidoB}");
                Console.WriteLine("Digite o Numero do partido do candidato: ");
                Console.WriteLine("Ou digite \"0\" para encerrar a votação ");
                NumeroCandidato = Convert.ToInt32(Console.ReadLine());
            }       
        }
        static void MenuOptions()
        {
            string input;
            Console.WriteLine("Digite \"1\" para Iniciar a votação");
            Console.WriteLine("Digite \"2\" para mostrar o resultado");
            Console.WriteLine("Digite \"0\" para sair");
            input = Console.ReadLine();
            while (input != "0")
            {

                if (input == "1")
                {
                    Votacao();
                }
                else if (input == "2")
                {
                    Console.WriteLine($"O candidato: {nomecandidatoA} do partido: {partidoA} recebeu: {votosA} votos ");
                    Console.WriteLine($"O candidato: {nomecandidatoB} do partido: {partidoB} recebeu: {votosB} votos ");
                }
                else if (input == "0")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("Comando inexistente");

                }
                Console.WriteLine("Digite \"1\" para Iniciar a votação");
                Console.WriteLine("Digite \"2\" para mostrar o resultado");
                Console.WriteLine("Digite \"0\" para sair");
                input = Console.ReadLine();

            }
        }
    }
}
