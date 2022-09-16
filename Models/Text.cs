using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LinkedList_Web.Models
{
    public class Text
    {
        [Key]
        public int IdText { get; set; }
        public int Elementos { get; set; }
    }
}