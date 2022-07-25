using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StatusCode.Models;


namespace StatusCode.Controllers
{
    [Route("v1/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private SistemaContext DbSistema = new SistemaContext();


        [HttpGet]
        public ActionResult<List<Usuario>> RequererTodos()
        {
            return Ok(DbSistema.Usuario.ToList());
        }

        [HttpGet("{Id}")]
        public ActionResult<Usuario> RequererUmPelaId(int? Id)
        {
            var usuario = DbSistema.Usuario.Find(Id);
            if (usuario == null)
            {

                return NotFound();
            }
            else
            {
                return Ok(DbSistema.Usuario.Find(Id);
            }
        }

        [HttpPost]
        public ActionResult<List<Usuario>> PublicarUm(Usuario usuario)
        {
            var usuario1 = DbSistema.Usuario.Add(usuario);

             foreach (Usuario usuario2 in DbSistema.Usuario.ToList())
                {

                if (usuario2.Cpf == usuario.Cpf)
                {
                    return Conflict();

                }
                else
                {
                    return BadRequest();

                }
                }

                if (usuario1 == null)
                 {
                DbSistema.Usuario.Add(usuario);
                return Ok();
               
                 }
            
            return Ok();
           
        }

        [HttpDelete("{Id}")]
        public ActionResult<Usuario> DeletarUmPelaId(int Id, Usuario usuario)
        {
            var usuarioDelete = DbSistema.Usuario.Find(Id);
            if (usuarioDelete == null)
            {
                return NotFound();        
            }
            else
            {
                return Unauthorized();
            }

        }

        [HttpPut("{Id}")]
        public ActionResult<Usuario> SubstituirUmPelaId(int Id, Usuario usuario)
        {
            var usuarioEditar = DbSistema.Usuario.Find(Id);

            if (usuarioEditar == null)
            {
                return NotFound();
            }
            else if (usuarioEditar.Id != usuario.Id)
            {
                return BadRequest();
            }
            else if ()
            {
                return BadRequest();
            }
            else if (usuarioEditar.Cpf == usuario.Cpf)
            {
                return Conflict();
            }
            else
            {
                return Ok(DbSistema.Add(usuario);
            }
        }
            
        
    }
}
