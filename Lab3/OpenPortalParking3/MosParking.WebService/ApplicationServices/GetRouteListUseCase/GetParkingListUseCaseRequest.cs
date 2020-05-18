using MosParking.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MosParking.ApplicationServices.GetParkingListUseCase
{
    public class GetParkingListUseCaseRequest : IUseCaseRequest<GetParkingListUseCaseResponse>
    {
        public long? OrganizationId { get; private set; }
        public long? ParkingId { get; private set; }

        private GetParkingListUseCaseRequest()
        { }

        public static GetParkingListUseCaseRequest CreateAllParkingsRequest()
        {
            return new GetParkingListUseCaseRequest();
        }

        public static GetParkingListUseCaseRequest CreateParkingRequest(long parkingId)
        {
            return new GetParkingListUseCaseRequest() { ParkingId = parkingId };
        }
        public static GetParkingListUseCaseRequest CreateOrganizationParkingsRequest(long organizationId)
        {
            return new GetParkingListUseCaseRequest() { OrganizationId = organizationId };
        }
    }
}
