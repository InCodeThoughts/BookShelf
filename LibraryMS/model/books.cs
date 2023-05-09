using System.ComponentModel.DataAnnotations;

namespace LibraryMS.model
{
    public class books
    {
        [Key]
        public int BookID { get; set; }
        public String BookTital { get; set; }
        public string BookDiscripction { get; set; }
    }
}
