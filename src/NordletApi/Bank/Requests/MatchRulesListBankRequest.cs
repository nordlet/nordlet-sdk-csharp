using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record MatchRulesListBankRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
