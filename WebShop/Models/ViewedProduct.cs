using System;

namespace WebShop
{
    public class ViewedProduct
    {

        public ViewedProduct(Product product)
        {
            Console.WriteLine(product.ProductCounterId+" - counter id");
            
            Id = product.Id;
            Name = product.Name;
            Type1 = product.Type1;
            Type2 = product.Type2;
            Description = product.Description;
            Price = product.Price;
            ImgSrc = product.ImgSrc;
            Count = product.ProductCounter.Count;
        }
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string ImgSrc { get; set; }
        public int? Count { get; set; }
    }
}