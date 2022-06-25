using APIMonitoramento.Contexts;
using APIMonitoramento.Models;

namespace APIMonitoramento.Repository
{
    public class ProjetosRepository
    {
        private readonly ProjetoContext _context;

        public ProjetosRepository(ProjetoContext context)
        {
            _context = context;
        }

        public List<Projetos> Listar()
        {
            return _context.Projetos.ToList();
        }

        public Projetos BuscarPorId(int id)
        {
            return _context.Projetos.Find(id);
        }

        public void Cadastrar(Projetos projeto)
        {
            _context.Projetos.Add(projeto);
            _context.SaveChanges();
        }

        public void Atualizar(int id, Projetos projeto)
        {
            Projetos projetoBuscado = _context.Projetos.Find(id);

            if (projetoBuscado != null)
            {
                projetoBuscado.Id = projeto.Id;
                projetoBuscado.Título = projeto.Título;
                projetoBuscado.Andamento = projeto.Andamento;
                projetoBuscado.Inicio = projeto.Inicio;
                projetoBuscado.Tecnologias = projeto.Tecnologias;
                projetoBuscado.Requisitos = projeto.Requisitos;
                projetoBuscado.Área = projeto.Área;
  
            }

            _context.Projetos.Update(projetoBuscado);
            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Projetos projeto = _context.Projetos.Find(id);
            _context.Projetos.Remove(projeto);
            _context.SaveChanges();
        }
    }


}
