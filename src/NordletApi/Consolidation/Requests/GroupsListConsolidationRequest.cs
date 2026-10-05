using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GroupsListConsolidationRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
