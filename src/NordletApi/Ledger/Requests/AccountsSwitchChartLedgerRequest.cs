using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record AccountsSwitchChartLedgerRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
