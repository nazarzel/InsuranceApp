using InsuranceApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsuranceApp.Repositories
{
    public interface IOfferRepository
    {
        void CreateNewOfferAsync(Offer offer);
        Task<IEnumerable<Offer>> GetAllOffersAsync();
        Task<Offer> GetOfferByIdAsync(int offerId);
        void UpdateOffer(Offer offerToUpdate);
        void DeleteOffer(Offer offerToDelete);
        void SaveAsync();
    }
}
