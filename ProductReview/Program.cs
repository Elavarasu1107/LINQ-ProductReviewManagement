using System;

namespace ProductReview
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProductManagement getMethod = new ProductManagement();
            var table = getMethod.AddData();
            var dataTable = getMethod.DataTable();

            Console.WriteLine("Enter 1 to View Data\n2 to view Top 3 Data\n3 to view Rating > 3\n4 to Count ProductID" +
                "\n5 to view ProductID and Review\n6 to Skip Records\n7 to view DataTable\n8 to view True IsLike\n9 to Average Rating" +
                "\n\nEnter a Number");
            int userInput = Convert.ToInt32(Console.ReadLine());

            switch(userInput)
            {
                case 1:
                    {
                        getMethod.ViewData(table);
                        break;
                    }
                case 2:
                    {
                        getMethod.TopThreeData(table);
                        break;
                    }
                case 3:
                    {
                        getMethod.SpecificRecords(table);
                        break;
                    }
                case 4:
                    {
                        getMethod.Count(table);
                        break;
                    }
                case 5:
                    {
                        getMethod.SelectOperator(table);
                        break;
                    }
                case 6:
                    {
                        getMethod.SkipRecords(table);
                        break;
                    }
                case 7:
                    {
                        getMethod.ViewDataTable(dataTable);
                        break;
                    }
                case 8:
                    {
                        getMethod.IsLike(dataTable);
                        break;
                    }
                case 9:
                    {
                        getMethod.AverageRating(dataTable);
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Enter a valid Number");
                        break;
                    }
            }
        }
    }
}
