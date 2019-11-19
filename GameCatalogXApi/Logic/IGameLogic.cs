using GameCatalogXApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCatalogXApi.Logic
{
    public interface IGameLogic
    {
        Task<List<GameResponseDTO>> GetGames();

        Task<GameResponseDTO> GetGameById(int gameId);

        Task UpdateGame(GameDTO gameDTO, int gameId);
    }
}
