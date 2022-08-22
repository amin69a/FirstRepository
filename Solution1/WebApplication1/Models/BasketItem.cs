namespace WebApplication1.Models
{
    public class BasketItem
    {
        public BasketItem(int count, string name, string color)
        {
            Count = count;
            Name = name;
            Color = color;
        }
    
        public int Count { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
    }
}
