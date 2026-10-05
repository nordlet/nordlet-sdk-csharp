using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record IntrastatThresholdsListReferenceRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
