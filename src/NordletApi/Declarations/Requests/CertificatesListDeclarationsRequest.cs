using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record CertificatesListDeclarationsRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
