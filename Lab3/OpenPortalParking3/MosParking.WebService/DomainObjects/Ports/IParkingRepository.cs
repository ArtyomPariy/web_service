using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace MosParking.DomainObjects.Ports
{
    public interface IReadOnlyRouteRepository
    {
        Task<Parking> GetParking(long id);

        Task<IEnumerable<Parking>> GetAllParkings();

        Task<IEnumerable<Parking>> QueryParkings(ICriteria<Parking> criteria);

    }

    public interface IRouteRepository
    {
        Task AddParking(Parking parking);

        Task RemoveParking(Parking parking);

        Task UpdateParking(Parking parking);
    }
}
