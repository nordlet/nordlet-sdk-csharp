using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record TypesOptionsLeadsRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
