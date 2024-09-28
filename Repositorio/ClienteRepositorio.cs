using cadastrocli.context;
using cadastrocli.Models;

namespace cadastrocli.Repositorio
{
    public class ClienteRepositorio : IClienteRepostorio
    {
        private readonly principal _principal;

        public ClienteRepositorio(principal principal)
        {
            _principal = principal;
        }

        public Cliente Adicionar(Cliente cliente) // Supondo que Cliente seja o tipo correto
        {
            _principal.clientes.Add(cliente); // Adicionando um objeto do tipo Cliente
            _principal.SaveChanges();
            return cliente;
        }

        public HttpClient Adicionar(HttpClient cliente)
        {
            throw new NotImplementedException();
        }
    }
}
