using SalesWebMvc.Controllers;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList(); 
        }

        public static implicit operator SellerService(SellersController v)
        {
            throw new NotImplementedException();
        }

        public void Insert(Seller obj)
        {
            _context.Sdd(obj);
            _context.SaveChanges();
        }
    }
}
