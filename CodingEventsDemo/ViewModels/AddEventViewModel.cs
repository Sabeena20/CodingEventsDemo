using System;
using System.ComponentModel.DataAnnotations;

namespace CodingEventsDemo.ViewModels
{
    public class AddEventViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description too long!")]
        public string Description { get; set; }

        [EmailAddress]
        public string ContactEmail { get; set; }

        [Required(ErrorMessage = "Please enter the location of the event")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Location must be between 3 and 20 characters.")]
        public string EventLocation { get; set; }

        [Required(ErrorMessage = "Please enter the number of people attending")]
        [Range(0, 100000)]
        public int NoOfAttendees { get; set; }
    }
}
