using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReview
{
    public class ProductManagement
    {
        public readonly DataTable table = new DataTable(); 
        public List<ProductModel> AddData()
        {
            List<ProductModel> table = new List<ProductModel>()
            {
                new ProductModel() {productID = 10,userID = 1,rating = 4.2,review = "Good",isLike = true},
                new ProductModel() {productID = 10,userID = 2,rating = 3.0,review = "Bad",isLike = false},
                new ProductModel() {productID = 10,userID = 3,rating = 3.7,review = "Okay",isLike = true},
                new ProductModel() {productID = 11,userID = 1,rating = 4.5,review = "Good",isLike = true},
                new ProductModel() {productID = 11,userID = 2,rating = 3.0,review = "Bad",isLike = false},
                new ProductModel() {productID = 11,userID = 3,rating = 3.7,review = "Okay",isLike = true},
                new ProductModel() {productID = 12,userID = 1,rating = 4.7,review = "Good",isLike = true},
                new ProductModel() {productID = 12,userID = 2,rating = 3.0,review = "Bad",isLike = false},
                new ProductModel() {productID = 12,userID = 3,rating = 3.7,review = "Okay",isLike = true},
                new ProductModel() {productID = 13,userID = 1,rating = 4.0,review = "Good",isLike = true},
                new ProductModel() {productID = 13,userID = 2,rating = 3.0,review = "Bad",isLike = false},
                new ProductModel() {productID = 13,userID = 3,rating = 3.7,review = "Okay",isLike = true},
                new ProductModel() {productID = 14,userID = 1,rating = 4.4,review = "Good",isLike = true},
                new ProductModel() {productID = 14,userID = 2,rating = 3.0,review = "Bad",isLike = false},
                new ProductModel() {productID = 14,userID = 3,rating = 3.7,review = "Okay",isLike = true},
                new ProductModel() {productID = 15,userID = 1,rating = 4.2,review = "Good",isLike = true},
                new ProductModel() {productID = 15,userID = 2,rating = 3.0,review = "Bad",isLike = false},
                new ProductModel() {productID = 15,userID = 3,rating = 3.7,review = "Okay",isLike = true},
                new ProductModel() {productID = 16,userID = 1,rating = 4.2,review = "Good",isLike = true},
                new ProductModel() {productID = 16,userID = 2,rating = 3.0,review = "Bad",isLike = false},
                new ProductModel() {productID = 16,userID = 3,rating = 3.7,review = "Okay",isLike = true},
                new ProductModel() {productID = 17,userID = 1,rating = 4.3,review = "Good",isLike = true},
                new ProductModel() {productID = 17,userID = 2,rating = 3.0,review = "Bad",isLike = false},
                new ProductModel() {productID = 17,userID = 3,rating = 3.7,review = "Okay",isLike = true},
                new ProductModel() {productID = 18,userID = 1,rating = 4.2,review = "Good",isLike = true}
            };
            return table;
        }
        public void ViewData(List<ProductModel> model)
        {
            foreach(var data in model)
            {
                 Console.WriteLine("ProductID: " + data.productID + "\tUserID: " + data.userID + "\tRating: " + data.rating + "\tReview: " +
                     data.review + "\tIsLike: " + data.isLike);
            }
        }
        public void TopThreeData(List<ProductModel> products)
        {
            var data = (from item in products orderby item.rating descending select item).Take(3);

            foreach(var item in data)
            {
                Console.WriteLine("ProductID: " + item.productID + "\tUserID: " + item.userID + "\tRating: " + item.rating + "\tReview: " +
                     item.review + "\tIsLike: " + item.isLike);
            }
        }
        public void SpecificRecords(List<ProductModel> products)
        {
            var data = from item in products where item.rating > 3 && (item.productID == 11 || item.productID == 14 || item.productID == 17)
                        select item;

            foreach(var item in data)
            {
                Console.WriteLine("ProductID: " + item.productID + "\tUserID: " + item.userID + "\tRating: " + item.rating + "\tReview: " +
                     item.review + "\tIsLike: " + item.isLike);
            }
        }
        public void Count(List<ProductModel> products)
        {
            var data = products.GroupBy(x => (x.productID)).Select(x => new{productID = x.Key, count = x.Count()});
            foreach (var item in data)
            {
                Console.WriteLine("ProductID: " + item.productID + " has Count of: " + item.count);
            }
        }
        public void SelectOperator(List<ProductModel> products)
        {
            var data = products.Select(x => (x.productID, x.review));

            foreach (var item in data)
            {
                Console.WriteLine("ProductID: " + item.productID + "\tReview: " + item.review);
            }
        }
    }
}
