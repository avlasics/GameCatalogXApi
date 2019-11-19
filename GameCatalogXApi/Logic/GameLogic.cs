using GameCatalogXApi.Models;
using GameCatalogXApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace GameCatalogXApi.Logic
{
    public class GameLogic : IGameLogic
    {
        private IGameRepository _gameRepository;
        public GameLogic(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        public async Task<List<GameResponseDTO>> GetGames()
        {
            return await _gameRepository.GetGames();
        }

        public async Task<GameResponseDTO> GetGameById(int gameId)
        {
            return await _gameRepository.GetGameById(gameId);
        }

        public async Task UpdateGame(GameDTO gameDTO, int gameId)
        {
             await _gameRepository.UpdateGame(gameDTO, gameId);
        }
    }
}