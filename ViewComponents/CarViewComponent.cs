using Gosha.Models;

namespace Gosha.ViewComponents
{
    public class CarViewComponent
    {
        public IEnumerable<Car>? cars { get; set; }
        public string? CurrentCategory { get; set; }
    }
}
