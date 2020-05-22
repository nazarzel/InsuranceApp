using InsuranceApp.Data;
using InsuranceApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace InsuranceApp.Repositories
{
    public class OfferRepository : IOfferRepository
    {
        private readonly ApplicationDbContext context;

        public OfferRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async void CreateNewOfferAsync(Offer offer)
        {
            await context.Offers.AddAsync(offer);
            SaveAsync();
        }

        public void DeleteOffer(Offer offerToDelete)
        {
            context.Offers.Remove(offerToDelete);
        }

        public async Task<IEnumerable<Offer>> GetAllOffersAsync()
        {
            return await context.Offers.OrderBy(o => o.CarType).ToListAsync();
        }

        public async Task<Offer> GetOfferByIdAsync(int offerId)
        {
            return await context.Offers.Where(o => o.Id == offerId).FirstOrDefaultAsync();
        }

        public void UpdateOffer(Offer offerToUpdate)
        {
            context.Offers.Update(offerToUpdate);
            SaveAsync();
        }
        public async void SaveAsync()
        {
            if (await context.SaveChangesAsync() > 0)
                throw new Exception("Saving the data has failed on save");
        }
    }
}
