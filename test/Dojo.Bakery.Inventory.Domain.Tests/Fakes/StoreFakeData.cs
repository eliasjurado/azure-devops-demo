using System;

namespace Dojo.Bakery.Inventory.Domain.Tests.Fakes
{
    public class StoreFakeData
    {
        public static Store CreateValidStore
        {
            get
            {
                return new Store(Guid.NewGuid(), "Sede Chapinero", "9001234");
            }
        }

        public static Store CreateStore_WithInvalidName
        {
            get
            {
                return new Store(Guid.NewGuid(), string.Empty, "9001234");
            }
        }
        public static Store CreateStore_WithInvalidAddress
        {
            get
            {
                return new Store(Guid.NewGuid(), "Sede Chapinero", string.Empty);
            }
        }

        public static Store CreateStore_WithInvalidDocumentNumber
        {
            get
            {
                return new Store(Guid.NewGuid(), "Sede Chapinero", string.Empty);
            }
        }

    }
}
