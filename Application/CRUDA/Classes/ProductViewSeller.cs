using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDA.Classes
{
    public class ProductViewSeller
    {
        // Properties
        public int ProductID { get; set; }
       
        public string Seller { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductCategory { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int LikesCount { get; set; }
        public int ReviewsCount { get; set; }
        public int Available { get; set; }

        // Constructor
        public ProductViewSeller(
            int ProductID,
            string Seller, 
            string name,
            string description,
            string productCategory,
            decimal price,
            int quantity,
            int likesCount,
            int reviewsCount,
            int available)
        {
            this.ProductID = ProductID;
            this.Seller = Seller;
            Name = name;
            Description = description;
            ProductCategory = productCategory;
            Price = price;
            Quantity = quantity;
            LikesCount = likesCount;
            ReviewsCount = reviewsCount;
            Available = available;
        }
        public ProductViewSeller()
        {
            ProductID = 0;
            Seller = "";
            Name = "";
            Description = "";
            ProductCategory = "";
            Price = 0;
            Quantity = 0;
            LikesCount = 0;
            ReviewsCount = 0;
            Available = 0;
        }

        // You can add methods or additional functionality as needed
    }
}
