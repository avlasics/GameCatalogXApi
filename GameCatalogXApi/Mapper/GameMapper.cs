using GameCatalogXApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameCatalogXApi.Mapper
{
    public class GameMapper
    {
        internal GameResponseDTO MapGameEntityToGameResponseDTO(Game game)
        {
            var gameResponseDTO = new GameResponseDTO()
            {
                About = game.About,
                Description = game.Description,
                Id = game.Id,
                Developer = game.Developer,
                Name = game.Name,
                Price = game.Price,
                Publisher = game.Publisher,
                ReleaseDate = game.ReleaseDate,
                CustomerReviews = MapGameEntityCustomerReviews(game.CustomerReviews),
                Images = MapGameEntityImages(game.Images),
                SystemRequirements = MapGameEntitySystemRequirements(game.SystemRequirements)
            };

            return gameResponseDTO;
        }

        private ICollection<SystemRequirementsResponseDTO> MapGameEntitySystemRequirements(ICollection<SystemRequirement> systemRequirements)
        {
            var systemRequirementsResponseDTOs = new List<SystemRequirementsResponseDTO>();
            foreach (var sr in systemRequirements)
            {
                systemRequirementsResponseDTOs.Add(new SystemRequirementsResponseDTO()
                {
                    Id = sr.Id,
                    DirectX = sr.DirectX,
                    Graphics = sr.Graphics,
                    Memory = sr.Memory,
                    OS = sr.OS,
                    Processor = sr.Processor,
                    Storage = sr.Storage
                });
            }
            return systemRequirementsResponseDTOs;
        }

        private ICollection<CustomerReviewResponseDTO> MapGameEntityCustomerReviews(ICollection<CustomerReview> customerReviews)
        {
            var customerReviewResponseDTOs = new List<CustomerReviewResponseDTO>();
            foreach (var cr in customerReviews)
            {
                customerReviewResponseDTOs.Add(new CustomerReviewResponseDTO()
                {
                    Id = cr.Id,
                    Rating = cr.Rating,
                    Review = cr.Review,
                    UserName = cr.UserName
                });
            }
            return customerReviewResponseDTOs;
        }

        private ICollection<ImageResponseDTO> MapGameEntityImages(ICollection<Image> images)
        {
            var imageResponseDTOs = new List<ImageResponseDTO>();

            foreach (var i in images)
            {
                imageResponseDTOs.Add(new ImageResponseDTO()
                {
                    Id = i.Id,
                    ImageUrl = i.ImageUrl
                });
            }
            return imageResponseDTOs;
        }

        internal void MapGameDTOtoEntity(Game game, GameDTO gameDTO)
        {
            game.About = gameDTO.About;
            game.Developer = gameDTO.Developer;
            game.Description = gameDTO.Description;
            game.Name = gameDTO.Name;
            game.Price = gameDTO.Price;
            game.Publisher = gameDTO.Publisher;
            game.ReleaseDate = gameDTO.ReleaseDate;

            foreach (var s in gameDTO.SystemRequirements)
            {
                MapSystemRequirementsDTOtoEntity(game, s);
            }

            foreach (var cr in gameDTO.CustomerReviews)
            {
                MapCustomerReviewsDTOToEntity(game, cr);
            }

            foreach (var i in gameDTO.Images)
            {
                MapImageDTOToEntity(game, i);
            }

        }

        private void RemoveChildObjects(Game game)
        {
            foreach (var sr in game.SystemRequirements)
            {
                game.SystemRequirements.Remove(sr);
            }

            foreach (var img in game.Images)
            {
                game.Images.Remove(img);
            }

            foreach (var cr in game.CustomerReviews)
            {
                game.CustomerReviews.Remove(cr);
            }
        }

        internal void MapImageDTOToEntity(Game game, ImageDTO i)
        {
            game.Images.Add(new Image()
            {
                ImageUrl = i.ImageUrl
            });

        }

        internal void MapCustomerReviewsDTOToEntity(Game game, CustomerReviewDTO cr)
        {
            game.CustomerReviews.Add(new CustomerReview()
            {
                Rating = cr.Rating,
                Review = cr.Review,
                UserName = cr.UserName
            });

        }

        internal void MapSystemRequirementsDTOtoEntity(Game game, SystemRequirementsDTO systemRequirements)
        {
            game.SystemRequirements.Add(new SystemRequirement()
            {
                DirectX = systemRequirements.DirectX,
                Graphics = systemRequirements.Graphics,
                Memory = systemRequirements.Memory,
                OS = systemRequirements.OS,
                Processor = systemRequirements.Processor,
                Storage = systemRequirements.Storage
            });
        }

    }
}