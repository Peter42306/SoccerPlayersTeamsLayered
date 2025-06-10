using System.ComponentModel.DataAnnotations;

namespace Soccer.BLL.DTO
{
    // Data Transfer Object - a special model for transferring data
    // The PlayerDTO class should contain only the data that needs to be sent to the presentation layer or received from it
    public class PlayerDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name is required")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "The Age is required")]
        public int Age { get; set; }

        [Required(ErrorMessage = "The position is required")]
        public string? Position { get; set; }

        public int? TeamId { get; set; }

        public string? Team { get; set; }
    }
}
