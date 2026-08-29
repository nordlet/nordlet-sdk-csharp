using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReferenceEuVatRatesSyncRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
