using System.Linq.Expressions;
using Hectre.HarvestManagement.Core.Interfaces;
using Hectre.HarvestManagement.Core.Models;
using Microsoft.Extensions.Logging;
using Moq;

namespace Hectre.HarvestManagement.Services.UnitTests
{
    [TestClass]
    public class OrchardServiceTest
	{
        [TestMethod]
        public async Task Test_Get_Orchard_recotds()
        {
            var mockUnitOfWork = new Mock<IUnitOfWork>();

            var mockOrchardRepository = new Mock<IGenericRepository<Orchard>>();

            mockOrchardRepository.Setup(p => p.GetAsync(It.IsAny<Expression<Func<Orchard, bool>>>(), It.IsAny<Func<IQueryable<Orchard>, IOrderedQueryable<Orchard>>>(), It.IsAny<string>()))
                .ReturnsAsync(new List<Orchard>()
                {
                new Orchard(),
                new Orchard()
                });

            mockUnitOfWork.Setup(p => p.OrchardRepository).Returns(mockOrchardRepository.Object);

            var orchardService = new OrchardService(
                mockUnitOfWork.Object,
                new Mock<ILogger<OrchardService>>().Object);

            var res = await orchardService.GetAllAsync();


            Assert.AreEqual(res.Count, 2);
        }
    }
}

