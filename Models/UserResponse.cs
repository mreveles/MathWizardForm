using System.ComponentModel.DataAnnotations;

namespace MathWizardForm.Models
{

    public class UserResponse
    {

        [Required(ErrorMessage = "Please enter a Number")]
        public string Left { get; set; }

        [Required(ErrorMessage = "Please enter a Number")]
        public string Right { get; set; }

        [Required(ErrorMessage = "Please specify a math function")]
        public string MathFunction { get; set; }
    }
}