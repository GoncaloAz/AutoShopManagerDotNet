namespace GarageService.SyncDataServices.Http
{
    public interface IGarageDataClient
    {
        Task SendCarToMaintenance();
    }
}