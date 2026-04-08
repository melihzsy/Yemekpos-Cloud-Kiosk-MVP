using Yemekpos.Siparis.API.Models;

namespace Yemekpos.Siparis.API.Services;

public sealed class MonitoringService : IMonitoringService
{
    private static readonly string[] Statuses = ["Online", "Offline"];

    public async Task<MonitoringStatusResponse> GetStatusAsync(CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();

        var kiosks = Enumerable.Range(1, 5)
            .Select(index => new KioskStatusItem(
                KioskId: $"KIOSK-{index:000}",
                Status: Statuses[Random.Shared.Next(Statuses.Length)]))
            .ToList();

        var totalOrdersToday = Random.Shared.Next(120, 620);
        var totalRevenueToday = Math.Round((decimal)Random.Shared.NextDouble() * 55000m + 5000m, 2);

        await Task.Delay(20, cancellationToken);

        return new MonitoringStatusResponse(
            Kiosks: kiosks,
            TotalOrdersToday: totalOrdersToday,
            TotalRevenueToday: totalRevenueToday);
    }
}
