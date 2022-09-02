using Dojo.Bakery.BuildingBlocks.Commons;
using Xunit;

namespace Dojo.Bakery.Inventory.Domain.Tests
{
    public class DocumentUnitTests
    {
        [Fact]
        public void Create_DocumentType_WithValidParameters()
        {
            var documentType = new DocumentType("Lacteos");
            Assert.IsNotType<DomainExceptionValidation>(documentType);
        }

        [Fact]
        public void Create_DocumentType_Invalid_Name_DomainExceptionValidation()
        {
            var domainException = Assert.Throws<DomainExceptionValidation>(() => new DocumentType(string.Empty));
            Assert.Equal("name value is required", domainException.Message);
        }

    }
}
