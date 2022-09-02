using Dojo.Bakery.BuildingBlocks.Commons;
using Dojo.Bakery.Inventory.Domain.Tests.Fakes;
using System;
using Xunit;

namespace Dojo.Bakery.Inventory.Domain.Tests
{
    public class StoreUnitTests
    {

        [Fact]
        public void Create_Store_WithValidParameters()
        {
            var store = StoreFakeData.CreateValidStore;
            Assert.IsNotType<DomainExceptionValidation>(store);
        }

        [Fact]
        public void Create_Store_Invalid_Name_DomainExceptionValidation()
        {
            var domainException = Assert.Throws<DomainExceptionValidation>(() => StoreFakeData.CreateStore_WithInvalidName);
            Assert.Equal("name value is required", domainException.Message);
        }

        [Fact]
        public void Create_Store_Invalid_DocumentNumber_DomainExceptionValidation()
        {
            var domainException = Assert.Throws<DomainExceptionValidation>(() => StoreFakeData.CreateStore_WithInvalidDocumentNumber);
            Assert.Equal("documentNumber value is required", domainException.Message);
        }

        #region Update

        [Fact]
        public void Update_StoreName_Without_Exception()
        {
            var store = StoreFakeData.CreateValidStore;
            store.ChangeName("Victoria Plaza");
            Assert.IsNotType<DomainExceptionValidation>(store);
            Assert.Equal("Victoria Plaza", store.Name);
        }

        [Fact]
        public void Update_StoreDocumentNumber_Without_Exception()
        {
            var store = StoreFakeData.CreateValidStore;
            store.ChangeDocumentNumber("9001245");
            Assert.IsNotType<DomainExceptionValidation>(store);
            Assert.Equal("9001245", store.DocumentNumber);
        }

        #endregion

    }
}
