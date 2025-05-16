using System.ComponentModel.DataAnnotations;

namespace Lexicon_Inlamning_01.Web.Models;

public class RunningShoe
{
    public int Id { get; set; }

    [Required(ErrorMessage = "You must enter a shoe")]
    public string Name { get; set; } = null!;

    [Required(ErrorMessage = "You must enter a price")]
    public decimal Price { get; set; }
}
