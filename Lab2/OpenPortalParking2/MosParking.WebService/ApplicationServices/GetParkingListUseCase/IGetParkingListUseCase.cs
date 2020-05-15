using System;
using System.Collections.Generic;
using System.Text;
using MosParking.ApplicationServices.Interfaces;

namespace MosParking.ApplicationServices.GetRouteListUseCase
{
    public interface IGetParkingListUseCase : IUseCase<GetParkingListUseCaseRequest, GetParkingListUseCaseResponse>
    {
    }
}
