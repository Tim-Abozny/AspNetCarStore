using Gosha.Models;

namespace Gosha.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> Categories { get; }
    }
}
