using System;
using System.Linq;

namespace BookApp.Models
{
    public class IPurchaseRepository
    {
        IQueryable<Purchase> Purchases { get; }

        public void SavePurchase(Purchase purchase);
    }
}
