using Project_1.Models;
using Information = Project_1.Models.Information;

namespace Project_1.Services
{
    public interface IInformationServices
    {
        Information update(Information information);
        Information Delete(Information information);
        Task<Information> GetById(string name);
    }
}
