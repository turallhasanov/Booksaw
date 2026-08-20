using System.ComponentModel.DataAnnotations;

namespace Booksaw.ViewModels.Categories
{
    public class CategoryCreateVM
    {
        [Required (ErrorMessage ="Name is requid")]
        public  string Name { get; set; }
    }
}
