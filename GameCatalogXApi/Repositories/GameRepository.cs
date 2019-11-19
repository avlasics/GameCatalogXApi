using GameCatalogXApi.Mapper;
using GameCatalogXApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace GameCatalogXApi.Repositories
{
    public class EFGameRepository : IGameRepository, IDisposable
    {
        private readonly CatalogXDbContext _dbContext;
        private readonly GameMapper _mapper;
        public EFGameRepository()
        {
            _dbContext = new CatalogXDbContext();
            _mapper = new GameMapper();
        }

        public async Task<List<GameResponseDTO>> GetGames()
        {
            return await Task.Run(() =>
            {
               List<GameResponseDTO> gameResponseDTOs = new List<GameResponseDTO>();
               List<Game> games = _dbContext.Games.ToList();
               foreach (var game in games)
               {
                   gameResponseDTOs.Add(_mapper.MapGameEntityToGameResponseDTO(game));
               }
               return gameResponseDTOs;
            });
        }

        public async Task<GameResponseDTO> GetGameById(int gameId)
        {
            Game game = await _dbContext.Games.FindAsync(gameId);
            return _mapper.MapGameEntityToGameResponseDTO(game);
        }


        public async Task UpdateGame(GameDTO updatedGame, int id)
        {
            var existingGame = _dbContext.Games.FirstOrDefault(g => g.Id == id);
            
            // clear out old child objects - Delete old and add new
            _dbContext.CustomerReviews.RemoveRange(existingGame.CustomerReviews);
            _dbContext.Images.RemoveRange(existingGame.Images);
            _dbContext.SystemRequirements.RemoveRange(existingGame.SystemRequirements);

            _mapper.MapGameDTOtoEntity(existingGame, updatedGame);

            await _dbContext.SaveChangesAsync();


        }

        public void Dispose()
        {
            // scoped Dependency Injection automatically calls dispose
            _dbContext.Dispose();
        }

    }
}