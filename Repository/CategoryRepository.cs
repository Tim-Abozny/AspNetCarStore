using Gosha.Data;
using Gosha.Interfaces;
using Gosha.Models;

namespace Gosha.Repository
{
    public class CategoryRepository : ICarsCategory
    {
        private readonly AppDBcontext? AppDbContext;
        public CategoryRepository(AppDBcontext dBcontext) => this.AppDbContext = dBcontext;
        public IEnumerable<Category> Categories => AppDbContext.Category;
    }
}
