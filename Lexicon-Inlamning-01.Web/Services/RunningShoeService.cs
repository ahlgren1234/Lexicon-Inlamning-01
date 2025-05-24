using Lexicon_Inlamning_01.Web.Models;

namespace Lexicon_Inlamning_01.Web.Services;

public class RunningShoeService : IRunningShoeService
{
    readonly List<RunningShoe> shoes =
    [
        new RunningShoe()
        {
            Id = 23,
            Name = "Adidas Adizero Pro 4",
            Price = 300
        },
        new RunningShoe()
        {
            Id = 63,
            Name = "Craft Kype Pro",
            Price = 320
        },
        new RunningShoe()
        {
            Id = 456,
            Name = "Mizuno Wave Rebellion Pro 3",
            Price = 290
        },
        new RunningShoe()
        {
            Id = 36,
            Name = "Nike Alphafly 3",
            Price = 275
        },
        new RunningShoe()
        {
            Id = 3456,
            Name = "Asics Metaspeed Sky Paris",
            Price = 279
        },
    ];

    public void Add(RunningShoe shoe)
    {
        shoes.Add(shoe);
    }

    public List<RunningShoe> GetAll()
    {
        return shoes;
    }

    public RunningShoe GetById(int id) => shoes
        .Single(r => r.Id == id);
}
