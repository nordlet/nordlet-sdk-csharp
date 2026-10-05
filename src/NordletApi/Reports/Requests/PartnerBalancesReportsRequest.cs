using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PartnerBalancesReportsRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
