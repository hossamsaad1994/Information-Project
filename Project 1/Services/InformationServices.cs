
using Microsoft.EntityFrameworkCore;
using Project_1.Models;

namespace Project_1.Services
{
    public class InformationServices : IInformationServices 
    {
        private readonly ApplicationDbContext _context;

        public InformationServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public Information Delete(Information information)
        {
            _context.Remove(information);
            _context.SaveChanges();
            return information;
        }

        public async Task<Information> GetById(string name) 
        {
            return await _context.Informations.SingleOrDefaultAsync( x => x.Name==name);
        }

        public Information update(Information information)
        {
            _context.Update(information);
            _context.SaveChanges();
            return information;
        }
    }
}
