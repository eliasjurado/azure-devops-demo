using Dojo.Bakery.BuildingBlocks.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Dojo.Bakery.Inventory.Domain.Tests
{
    public class UnitUnitTests
    {
        [Fact]
        public void Create_Unit_WithValidParameters()
        {
            var unit = new Unit("Pounds");
            Assert.IsNotType<DomainExceptionValidation>(unit);
        }

        [Fact]
        public void Create_Unit_Invalid_Name_DomainExceptionValidation()
        {
            var domainException = Assert.Throws<DomainExceptionValidation>(() => new Unit(string.Empty));
            Assert.Equal("name value is required", domainException.Message);
        }

    }
}
