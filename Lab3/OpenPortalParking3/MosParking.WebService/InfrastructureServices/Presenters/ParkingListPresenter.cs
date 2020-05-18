using MosParking.ApplicationServices.GetRouteListUseCase;
using System.Net;
using Newtonsoft.Json;
using MosParking.ApplicationServices.Ports;

namespace MosParking.InfrastructureServices.Presenters
{
    public class ParkingListPresenter : IOutputPort<GetParkingListUseCaseResponse>
    {
        public JsonContentResult ContentResult { get; }

        public ParkingListPresenter()
        {
            ContentResult = new JsonContentResult();
        }

        public void Handle(GetParkingListUseCaseResponse response)
        {
            ContentResult.StatusCode = (int)(response.Success ? HttpStatusCode.OK : HttpStatusCode.NotFound);
            ContentResult.Content = response.Success ? JsonConvert.SerializeObject(response.Parkings) : JsonConvert.SerializeObject(response.Message);
        }
    }
}
