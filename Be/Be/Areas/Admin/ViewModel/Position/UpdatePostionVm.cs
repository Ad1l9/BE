using System.ComponentModel.DataAnnotations;

namespace Be.Areas.Admin.ViewModel.Position
{
    public class UpdatePostionVm
    {
        [Required]
        [MaxLength(50,ErrorMessage = "Name's max length must be 50 words")]
        public string Name { get; set; }
    }
}
