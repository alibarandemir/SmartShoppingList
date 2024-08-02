namespace SmartShoppingList.Server.Models
{
    public class ProductDto
    {
        
        public string Name { get; set; }
        public int MarketId {  get; set; }
        public Category CategoryName { get; set; }    
        public decimal Price { get; set; }

    }
    public enum Category
    {
        Yiyecek,
        Sebze,
        Meyve,
        İçecek,
        Diğer
    }
}
