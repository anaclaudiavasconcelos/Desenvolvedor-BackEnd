using Microsoft.AspNetCore.Mvc;
using PlataformaJogosAPI.Models.Entidades;
using PlataformaJogosAPI.Repositorio;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PlataformaJogosAPI.Classes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogoController : ControllerBase
    {
        RepositorioJogo rep = new RepositorioJogo();

        /// <summary>
        /// Obtém a lista de jogos
        /// </summary>
        /// <returns></returns>

        // GET: api/<JogoController>
        [HttpGet]
        public IEnumerable<Jogo> Get()
        {
            return rep.ListarJogo();
        }

        /// <summary>
        /// Obtém o jogo pelo identificador informado.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        // GET api/<JogoController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(rep.PesquisarJogoID);
        }

        /// <summary>
        /// Cadastrar um novo jogo. 
        /// </summary>
        /// <param name="value"></param>
        // POST api/<JogoController>
        [HttpPost]
        public IActionResult Post([FromBody] Jogo jogo)
        {
            try
            {
                rep.CadastrarJogo(jogo);
                return Created("Jogo cadastrado com sucesso", jogo);
            }
            catch (Exception ex)
            {

                return Conflict(ex.Message);
            }
        }

        /// <summary>
        ///  Edita os dados do jogo.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>

        // PUT api/<JogoController>/5
        [HttpPut]
        public IActionResult Put( [FromBody] Jogo jogo)
        {
            try
            {
                if (rep.EditarJogo(jogo))
                {
                    return Ok("Jogo atualizado com sucesso");
                }
                else
                {
                    return NotFound("Jogo não encontrado");
                }

            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
        /// <summary>
        /// Exclui um jogo pelo identificador informado.
        /// </summary>
        /// <param name="id"></param>

        // DELETE api/<JogoController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                if (rep.DeletarJogo(id))
                {
                    return Ok("Jogo deletado com sucesso!");
                }
                else
                {
                    return NotFound("Jogo não encontrado");
                }
            }
            catch (Exception e)
            {

                return BadRequest(e.Message);
            }
        }
    }
}
