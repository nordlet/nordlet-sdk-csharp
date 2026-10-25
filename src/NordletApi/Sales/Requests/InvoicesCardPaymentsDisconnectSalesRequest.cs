using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record InvoicesCardPaymentsDisconnectSalesRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
