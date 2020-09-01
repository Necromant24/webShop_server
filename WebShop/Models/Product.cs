using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace WebShop
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public string? ImgSrc { get; set; }
        
        public int ProductCounterId { get; set; }
        
        public ProductCounter ProductCounter { get; set; }

        

        void print<T>(T i)
        {
            Console.WriteLine(i);
        }

        public void printThis()
        {
            print("-----------");
            print("Product:");
            print(Name);
            print(Type1);
            print(Type2);
            print(Description);
            print(Price);
            print(ImgSrc);
            print(ProductCounterId);
        }
        


    }
}