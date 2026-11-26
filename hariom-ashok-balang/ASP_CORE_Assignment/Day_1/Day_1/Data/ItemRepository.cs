using Day_1.Models;

namespace Day_1.Data
{
    public static class ItemRepository
    {
        public static List<Item> Items = new List<Item>
        {
            new Item { Id = 1, Name = "Pen", Quantity = 10 },
            new Item { Id = 2, Name = "Notebook", Quantity = 0 }
        };
    }
}
