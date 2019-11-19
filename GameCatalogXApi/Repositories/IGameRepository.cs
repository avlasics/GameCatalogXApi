using GameCatalogXApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCatalogXApi.Repositories
{ 
    public interface IGameRepository
    {
        Task UpdateGame(GameDTO updatedGame, int id);

        Task<List<GameResponseDTO>> GetGames();
        
        Task<GameResponseDTO> GetGameById(int gameId);
    }
}
