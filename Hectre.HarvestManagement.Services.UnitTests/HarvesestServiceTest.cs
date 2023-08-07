using System.Linq.Expressions;
using Hectre.HarvestManagement.Core.Interfaces;
using Hectre.HarvestManagement.Core.Models;
using Microsoft.Extensions.Logging;
using Moq;

namespace Hectre.HarvestManagement.Services.UnitTests;

[TestClass]
public class HarvesestServiceTest
{
   
    [TestMethod]
    public async Task Test_Get_Harvest_recotds()
    {
        var mockUnitOfWork = new Mock<IUnitOfWork>();

        var mockHarvestRepository = new Mock<IGenericRepository<Harvest>>();

        mockHarvestRepository.Setup(p => p.GetAsync(It.IsAny<Expression<Func<Harvest, bool>>>(), It.IsAny<Func<IQueryable<Harvest>, IOrderedQueryable<Harvest>>>(), It.IsAny<string>()))
            .ReturnsAsync(new List<Harvest>()
            {
                new Harvest(),
                new Harvest()
            }) ;

        mockUnitOfWork.Setup(p => p.HarvestRepository).Returns(mockHarvestRepository.Object);

        var harvestService = new HarvestService(
            new Mock<ILogger<HarvestService>>().Object,
            mockUnitOfWork.Object);

        var res = await harvestService.FindRecords(new List<Guid>(), DateTime.Today.AddDays(-1), DateTime.Today);


        Assert.AreEqual(res.Count, 2);
    }
}
