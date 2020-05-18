using MosParking.DomainObjects;
using MosParking.DomainObjects.Ports;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace MosParking.ApplicationServices.GetParkingListUseCase
{
    public class TransportOrganizationCriteria : ICriteria<Parking>
    {
        public long TransportOrganizationId { get; }

        public TransportOrganizationCriteria(long transportOrganizationId)
            => TransportOrganizationId = transportOrganizationId;

        public Expression<Func<Parking, bool>> Filter
            => (r => r.Organization.Id == TransportOrganizationId);
    }
}
