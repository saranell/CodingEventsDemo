using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Your event needs a name!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Your event needs a description!")]
        [StringLength(500, ErrorMessage = "Description too long!")]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

        [Required(ErrorMessage ="Your event needs a location!")]
        public string Location { get; set; }

        [Range(0, 100000, ErrorMessage ="Must be a number between 0 and 100,000.")]
        public int NumberOfAttendees { get; set; }
    }
}
