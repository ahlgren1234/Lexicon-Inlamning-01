using Lexicon_Inlamning_01.Web.Models;

namespace Lexicon_Inlamning_01.Web.Services;

public class RunningShoeService
{
    List<RunningShoe> runningshoes =
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

    public void Add(RunningShoe runningShoe)
    {
        runningShoe.Id = runningshoes.Count < 0 ? 1 : runningshoes.Max(r => r.Id) + 1;
        runningshoes.Add(runningShoe);
    }

    public RunningShoe[] GetAll() => runningshoes
        .OrderBy(r => r.Name)
        .ToArray();

    public RunningShoe GetById(int id) => runningshoes
        .Single(r => r.Id == id);
}
