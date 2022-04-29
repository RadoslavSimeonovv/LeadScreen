using LeadScreen.Data;
using LeadScreen.Data.Entities;
using LeadScreen.Services;
using LeadScreen.Services.DTOs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LeadScreen.Tests.SubareaTests
{
    /// <summary>
    /// Get subarea by pincode unit tests
    /// </summary>
    [TestClass]
    public class GetSubareaByPincode_Should
    {
        [TestMethod]
        public async Task GetSubareaByPincode_Should_Correct()
        {
            var options = Utils.GetOptions(nameof(GetSubareaByPincode_Should_Correct));

            var subarea = new Subarea
            {
                Id = 1,
                Name = "Mladost 1",
                Pincode = "1784"

            };

            using (var arrangeContext = new LeadScreenContext(options))
            {
                arrangeContext.Subarea.Add(subarea);
                await arrangeContext.SaveChangesAsync();
            }

            //Act,Assert
            using (var assertContext = new LeadScreenContext(options))
            {
                var sut = new SubareaService(assertContext);

                var pincode = "1784";
                var result = await sut.GetSubareasByPincode(pincode);
                Assert.AreEqual(1, result.Count);
                Assert.IsInstanceOfType(result, typeof(List<SubareaDTO>));
            }
        }

        [TestMethod]
        public async Task Throw_When_Subarea_DoesNotExist()
        {
            //Arrange
            var options = Utils.GetOptions(nameof(Throw_When_Subarea_DoesNotExist));
            var pincode = "1890";

            //Act,Assert
            using (var assertContext = new LeadScreenContext(options))
            {
                var sut = new SubareaService(assertContext);
                await Assert.ThrowsExceptionAsync<ArgumentNullException>
                    (async () => await sut.GetSubareasByPincode(pincode));
            }
        }
    }
}
