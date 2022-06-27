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
        public void SkipRecords(List<ProductModel> products)
        {
            var data = products.OrderByDescending(x => (x.rating)).Skip(5);
            foreach (var item in data)
            {
                Console.WriteLine("ProductID: " + item.productID + "\tUserID: " + item.userID + "\tRating: " + item.rating + "\tReview: " +
                     item.review + "\tIsLike: " + item.isLike);
            }
        }
        public DataTable DataTable()
        {
            DataTable datatable = new DataTable();
            datatable.Columns.Add("ProductID");
            datatable.Columns.Add("UserID");
            datatable.Columns.Add("Rating");
            datatable.Columns.Add("Review");
            datatable.Columns.Add("IsLike");

            datatable.Rows.Add(10, 1, 4.2, "Nice", true);
            datatable.Rows.Add(10, 2, 3.7, "Okay", true);
            datatable.Rows.Add(10, 3, 3.0, "Bad", false);
            datatable.Rows.Add(11, 1, 4.2, "Nice", true);
            datatable.Rows.Add(11, 2, 3.7, "Okay", true);
            datatable.Rows.Add(11, 3, 3.0, "Bad", false);
            datatable.Rows.Add(12, 1, 4.2, "Nice", true);
            datatable.Rows.Add(12, 2, 3.7, "Okay", true);
            datatable.Rows.Add(12, 3, 3.0, "Bad", false);
            datatable.Rows.Add(13, 1, 4.2, "Nice", true);
            datatable.Rows.Add(13, 2, 3.7, "Okay", true);
            datatable.Rows.Add(13, 3, 3.0, "Bad", false);
            datatable.Rows.Add(14, 1, 4.2, "Nice", true);
            datatable.Rows.Add(14, 2, 3.7, "Okay", true);
            datatable.Rows.Add(14, 3, 3.0, "Bad", false);
            datatable.Rows.Add(15, 1, 4.2, "Nice", true);
            datatable.Rows.Add(15, 2, 3.7, "Okay", true);
            datatable.Rows.Add(15, 3, 3.0, "Bad", false);
            datatable.Rows.Add(16, 1, 4.2, "Nice", true);
            datatable.Rows.Add(16, 2, 3.7, "Okay", true);
            datatable.Rows.Add(16, 3, 3.0, "Bad", false);
            datatable.Rows.Add(17, 1, 4.2, "Nice", true);
            datatable.Rows.Add(17, 2, 3.7, "Okay", true);
            datatable.Rows.Add(17, 3, 3.0, "Bad", false);
            datatable.Rows.Add(18, 1, 4.2, "Nice", true);
            return datatable;
        }
        public void ViewDataTable(DataTable products)
        {
            var column = from table in products.AsEnumerable() select table;
            foreach (var item in column)
            {
                Console.WriteLine("ProductID: " + item.Field<string>("ProductID") + "\tUserID: " + item.Field<string>("UserID") + "\tRating: " + item.Field<string>("Rating") + "\tReview: " +
                     item.Field<string>("Review") + "\tIsLike: " + item.Field<string>("IsLike"));
            }
        }
    }
}
