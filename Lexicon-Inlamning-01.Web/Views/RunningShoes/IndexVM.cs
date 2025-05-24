using Lexicon_Inlamning_01.Web.Models;

namespace Lexicon_Inlamning_01.Web.Views.RunningShoes;

public class IndexVM
{
    public RunningShoeVM[] RunningShoeVMs { get; set; } = null;

    public class RunningShoeVM
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal Price { get; set; }
    }
}

