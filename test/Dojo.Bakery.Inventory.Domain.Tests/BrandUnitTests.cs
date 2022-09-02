using Dojo.Bakery.BuildingBlocks.Commons;
using Xunit;

namespace Dojo.Bakery.Inventory.Domain.Tests
{
    public class BrandUnitTests
    {
        [Fact]
        public void Create_Brand_WithValidParameters()
        {
            var brand = new Brand("Haz de Oroz");
            Assert.IsNotType<DomainExceptionValidation>(brand);
        }

        [Fact]
        public void Create_Brand_Invalid_Name_DomainExceptionValidation()
        {
            var domainException = Assert.Throws<DomainExceptionValidation>(() => new Brand(string.Empty));
            Assert.Equal("name value is required", domainException.Message);
        }
    }
}
