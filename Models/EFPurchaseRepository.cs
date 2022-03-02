using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace BookApp.Models
{
    public class EFPurchaseRepository : IPurchaseRepository
    {
        private BookstoreContext context;

        public EFPurchaseRepository(BookstoreContext temp)
        {
            context = temp;
        }

        public IQueryable<Purchase> Purchases => context.Purchases.Include(x => x.Lines);

        public void SavePurchase(Purchase purchase)
        {
            throw new NotImplementedException();
        }
    }
}
