using System.ComponentModel.DataAnnotations;

namespace Soccer.BLL.DTO
{
    // Data Transfer Object - a special model for transferring data
    // The TeamDTO class should contain only the data that needs to be sent to the presentation layer or received from it
    public class TeamDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Club name is required")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "The Coach name is required")]
        public string? Coach { get; set; }
    }
}
