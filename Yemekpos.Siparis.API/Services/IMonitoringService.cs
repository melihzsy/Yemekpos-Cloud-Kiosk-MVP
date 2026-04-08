using Yemekpos.Siparis.API.Models;

namespace Yemekpos.Siparis.API.Services;

public interface IMonitoringService
{
    Task<MonitoringStatusResponse> GetStatusAsync(CancellationToken cancellationToken);
}
