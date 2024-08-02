using SmartShoppingList.Server.Models;

namespace SmartShoppingList.Server.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
    }
}
