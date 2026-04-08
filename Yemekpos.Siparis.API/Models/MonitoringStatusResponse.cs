namespace Yemekpos.Siparis.API.Models;

public sealed record MonitoringStatusResponse(
    IReadOnlyList<KioskStatusItem> Kiosks,
    int TotalOrdersToday,
    decimal TotalRevenueToday);

public sealed record KioskStatusItem(
    string KioskId,
    string Status);
