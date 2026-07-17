using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AccountApiKeysListRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
