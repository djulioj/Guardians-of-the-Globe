namespace Reto_Sophos.DTOs
{
    public class PatrocinadorMDto//DTO utilizado para la creacion y actualizacion de este modelo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Origen { get; set; }
        public decimal Monto { get; set; }

        // Lista de IDs o nombres de héroes asociados
        public List<string>? Heroes { get; set; } = new List<string>();
    }
}
