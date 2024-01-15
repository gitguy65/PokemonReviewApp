using PokemonReviewApp.Models;
using System.Collections.Generic;

namespace PokemonReviewApp.Interfaces
{
    public interface ICountryRepository
    {
        ICollection<Country> GetCountries();
        Country GetCountry(int id);
        Country GetCountryByOwner(int ownerId);
        ICollection<Owner> GetOwnersFromACountry(int countryId); 
        bool CountryExits(int countryId);
        bool CreateCountry(Country country);
    }
}
