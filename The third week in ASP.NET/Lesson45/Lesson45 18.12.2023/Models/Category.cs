using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lesson40_04._12._2023.Models
{
    public class Category
    {
        [ Key] //atributlar
        public int Id { get; set; }
        [Required(ErrorMessage ="Name can not be empty")]
        [StringLength(50)]
        public string CategoryName { get; set; }
        [NotMapped]
        public int Test {  get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
