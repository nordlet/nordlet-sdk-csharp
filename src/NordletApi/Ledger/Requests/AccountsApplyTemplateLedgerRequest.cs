using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record AccountsApplyTemplateLedgerRequest
{
    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
