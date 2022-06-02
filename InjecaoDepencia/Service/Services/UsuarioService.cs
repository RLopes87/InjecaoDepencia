using InjecaoDepencia.Models;

namespace InjecaoDepencia.Service.Services
{
    public class UsuarioService : IUsuarioService
    {
        public IEnumerable<Usuario> ListarUsuario()
        {
            //DDD: Domain Driven Development

            //acessar o banco de dados e retornar
            //todos os usuários


            //finge que daqui pra baixo não existe
            List<Usuario> usuarios = new List<Usuario>();
            
            usuarios.Add(
                new Usuario()
                {
                    Name = "Administrador",
                    User = "Admin",
                    Password = "admin"
                }
            );

            usuarios.Add(
                new Usuario()
                {
                    Name = "Usuário",
                    User = "User",
                    Password = "user"
                }
            );
            return usuarios;
        }
    }
}
