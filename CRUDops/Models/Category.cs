namespace CRUDops.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual List<Category> Categories { get; set; }
    }
}
