using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecipeApp.API.Entities
{
    public class Ingredient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(50)]
        public double? Quantity { get; set; }

        [MaxLength(50)]
        public string? Unit { get; set; }

        [ForeignKey("RecipeId")]
        public Recipe? Recipe { get; set; }
        public int RecipeId { get; set; }

        public Ingredient(string name)
        {
            Name = name;
        }
    }
}
