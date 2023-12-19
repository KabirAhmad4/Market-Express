using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDA.Classes
{
    public class Product
    {
        // Properties
        public int ProductID { get; set; }
        public int AddedByUserID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ProductCategory { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int LikesCount { get; set; }
        public int ReviewsCount { get; set; }
        public int Available { get; set; }

        // Constructor
        public Product(
            int productID,
            int addedByUserID,
            string name,
            string description,
            string productCategory,
            decimal price,
            int quantity,
            int likesCount,
            int reviewsCount,
            int available)
        {
            ProductID = productID;
            AddedByUserID = addedByUserID;
            Name = name;
            Description = description;
            ProductCategory = productCategory;
            Price = price;
            Quantity = quantity;
            LikesCount = likesCount;
            ReviewsCount = reviewsCount;
            Available = available;
        }
        public Product()
        {
            ProductID = 0;
            AddedByUserID = 0;
            Name = "";
            Description = "";
            ProductCategory = "";
            Price = 0;
            Quantity = 0;
            LikesCount = 0;
            ReviewsCount = 0;
            Available = 0;
        }


        public Product(int productID,string name,string description,string productCategory,decimal price)
        {
            ProductID = productID;
            AddedByUserID = 0;
            Name = name;
            Description = description;
            ProductCategory = productCategory;
            Price = price;
            Quantity = 0;
            LikesCount = 0;
            ReviewsCount = 0;
            Available = 1;
        }
        // You can add methods or additional functionality as needed
    }

}
