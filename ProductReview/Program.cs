using System;

namespace ProductReview
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProductManagement getMethod = new ProductManagement();
            var table = getMethod.AddData();

            Console.WriteLine("Enter 1 to View Data\n2 to view Top 3 Data\n3 to view Rating > 3\n4 to Count ProductID" +
                "\n5 to view ProductID and Review\n\nEnter a Number");
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
                default:
                    {
                        Console.WriteLine("Enter a valid Number");
                        break;
                    }
            }
        }
    }
}
