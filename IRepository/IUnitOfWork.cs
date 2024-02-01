using System;
using System.Threading.Tasks;
using HotelListing.Data;

namespace HotelListing.IRepository
{
       public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Country> CountryRepository { get; }
        IGenericRepository<Hotel> HotelRepository { get; }
        Task Save();
    }
}