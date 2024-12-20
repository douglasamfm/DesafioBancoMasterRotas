namespace DesafioBancoMaster.Models.Entities
{
    public class Rota
    {
        public Guid Id { get; set; }
        public  required string Origem { get; set;     }
        public required string Destino { get; set; }
        public required int Custo { get; set; }

    }
}
