using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public string date { get; set; }
        public string ISBNNumber { get; set; }
        public double price { get; set; }
    }
}
