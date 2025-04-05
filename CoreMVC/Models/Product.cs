using System.Runtime.Serialization;

namespace CoreMVC.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ProdDescription { get; set; }
        public Product(int id, string Name, double Price, String ProdDescription)
        {
            this.Id = id;
            this.Name = Name;
            this.Price = Price;
            this.ProdDescription = ProdDescription;
        }
    }
    /*
    public class BaseReview
    {
        [DataMember]

    }
    */
}
