using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record LtRegionsListReferenceRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
