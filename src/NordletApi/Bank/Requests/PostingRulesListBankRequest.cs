using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostingRulesListBankRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
