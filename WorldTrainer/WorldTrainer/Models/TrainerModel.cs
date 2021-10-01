using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorldTrainer.Models
{
    public class TrainerModel
    {
        public int TrainerId { get; set; }
        [Required(ErrorMessage = "Name cannot be blank")]
        [StringLength(maximumLength: 50, ErrorMessage = "name  should be between 2 to 50 characters", MinimumLength = 2)]
        public string TrainerName { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string TrainerEmail { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^[789]\d{9}$", ErrorMessage = "Not a valid phone number")]
        public string TrainerPhone { get; set; }
        [Required(ErrorMessage = "Address cannot be blank")]
        [StringLength(maximumLength: 50, ErrorMessage = "Address should be between 2 to 50 characters", MinimumLength = 15)]
        public string TrainerAddress { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string TrainerPassword { get; set; }
        public string Gender { get; set; }
    }
}
