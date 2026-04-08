using Microsoft.AspNetCore.Mvc;
using Yemekpos.Siparis.API.Services;

namespace Yemekpos.Siparis.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class MonitoringController(
    IMonitoringService monitoringService,
    ILogger<MonitoringController> logger) : ControllerBase
{
    private readonly IMonitoringService _monitoringService = monitoringService;
    private readonly ILogger<MonitoringController> _logger = logger;

    [HttpGet("status")]
    public async Task<IActionResult> GetStatusAsync(CancellationToken cancellationToken)
    {
        var status = await _monitoringService.GetStatusAsync(cancellationToken);

        _logger.LogInformation(
            "Monitoring status requested. KioskCount: {KioskCount}, OrdersToday: {OrdersToday}, RevenueToday: {RevenueToday}",
            status.Kiosks.Count,
            status.TotalOrdersToday,
            status.TotalRevenueToday);

        return Ok(status);
    }
}
