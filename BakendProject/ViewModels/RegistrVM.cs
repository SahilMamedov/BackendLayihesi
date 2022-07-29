using System.ComponentModel.DataAnnotations;

namespace BakendProject.ViewModels
{
    public class RegistrVM
    {
        [Required, StringLength(100)]
        public string FullName { get; set; }
        [Required, StringLength(100)]
        public string UserName { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password), Compare("Password")]
        public string RepeatPassword { get; set; }
    }
}
