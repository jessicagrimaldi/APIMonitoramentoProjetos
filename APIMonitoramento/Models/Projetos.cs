namespace APIMonitoramento.Models
{
    public class Projetos
    {
        public int Id { get; set; }

        public string Título { get; set; }

        public string Andamento { get; set; }

        public DateOnly Inicio { get; set; }

        public string Tecnologias { get; set; }

        public string Requisitos { get; set; }

        public string Área { get; set; }
    }
}