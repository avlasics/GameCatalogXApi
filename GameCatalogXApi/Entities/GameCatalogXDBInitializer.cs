using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GameCatalogXApi.Entities
{
    public class GameCatalogXDBInitializer : CreateDatabaseIfNotExists<CatalogXDbContext>
    {
        protected override void Seed(CatalogXDbContext context)
        {
            context.Games.AddRange(new List<Game>()
            {
                new Game()
                {
                    Id = 1,
                    About = "Rise of the Tomb Raider: 20 Year Celebration includes the base game and Season Pass featuring all-new content. Explore Croft Manor in the new “Blood Ties” story, then defend it against a zombie invasion in “Lara’s Nightmare”. Survive extreme conditions with a friend in the new online Co-Op Endurance mode, and brave the new “Extreme Survivor” difficulty. Also features an outfit and weapon inspired by Tomb Raider III, and 5 classic Lara skins. Existing DLC will challenge you to explore a new tomb that houses an ancient terror in Baba Yaga: The Temple of the Witch, and combat waves of infected predators in Cold Darkness Awakened.",
                    Description = "As Lara Croft races to save the world from a Maya apocalypse, she must become the Tomb Raider she is destined to be.",
                    Developer = "Crystal Dynamics",
                    Name = "Laura Croft Rise of the Tomb Raider",
                    ReleaseDate = new DateTime(2016, 2, 9),
                    Price = 69.99m,
                    Publisher = "Square Enix",
                    CustomerReviews = new List<CustomerReview>()
                    {
                        new CustomerReview()
                        {
                            Rating = 5,
                            Review = "Loved every minute of it!",
                            UserName = "e_sage16"
                        }
                    },
                    Images = new List<Image> {
                        new Image()
                        {
                            ImageUrl = "laura-croft-rise-of-the-tomb-raider.jpg"
                        },
                        new Image()
                        {
                            ImageUrl = "laura-croft-rise-of-the-tomb-raider-2.jpg"
                        }

                    },
                    SystemRequirements = new List<SystemRequirement>()
                    {
                        new SystemRequirement()
                        {
                            DirectX = 11,
                            Graphics = "NVIDIA GTX 650 2GB or AMD HD7770 2GB",
                            Memory = 6,
                            Storage = 25,
                            OS = "Windows 7 64 Bit",
                            Processor = "Intel CPU Core i5-2500K 3.3GHz / AMD CPU Phenom II X4 940",
                        }
                    }
                },
                new Game()
                {
                    Id = 2,
                    About = "China in 190CE.  Welcome to a new era of legendary conquest.  This beautiful but fractured land calls out for a new emperor and a new way of life.  Unite China under your rule, forge the next great dynasty, and build a legacy that will last through the ages.  Choose from a cast of 12 legendary Warlords and conquer the realm.Recruit heroic characters to aide your cause and dominate your enemies on military, technological, political, and economic fronts.  Will you build powerful friendships, form brotherly alliances, and earn the respect of your many foes ? Or would you rather commit acts of treachery, inflict heart - wrenching betrayals, and become a master of grand political intrigue ?  Your legend is yet to be written, but one thing is certain: glorious conquest awaits.",
                    Description = "Total War: THREE KINGDOMS is the first in the award-winning series to recreate epic conflict across ancient China. Combining a gripping turn-based campaign of empire-building & conquest with stunning real-time battles, THREE KINGDOMS redefines the series in an age of heroes & legends.",
                    Developer = "CREATIVE ASSEMBLY",
                    Name = "Total War: Three Kingdoms",
                    ReleaseDate = new DateTime(2019, 5, 23),
                    Price = 71.99m,
                    Publisher = "SEGA",
                    CustomerReviews = new List<CustomerReview>()
                    {
                        new CustomerReview()
                        {
                            Rating = 5,
                            Review = "Great game",
                            UserName = "e_sage16"
                        },
                        new CustomerReview()
                        {
                            Rating = 3,
                            Review = "The battles take so long I found myself losing interest in places.  Zhang Fei is overpowered.",
                            UserName = "q_bert555"
                        },
                    },
                    Images = new List<Image> {
                        new Image()
                        {
                            ImageUrl = "total-war-three-kingdoms.jpg"
                        }
                    },
                    SystemRequirements = new List<SystemRequirement>()
                    {
                        new SystemRequirement()
                        {
                            DirectX = 11,
                            Graphics = "NVIDIA GTX 650 2GB or AMD HD7770 2GB",
                            Processor = "Intel CPU Core i5-2500K 3.3GHz / AMD CPU Phenom II X4 940",
                            Memory = 8,
                            Storage = 52,
                            OS = "Windows 7 64 Bit"
                        }
                    }
                },
                new Game()
                {
                    Id = 3,
                    About = "Immerse yourself in a vibrant ocean world full of mystery and bursting with color and life. Perform fluid acrobatics as the Diver using graceful swimming controls. Discover hundreds of unique species based on real creatures and form a powerful connection with the abundant sea life. Interact with schools of thousands of fish that procedurally respond to you, each other, and predators. Linger in epic seascapes and explore aquatic ecosystems modeled with unprecedented detail. Descend into the heart of the ocean where ancient secrets lie forgotten. But beware, dangers lurk in the depths. ABZÛ is from the oldest mythologies; AB, meaning water, and ZÛ, meaning to know. ABZÛ is the ocean of wisdom.",
                    Description = "From the art director of Journey®, ABZÛ is a beautiful underwater adventure that evokes the dream of diving. Immerse yourself in a vibrant hidden world bursting with color and life as you descend into the heart of the ocean. But beware as you swim deeper as dangers lurk in the depths.",
                    Developer = "Giant Squid",
                    Name = "ABZÛ",
                    ReleaseDate = new DateTime(2016, 8, 2),
                    Price = 21.99m,
                    Publisher = "505 Games",
                    CustomerReviews = new List<CustomerReview>()
                    {
                        new CustomerReview()
                        {
                            Rating = 1,
                            Review = "Boring!!!",
                            UserName = "e_sage16"
                        },
                        new CustomerReview()
                        {
                            Rating = 5,
                            Review = "A stunning game - an almost spiritual experience to play.",
                            UserName = "mr_dee234"
                        },
                        new CustomerReview()
                        {
                            Rating = 4,
                            Review = "Too short - but definitely worth it for the price.",
                            UserName = "zanzubar11"
                        },

                    },
                    Images = new List<Image> {
                        new Image()
                        {
                            ImageUrl = "abzu.jpg"
                        },
                        new Image()
                        {
                            ImageUrl = "abzu-2.jpg"
                        },
                        new Image()
                        {
                            ImageUrl = "abzu-3.jpg"
                        }
                    },
                    SystemRequirements = new List<SystemRequirement>()
                    {
                        new SystemRequirement()
                        {
                            DirectX = 11,
                            Graphics = "NVIDIA GTX 650 2GB or AMD HD7770 2GB",
                            Memory = 8,
                            Processor = "Intel CPU Core i5-2500K 3.3GHz / AMD CPU Phenom II X4 940",
                            Storage = 52,
                            OS = "Windows 7 64 Bit"
                        }
                    }
                },
                new Game()
                {
                    Id = 4,
                    About = "The Witcher: Wild Hunt is a story-driven open world RPG set in a visually stunning fantasy universe full of meaningful choices and impactful consequences. In The Witcher, you play as professional monster hunter Geralt of Rivia tasked with finding a child of prophecy in a vast open world rich with merchant cities, pirate islands, dangerous mountain passes, and forgotten caverns to explore.",
                    Description = "As war rages on throughout the Northern Realms, you take on the greatest contract of your life — tracking down the Child of Prophecy, a living weapon that can alter the shape of the world.",
                    Developer = "CD PROJEKT RED",
                    Name = "The Witcher 3: Wild Hunt",
                    ReleaseDate = new DateTime(2015, 5, 18),
                    Price = 55.99m,
                    Publisher = "CD PROJEKT RED",
                    CustomerReviews = new List<CustomerReview>()
                    {
                        new CustomerReview()
                        {
                            Rating = 4,
                            Review = "Gritty and action packed!!!",
                            UserName = "e_sage16"
                        },
                        new CustomerReview()
                        {
                            Rating = 5,
                            Review = "Best game I ever played!",
                            UserName = "coolcool12"
                        },

                    },
                    Images = new List<Image> {
                        new Image()
                        {
                            ImageUrl = "the-witcher.jpg"
                        },
                        new Image()
                        {
                            ImageUrl = "the-witcher-2.jpg"
                        }

                    },
                    SystemRequirements = new List<SystemRequirement>()
                    {
                        new SystemRequirement()
                        {
                            DirectX = 11,
                            Graphics = "NVIDIA GTX 650 2GB or AMD HD7770 2GB",
                            Processor = "Intel CPU Core i5-2500K 3.3GHz / AMD CPU Phenom II X4 940",
                            Memory = 6,
                            Storage = 35,
                            OS = "Windows 7 64 Bit"
                        }
                    }
                },
                new Game()
                {
                    Id = 5,
                    About = "You wake up, alone, on a strange island full of puzzles that will challenge and surprise you.  You don't remember who you are, and you don't remember how you got here, but there's one thing you can do: explore the island in hope of discovering clues, regaining your memory, and somehow finding your way home.  The Witness is a single-player game in an open world with dozens of locations to explore and over 500 puzzles. This game respects you as an intelligent player and it treats your time as precious. There's no filler; each of those puzzles brings its own new idea into the mix. So, this is a game full of ideas.",
                    Description = "You wake up, alone, on a strange island full of puzzles that will challenge and surprise you.",
                    Developer = "Thekla, Inc.",
                    Name = "The Witness",
                    ReleaseDate = new DateTime(2016, 1, 26),
                    Price = 43.99m,
                    Publisher = "Thekla, Inc.",
                    CustomerReviews = new List<CustomerReview>()
                    {
                        new CustomerReview()
                        {
                            Rating = 1,
                            Review = "Yawn!  Puzzles get too repetitive",
                            UserName = "e_sage16"
                        },
                        new CustomerReview()
                        {
                            Rating = 5,
                            Review = "Stunning graphics and mind challenging puzzles sure to delight and intrigue.",
                            UserName = "coolcool12"
                        },

                    },
                    Images = new List<Image> {
                        new Image()
                        {
                            ImageUrl = "the-witness.jpg"
                        },
                        new Image()
                        {
                            ImageUrl = "the-witness-2.jpg"
                        }

                    },
                    SystemRequirements = new List<SystemRequirement>()
                    {
                        new SystemRequirement()
                        {
                            DirectX = 11,
                            Graphics = "NVIDIA GTX 650 2GB or AMD HD7770 2GB",
                            Processor = "Intel CPU Core i5-2500K 3.3GHz / AMD CPU Phenom II X4 940",
                            Memory = 4,
                            Storage = 5,
                            OS = "Windows 7"
                        }
                    }
                }

            });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}