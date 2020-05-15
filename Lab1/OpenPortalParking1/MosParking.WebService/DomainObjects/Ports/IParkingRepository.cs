using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace MosParking.DomainObjects.Ports
{
    public interface IReadOnlyParkingRepository
    {
        Task<Parking> GetParking(long id);

        Task<IEnumerable<Parking>> GetAllParking();

        Task<IEnumerable<Parking>> QueryParking(ICriteria<Parking> criteria);

    }

    public interface IParkingRepository
    {
        Task AddParking(Parking parking);

        Task RemoveParking(Parking parking);

        Task UpdateParking(Parking parking);
    }
}
