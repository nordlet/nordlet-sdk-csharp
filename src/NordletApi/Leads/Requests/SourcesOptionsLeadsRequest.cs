using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record SourcesOptionsLeadsRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
