using InjecaoDepencia.Models;

namespace InjecaoDepencia.Service
{
    public interface IUsuarioService
    {
        IEnumerable<Usuario> ListarUsuario();
    }
}
