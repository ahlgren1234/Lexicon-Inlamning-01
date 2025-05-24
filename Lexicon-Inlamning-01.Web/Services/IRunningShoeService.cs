using Lexicon_Inlamning_01.Web.Models;

namespace Lexicon_Inlamning_01.Web.Services;

public interface IRunningShoeService
{
    List<RunningShoe> GetAll();
    void Add(RunningShoe shoe);
    RunningShoe GetById(int id);
}
