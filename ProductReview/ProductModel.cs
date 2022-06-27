using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReview
{
    public class ProductModel
    {
        public int productID { get; set; }
        public int userID { get; set; }
        public double rating { get; set; }
        public string review { get; set; }
        public bool isLike { get; set; }
    }
}
