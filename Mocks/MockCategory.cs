using Gosha.Interfaces;
using Gosha.Models;

namespace Gosha.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> Categories => new List<Category>
                {
                    new Category { CategoryName = "Electric cars", Description = "Cars evolution" },
                    new Category { CategoryName = "ICE cars", Description = "Internal combustion engine" }
                };
    }
}
