﻿using MosParking.DomainObjects;
using MosParking.ApplicationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MosParking.ApplicationServices.GetParkingListUseCase
{
    public class GetParkingListUseCaseResponse : UseCaseResponse
    {
        public IEnumerable<Parking> Parkings { get; }

        public GetParkingListUseCaseResponse(IEnumerable<Parking> parkings) => Parkings = parkings;
    }
}
