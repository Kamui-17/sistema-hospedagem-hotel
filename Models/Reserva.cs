namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            int quantidade_hospedes = hospedes.Count;
            
            Console.WriteLine(quantidade_hospedes);
            
            if (Suite.Capacidade>=quantidade_hospedes)
            {
                Console.WriteLine("A reserva pode ser realizada, número de hóspedes não excede o tamanho da suíte.");
                Hospedes = hospedes;
            }
            else
            {   
                
                 Console.WriteLine("Impossível realizar a reserva, número de hóspedes é superior ao tamanho da suíte.");
                 //catch(Exception ex){
                //Console.WriteLine($"Ocorreu uma exceção genérica.{ex.Message}");    
                //}

            }
            
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados*Suite.ValorDiaria;

            if (DiasReservados>=10)
            {
                valor = valor*90/100;
            }

            return valor;
        }
    }
}