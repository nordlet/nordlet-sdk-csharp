using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ConfigsListDeclarationsRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
