using Lexicon_Inlamning_01.Web.Models;
using System.ComponentModel.DataAnnotations;

namespace Lexicon_Inlamning_01.Web.Views.RunningShoes;

public class CreateVM
{
    [Required(ErrorMessage = "You must specify a name")]
    public required string Name { get; set; }

    [Required(ErrorMessage = "You must specify a price")]
    public required string Price { get; set; }
}
