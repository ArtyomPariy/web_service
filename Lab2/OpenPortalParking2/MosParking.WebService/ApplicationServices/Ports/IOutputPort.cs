using System;
using System.Collections.Generic;
using System.Text;

namespace MosParking.ApplicationServices.Ports
{
    public interface IOutputPort<in TUseCaseResponse>
    {
        void Handle(TUseCaseResponse response);
    }
}
