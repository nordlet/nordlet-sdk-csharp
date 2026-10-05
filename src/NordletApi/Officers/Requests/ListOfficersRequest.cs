using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ListOfficersRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
