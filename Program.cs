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
        case 1:{
            int opcaoCadastro = 0;
            List<Pessoa> hospedes = new List<Pessoa>();
            do
            {

                Console.WriteLine("Digite o nome do hóspede para a reserva: ");
                string nome = Console.ReadLine();
                Console.WriteLine("Digite o sobrenome: ");
                string sobrenome = Console.ReadLine();

                Pessoa p1 = new Pessoa(nome, sobrenome);
                hospedes.Add(p1);

                Console.WriteLine("Deseja cadastrar outro hóspede para essa reserva?");
                Console.WriteLine("1 - Sim\n 2- Não");
                opcaoCadastro = Convert.ToInt32(Console.ReadLine());
            }while(opcaoCadastro !=2 );
        }
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
                    Console.WriteLine("\n ----------------------------------------- \n");
                }
                Console.WriteLine("Precione 'Enter' para continuar");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ainda não há reservas criadas");
                Console.WriteLine("Precione 'Enter' para continuar");
                Console.ReadLine();
            }
        }
        break;
        default:
        break;
    }
}while(opcao != 0);







// Cria os modelos de hóspedes e cadastra na lista de hóspedes


// Cria a suíte
Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 30);

// Cria uma nova reserva, passando a suíte e os hóspedes
// Reserva reserva = new Reserva(diasReservados: 5);
// reserva.CadastrarSuite(suite);
// reserva.CadastrarHospedes(hospedes);

// Exibe a quantidade de hóspedes e o valor da diária
// Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
// Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");