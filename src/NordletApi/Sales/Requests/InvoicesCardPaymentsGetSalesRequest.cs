using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record InvoicesCardPaymentsGetSalesRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
