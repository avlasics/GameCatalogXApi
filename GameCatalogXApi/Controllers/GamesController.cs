using GameCatalogXApi.Logic;
using GameCatalogXApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;

namespace GameCatalogXApi.Controllers
{
    public class GamesController : BaseController
    {
        private IGameLogic _gameLogic;

        public GamesController(IGameLogic gameLogic)
        {
            _gameLogic = gameLogic;
        }

        [Route("v1/Games")]
        [ResponseType(typeof(GameResponseDTO))]
        public async Task<IHttpActionResult> Get()
        {
            return Ok(await _gameLogic.GetGames());
        }

        [Route("v1/Games/{id}")]
        public async Task<IHttpActionResult> Get(int id)
        {
            return Ok(await _gameLogic.GetGameById(id));
        }

        [Route("v1/Games/{id}")]
        public async Task<IHttpActionResult> Put(int id, [FromBody]GameDTO game)
        {
            if (id == 0)
            {
                return BadRequest("zero id - bad request");
            }
            try
            {
                ValidateContentType(this.Request, "application/json");
            }
            catch (BadRequestException)
            {
                return BadRequest("Missing Content Type");
            }
            catch (UnsupportedMediaTypeException)
            {
                return StatusCode(HttpStatusCode.UnsupportedMediaType);
            }
            catch (Exception)
            {
                return InternalServerError();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _gameLogic.UpdateGame(game, id);
            return Ok();
        }


    }
}
