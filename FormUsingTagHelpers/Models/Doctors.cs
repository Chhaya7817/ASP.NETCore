using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FormUsingTagHelpers.Models
{
    public class Doctors
    {
        [Required]
        public int ID { get; set; }
        [Required]
        [StringLength(10,MinimumLength =3)]
        public string Name { get; set; }
        public string Department { get; set; }  
            public int Salary { get; set; }
        public Gender Gender { get; set; }
        public int Description { get; set; }
        public int Married { get; set; }
        //[EmailAddress]
        [RegularExpression("^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\\.[a-zA-Z]{2,}$",ErrorMessage ="Invalid Email")]
        public string Email { get; set; }
        [Compare("Email")]
        [DisplayName("CCheck Email: ")]
        public string ConfirmEmail { get; set; }
    }
    public enum Gender
    {
        Male, Female
    }
}
