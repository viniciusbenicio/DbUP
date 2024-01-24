using Fluent.API.Contexto;
using Fluent.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace Fluent.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {

        [HttpGet]
        public Usuario Get([FromServices] UsuarioPedidoContext context, int IdUsuario)
        {
            var usuario = context.Usuarios.FirstOrDefault(x => x.Id  == IdUsuario);

            return usuario;
            
        }

        [HttpPost]
        public Usuario Post([FromServices] UsuarioPedidoContext context)
        {
           var usuario =  context.Usuarios.Add(new Usuario
            {
                Id = 3,
                Nome = "X",
                Endereco = "Y",
                Telefone = "Z",
                Pedidos = new List<Pedido> { }
            });

            context.Usuarios.Add(usuario);
            context.SaveChanges();
            
            return usuario;
        }
    }
}
