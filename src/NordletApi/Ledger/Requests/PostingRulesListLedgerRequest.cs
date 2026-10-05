using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostingRulesListLedgerRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
