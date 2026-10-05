using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EuSmeThresholdsListDeclarationsRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
