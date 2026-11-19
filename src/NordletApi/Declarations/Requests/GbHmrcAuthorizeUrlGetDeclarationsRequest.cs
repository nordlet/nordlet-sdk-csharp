using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GbHmrcAuthorizeUrlGetDeclarationsRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
