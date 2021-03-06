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
       public readonly DataTable datatable = new DataTable();
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
            datatable.Columns.Add("ProductID",typeof(Int32));
            datatable.Columns.Add("UserID", typeof(Int32));
            datatable.Columns.Add("Rating",typeof(double));
            datatable.Columns.Add("Review", typeof(string));
            datatable.Columns.Add("IsLike", typeof(bool));

            datatable.Rows.Add(10, 1, 4.2, "Nice", true);
            datatable.Rows.Add(10, 2, 3.7, "Okay", true);
            datatable.Rows.Add(10, 3, 3.0, "Bad", true);
            datatable.Rows.Add(11, 1, 4.2, "Nice", true);
            datatable.Rows.Add(11, 2, 3.7, "Okay", true);
            datatable.Rows.Add(11, 3, 3.0, "Bad", true);
            datatable.Rows.Add(12, 1, 4.2, "Nice", true);
            datatable.Rows.Add(12, 2, 3.7, "Okay", true);
            datatable.Rows.Add(12, 3, 3.0, "Bad", true);
            datatable.Rows.Add(13, 1, 4.2, "Nice", true);
            datatable.Rows.Add(13, 2, 3.7, "Okay", true);
            datatable.Rows.Add(13, 3, 3.0, "Bad", true);
            datatable.Rows.Add(14, 1, 4.2, "Nice", true);
            datatable.Rows.Add(14, 2, 3.7, "Okay", true);
            datatable.Rows.Add(14, 3, 3.0, "Bad", true);
            datatable.Rows.Add(15, 1, 4.2, "Nice", true);
            datatable.Rows.Add(15, 2, 3.7, "Okay", true);
            datatable.Rows.Add(15, 3, 3.0, "Bad", true);
            datatable.Rows.Add(16, 1, 4.2, "Nice", true);
            datatable.Rows.Add(16, 2, 3.7, "Okay", true);
            datatable.Rows.Add(16, 3, 3.0, "Bad", true);
            datatable.Rows.Add(17, 1, 4.2, "Nice", true);
            datatable.Rows.Add(17, 2, 3.7, "Okay", true);
            datatable.Rows.Add(17, 3, 3.0, "Bad", true);
            datatable.Rows.Add(18, 1, 4.5, "Nice", true);
            datatable.Rows.Add(21, 1, 3.5, "Okay", true);
            datatable.Rows.Add(22, 1, 3.7, "Okay", true);
            datatable.Rows.Add(23, 1, 4.7, "Nice", true);
            datatable.Rows.Add(24, 1, 4.5, "Nice", true);
            datatable.Rows.Add(25, 1, 2.5, "Bad", false);

            return datatable;
        }
        public void ViewDataTable(DataTable products)
        {
            var column = products.AsEnumerable();
            foreach (var item in column)
            {
                Console.WriteLine("ProductID: " + item.Field<int>("ProductID") + "\tUserID: " + item.Field<int>("UserID") + "\tRating: " + 
                    item.Field<double>("Rating") + "\tReview: " + item.Field<string>("Review") + "\tIsLike: " + item.Field<bool>("IsLike"));
            }
        }
        public void IsLike(DataTable products)
        {
            var data = products.AsEnumerable().Where(x => (x.Field<bool>("IsLike") == true));
            foreach (var item in data)
            {
                Console.WriteLine("ProductID: " + item.Field<int>("ProductID") + "\tUserID: " + item.Field<int>("UserID") + "\tRating: " +
                    item.Field<double>("Rating") + "\tReview: " + item.Field<string>("Review") + "\tIsLike: " + item.Field<bool>("IsLike"));
            }
        }
        public void AverageRating(DataTable products)
        {
            var data = products.AsEnumerable().GroupBy(x => (x.Field<int>("ProductID"))).
                Select(x => new {productID = x.Key, average = x.Average(s => (s.Field<double>("Rating")))});
            foreach (var item in data)
            {
                Console.WriteLine("ProductID: " + item.productID + "\tAverage: " + item.average);
            }
        }
        public void ReviewMessage(DataTable products)
        {
            var data = products.AsEnumerable().Where(x => (x.Field<string>("Review") == "Nice"));
            foreach (var item in data)
            {
                Console.WriteLine("ProductID: " + item.Field<int>("ProductID") + "\tUserID: " + item.Field<int>("UserID") + "\tRating: " +
                    item.Field<double>("Rating") + "\tReview: " + item.Field<string>("Review") + "\tIsLike: " + item.Field<bool>("IsLike"));
            }
        }
        public void AdditionalData(DataTable products)
        {
            var data = products.AsEnumerable().OrderBy(x => (x.Field<double>("Rating"))).Where(x => (x.Field<int>("UserId") == 1));
            foreach (var item in data)
            {
                Console.WriteLine("ProductID: " + item.Field<int>("ProductID") + "\tUserID: " + item.Field<int>("UserID") + "\tRating: " +
                    item.Field<double>("Rating") + "\tReview: " + item.Field<string>("Review") + "\tIsLike: " + item.Field<bool>("IsLike"));
            }
        }
    }
}
