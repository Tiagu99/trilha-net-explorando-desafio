using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

int opcao = 0;

List<Reserva> listaDeReservas = new List<Reserva>();

do
{
    Console.Clear();
    Console.WriteLine("Bem vindo ao sistema de cadastro de reserva");
    Console.WriteLine("digite a opção desejada: \n 1 - Cadastrar nova reserva\n 2 - Listar reservas existentes\n 0 - Encerrar programa");
    opcao = Convert.ToInt32(Console.ReadLine());
    switch(opcao)
    {
        case 1:
        break;
        case 2:{
            if(listaDeReservas.Any())
            {
                foreach(var reserva in listaDeReservas)
                {
                    Console.WriteLine($"Tipo da suíte: {reserva.Suite.TipoSuite}");
                    Console.WriteLine($"Capacidade da suíte: {reserva.Suite.Capacidade}");
                    Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
                    Console.WriteLine($"Valor da diaria: {reserva.Suite.ValorDiaria:c}");
                    Console.WriteLine($"Valor Total: {reserva.CalcularValorDiaria():c}");
                }
            }
            else
            {
                Console.WriteLine("Ainda não há reservas criadas");
            }
        }
        break;
        default:
        break;
    }
}while(opcao != 0);







// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Hóspede 1");
Pessoa p2 = new Pessoa(nome: "Hóspede 2");

hospedes.Add(p1);
hospedes.Add(p2);

// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
// Reserva reserva = new Reserva(diasReservados: 5);
// reserva.CadastrarSuite(suite);
// reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
// Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
// Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");