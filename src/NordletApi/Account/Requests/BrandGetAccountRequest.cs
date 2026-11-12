using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record BrandGetAccountRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
