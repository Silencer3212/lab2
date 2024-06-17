// This is a personal academic project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com
namespace ProtectedWeb.Models
{
    public class Sneaker
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Logo { get; set; }
        public string? Description { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public ICollection<Review> Reviews { get; set; }
        public Sneaker()
        {
            Reviews = new List<Review>();
        }
    }
}
