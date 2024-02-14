using BadmintonStars.Domain.Entities;
using BadmintonStars.Infrastructure.Data;
using BadmintonStars.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;


namespace BadmintonStars.Infrastructure.Test
{
    [TestFixture]
    public class PlayerRepositoryTests
    {
        private static readonly DbContextOptions<DataContext> dbContextOptions = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

        private DataContext? dbContext;

        [OneTimeSetUp]
        public void Setup()
        {
            dbContext = new DataContext(dbContextOptions);
            dbContext.Database.EnsureCreated();

            if (!dbContext.Players.Any())
            {
                for (int i = 0; i < 3; i++)
                {
                    dbContext.Players.Add(
                        new PlayerModel()
                        {
                            FirstName = "Number" + i.ToString(),
                            LastName = "Peng" + i.ToString(),
                            Club = "Lakers"
                        });

                    dbContext.SaveChanges();
                }
            }
        }

        [OneTimeTearDown]
        public void TearDown() 
        {
            dbContext?.Database.EnsureDeleted();
        }             
             

        [Test]
        public void PlayerRepository_CreatePlayer_Success()
        {
            // Arrange
            var player = new PlayerModel()
            {
                FirstName = "Peanut",
                LastName = "Butter",
                Club = "Lakers"
            };
           
            var playerRepository = new PlayerRepository(dbContext);

            // Act
            var result = playerRepository.CreatePlayer(player);

            // Assert
            Assert.IsNotNull(result);
        }

        [Test]
        public void PlayerRepository_GetPlayerById_Success()
        {
            // Arrange
            var playerRepository = new PlayerRepository(dbContext);

            // Act
            var result = playerRepository.GetPlayerById(1);

            // Assert
            Assert.AreEqual<int>(1, result.Id);
        }
    }
}