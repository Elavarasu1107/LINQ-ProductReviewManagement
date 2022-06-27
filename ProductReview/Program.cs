using System;

namespace ProductReview
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ProductManagement getMethod = new ProductManagement();
            var table = getMethod.AddData();

            Console.WriteLine("Enter 1 to View Data\n2 to view Top 3 Data\n\nEnter a Number");
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
            }
        }
    }
}
