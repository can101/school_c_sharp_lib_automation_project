using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_automation.Entities.Concrete
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int PrintYear { get; set; }
        public int PageSheetCount { get; set; }
        public string PrintHouse { get; set; }
        public string Language { get; set; }
        public string Abstract { get; set; }
        public string Book_Img { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
