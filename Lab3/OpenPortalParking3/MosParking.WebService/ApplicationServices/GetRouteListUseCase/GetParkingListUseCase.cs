using System.Threading.Tasks;
using System.Collections.Generic;
using MosParking.DomainObjects;
using MosParking.DomainObjects.Ports;
using MosParking.ApplicationServices.Ports;

namespace MosParking.ApplicationServices.GetParkingListUseCase
{
    public class GetParkingListUseCase : IGetParkingListUseCase
    {
        private readonly IReadOnlyParkingRepository _readOnlyParkingRepository;

        public GetParkingListUseCase(IReadOnlyParkingRepository readOnlyParkingRepository) 
            => _readOnlyParkingRepository = readOnlyParkingRepository;

        public async Task<bool> Handle(GetParkingListUseCaseRequest request, IOutputPort<GetParkingListUseCaseResponse> outputPort)
        {
            IEnumerable<Parking> parkings = null;
            if (request.RouteId != null)
            {
                var parking = await _readOnlyParkingRepository.GetParking(request.ParkingId.Value);
                parkings = (parking != null) ? new List<Parking>() { parking } : new List<Parking>();
                
            }
            else if (request.OrganizationId != null)
            {
                parkings = await _readOnlyParkingRepository.QueryParkings(new TransportOrganizationCriteria(request.OrganizationId.Value));
            }
            else
            {
                parkings = await _readOnlyParkingRepository.GetAllParkings();
            }
            outputPort.Handle(new GetParkingListUseCaseResponse(parkings));
            return true;
        }
    }
}
