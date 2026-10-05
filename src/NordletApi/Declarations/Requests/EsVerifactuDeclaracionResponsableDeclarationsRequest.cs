using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EsVerifactuDeclaracionResponsableDeclarationsRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
