using Microsoft.AspNetCore.Mvc;
using Yemekpos.Siparis.API.Models;

namespace Yemekpos.Siparis.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class OrdersController(ILogger<OrdersController> logger) : ControllerBase
{
    private readonly ILogger<OrdersController> _logger = logger;

    [HttpPost]
    public async Task<IActionResult> CreateOrderAsync([FromBody] Order order, CancellationToken cancellationToken)
    {
        cancellationToken.ThrowIfCancellationRequested();

        _logger.LogInformation(
            "Bulut Sistem: {KioskId} numaralı Kiosk'tan {TotalPrice} TL tutarında sipariş başarıyla buluta ulaştı.",
            order.KioskId,
            order.TotalPrice);

        await Task.CompletedTask;
        return Ok(new { message = "Sipariş başarıyla alındı." });
    }
}
