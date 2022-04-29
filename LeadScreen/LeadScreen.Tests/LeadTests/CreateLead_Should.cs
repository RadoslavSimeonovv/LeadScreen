using LeadScreen.Data;
using LeadScreen.Services;
using LeadScreen.Services.DTOs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace LeadScreen.Tests.LeadTests
{
    /// <summary>
    /// Create lead unit tests
    /// </summary>
    [TestClass]
    public class CreateLead_Should
    {
        [TestMethod]
        public async Task CreateLead_Should_Correct()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(CreateLead_Should));
            var leadDTO = new LeadDTO()
            {
                Id = 1,
                Name = "bul.Malinov",
                Email = "malinov@mail.bg",
                MobileNumber = "0884123333",
                Pincode = "1823",
                SubAreaId = 1,
                Address = "Mladost 3",
            };

            //Act,Assert
            using (var assertContext = new LeadScreenContext(options))
            {
                var sut = new LeadService(assertContext);

                var result = await sut.CreateLead(leadDTO);
                Assert.AreEqual(leadDTO.Id, result.Id);
                Assert.AreEqual(leadDTO.Name, result.Name);
            }
        }
    }
}
